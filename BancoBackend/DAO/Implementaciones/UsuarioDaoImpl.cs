﻿using BancoBackend.DAO.Interfaces;
using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO.Implementaciones
{
    class UsuarioDaoImpl : IUsuarioDao
    {
        public DataTable GetUsuario(Usuario usuario)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@nombreUsuario",usuario.Nombre);
            parametros.Add("@contrasenia",usuario.Contrasenia);

            return HelperDao.GetInstancia().GetTable("SP_OBTENER_USUARIO", parametros);
        }
        
    }
}
