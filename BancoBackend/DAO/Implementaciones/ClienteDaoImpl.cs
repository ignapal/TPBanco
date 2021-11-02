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
        public int GetUltimoId()
        {
            return HelperDao.GetInstancia().GetUltimoId("OBTENER_PROXIMO_ID", "@proximoID");
        }
    }
}
