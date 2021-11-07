using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO
{
    interface ICuentaDao
    {
        DataTable GetTiposCuenta();
        DataTable GetCuentas(int idCliente);
        DataTable ValidarCbu(decimal cbu);
        bool InsertarCuenta(Cuenta cuenta);
        bool EliminarCuenta(decimal cbu);
    }
}
