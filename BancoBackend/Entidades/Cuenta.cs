using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    public class Cuenta
    {
        public int IdCliente { get; set; }
        public decimal Cbu { get; set; }
        public decimal Saldo { get; set; }
        public int TipoCuenta { get; set; }
        public Movimiento UltimoMovimiento { get; set; }
        public DateTime? FechaBaja { get; set; }

        public Cuenta()
        {
            IdCliente = 0;
            Cbu = 0;
            Saldo = 0;
            TipoCuenta = 0;
            UltimoMovimiento = new Movimiento();
        }

        public Cuenta(int idCliente, decimal cbu, decimal saldo, int tipoCuenta, Movimiento ultimoMovimiento,DateTime fechaBaja)
        {
            IdCliente = idCliente;
            Cbu = cbu;
            Saldo = saldo;
            TipoCuenta = tipoCuenta;
            UltimoMovimiento = ultimoMovimiento;
            FechaBaja = fechaBaja;
        }

        public override string ToString()
        {
            return Cbu.ToString();
        }
    }
}
