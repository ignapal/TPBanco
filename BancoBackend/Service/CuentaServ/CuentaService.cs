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

        public bool EliminarCuenta(decimal cbu)
        {
            cuentaDao = new CuentaDaoImpl();
            return cuentaDao.EliminarCuenta(cbu);
        }

        public List<Cuenta> GetCuentas(int idCliente)
        {
            try
            {
                cuentaDao = new CuentaDaoImpl();
                DataTable table = cuentaDao.GetCuentas(idCliente);
                List<Cuenta> cuentas = new();

                foreach (DataRow row in table.Rows)
                {
                    Cuenta cuenta = new();
                    cuenta.IdCliente = Convert.ToInt32(row["idCliente"]);
                    cuenta.Cbu = Convert.ToDecimal(row["cbu"]);
                    cuenta.Saldo = Convert.ToDecimal(row["saldo"]);
                    cuenta.TipoCuenta = Convert.ToInt32(row["idTipoCuenta"]);
                    cuenta.FechaBaja = DBNull.Value.Equals(row["fechaBaja"]) ? null : Convert.ToDateTime(row["fechaBaja"]);
                    cuenta.UltimoMovimiento.IdMovimiento = DBNull.Value.Equals(row["ultimoMovimiento"]) ? null : Convert.ToInt32(row["ultimoMovimiento"]);

                    cuentas.Add(cuenta);
                }

                return cuentas;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public List<Cuenta> GetCuentasActivas(int idCliente)
        {
            try
            {
                return GetCuentas(idCliente).FindAll(cuenta => cuenta.FechaBaja is null);
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public List<TipoCuenta> GetTiposCuentas()
        {
            cuentaDao = new CuentaDaoImpl();
            DataTable table = cuentaDao.GetTiposCuenta();

            List<TipoCuenta> tiposCuenta = new();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    TipoCuenta tipoCuenta = new(Convert.ToInt32(row["idTipoCuenta"]), row["tipoCuenta"].ToString());
                    tiposCuenta.Add(tipoCuenta);
                }
                return tiposCuenta;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public bool InsertarCuenta(Cuenta cuenta)
        {
            cuentaDao = new CuentaDaoImpl();
            return cuentaDao.InsertarCuenta(cuenta);
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
