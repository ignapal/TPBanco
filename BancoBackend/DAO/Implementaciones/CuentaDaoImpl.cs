using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO.Implementaciones
{
    class CuentaDaoImpl : ICuentaDao
    {
        public DataTable GetCuentas()
        {
            return HelperDao.GetInstancia().GetTable("OBTENER_TIPOS_CUENTA", new Dictionary<string,object>());
        }

        public DataTable ValidarCbu(decimal cbu)
        {   
            Dictionary<string, object> parametros = new();
            parametros.Add("@cbu",cbu);
            return HelperDao.GetInstancia().GetTable("VALIDAR_CBU_REPETIDA", parametros);
        }
    }
}
