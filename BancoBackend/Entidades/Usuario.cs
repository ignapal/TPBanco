﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }

        public Usuario() {
            Nombre = "";
            Contrasenia = "";
        }
        public Usuario(string nombre,string contrasenia)
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
        }
    }
}
