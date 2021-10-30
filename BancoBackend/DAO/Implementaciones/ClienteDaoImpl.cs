using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO.Implementaciones
{
    class ClienteDaoImpl : IClienteDao
    {
       
        public bool InsertarCliente(Cliente cliente)
        {
            return HelperDao.GetInstancia().InsertarCliente(cliente);
        }
    }
}
