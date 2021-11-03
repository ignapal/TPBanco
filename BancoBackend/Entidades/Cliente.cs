using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    public class Cliente
    {
        

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }

        public List<Cuenta> Cuentas { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Nombre = "";
            Apellido = "";
            Dni = 0;
            Cuentas = new List<Cuenta>();
        }

        public Cliente(int idCliente, string nombre, string apellido, int dni, List<Cuenta> cuentas)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Cuentas = cuentas;
        }
    }
}
