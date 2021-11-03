using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public decimal CbuOrigen { get; set; }
        public decimal CbuDestino { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Movimiento(int idMovimiento, decimal cbuOrigen, decimal cbuDestino, decimal monto, DateTime fecha)
        {
            IdMovimiento = idMovimiento;
            CbuOrigen = cbuOrigen;
            CbuDestino = cbuDestino;
            Monto = monto;
            Fecha = fecha;
        }

        public Movimiento()
        {
            IdMovimiento = 0;
            CbuOrigen = 0;
            CbuDestino = 0;
            Monto = 0;
            Fecha = new DateTime();
        }
    }
}
