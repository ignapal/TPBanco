using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    class Movimiento
    {
        public int IdMovimiento { get; set; }
        public decimal CbuOrigen { get; set; }
        public decimal CbuDestino { get; set; }
        public decimal Monto { get; set; }
        public DateTime fecha { get; set; }
    }
}
