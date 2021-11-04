using BancoBackend.DAO;
using BancoBackend.DAO.Implementaciones;
using BancoBackend.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.ClienteServ
{
    public class ClienteService : IClienteService
    {
        IClienteDao clienteDao;

        public List<Cliente> GetClientesActivos()
        {

            try
            {
                return GetClientes().FindAll(cliente => cliente.FechaBaja is null); 
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public List<Cliente> GetClientes()
        {
            clienteDao = new ClienteDaoImpl();

            try
            {
                DataTable table = clienteDao.GetClientes();
                List<Cliente> clientes = new();

                foreach (DataRow row in table.Rows)
                {
                    Cliente cliente = new();

                    cliente.IdCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.Nombre = row["nombre"].ToString();
                    cliente.Apellido = row["apellido"].ToString();
                    cliente.Dni = Convert.ToInt32(row["nroDoc"]);
                    cliente.FechaBaja = DBNull.Value.Equals(row["fechaBaja"]) ? null : Convert.ToDateTime(row["fechaBaja"]);

                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public int GetUltimoId()
        {
            clienteDao = new ClienteDaoImpl();
            return clienteDao.GetUltimoId();
        }

        public bool InsertarCliente(Cliente cliente)
        {
            clienteDao = new ClienteDaoImpl();
            
            return clienteDao.InsertarCliente(cliente);
        }
    }
}
