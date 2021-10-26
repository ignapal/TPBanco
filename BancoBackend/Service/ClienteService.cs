using BancoBackend.DAO;
using BancoBackend.DAO.Implementaciones;
using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service
{
    public class ClienteService : IService
    {
        ClienteDaoImpl clienteDao = new ClienteDaoImpl();
        public Cliente GetCliente()
        {
            return clienteDao.GetCliente();
        }
    }
}
