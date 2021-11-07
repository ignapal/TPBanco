using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.CuentaServ
{
    public interface ICuentaService
    {
        List<TipoCuenta> GetTiposCuentas();
        List<Cuenta> GetCuentas(int idCliente);
        List<Cuenta> GetCuentasActivas(int idCliente);
        bool ValidarCbu(decimal cbu);

        bool InsertarCuenta(Cuenta cuenta);
    }
}
