using BancoBackend.DAO;
using BancoBackend.DAO.Implementaciones;
using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.CuentaServ
{
    public class CuentaService : ICuentaService
    {
        ICuentaDao cuentaDao;
        public List<TipoCuenta> GetCuentas()
        {
            cuentaDao = new CuentaDaoImpl();
            DataTable table = cuentaDao.GetCuentas();

            List<TipoCuenta> tiposCuenta = new List<TipoCuenta>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    TipoCuenta tipoCuenta = new TipoCuenta();
                    tipoCuenta.IdTipoCuenta = Convert.ToInt32(row["idTipoCuenta"]);
                    tipoCuenta.NombreTipoCuenta = row["tipoCuenta"].ToString();

                    tiposCuenta.Add(tipoCuenta);
                }
                return tiposCuenta;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public bool ValidarCbu(decimal cbu)
        {
            try
            {
                cuentaDao = new CuentaDaoImpl();
                DataTable table = cuentaDao.ValidarCbu(cbu);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
