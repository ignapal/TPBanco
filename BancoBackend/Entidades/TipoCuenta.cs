using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    public class TipoCuenta
    {
        public int IdTipoCuenta { get; set; }
        public string NombreTipoCuenta { get; set; }

        public TipoCuenta() {
            IdTipoCuenta = 0;
            NombreTipoCuenta = "";
        }
        public TipoCuenta(int idTipoCuenta, string nombreTipoCuenta)
        {
            IdTipoCuenta = idTipoCuenta;
            NombreTipoCuenta = nombreTipoCuenta;
        }
        public override string ToString()
        {
            return NombreTipoCuenta;
        }
    }
}
