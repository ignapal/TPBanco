using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    class Cuenta
    {
        public decimal Cbu { get; set; }
        public decimal Saldo { get; set; }
        public int TipoCuenta { get; set; }
        public Movimiento UltimoMovimiento { get; set; }
    }
}
