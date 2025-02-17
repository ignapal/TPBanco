﻿using BancoBackend.DAO.Implementaciones;
using BancoBackend.DAO.Interfaces;
using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.UsuarioServ
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioDao usuarioDao;
        public Usuario GetUsuario(Usuario usuario)
        {
            usuarioDao = new UsuarioDaoImpl();
            

            try
            {
                DataTable table = usuarioDao.GetUsuario(usuario);
                Usuario usuario1 = new();
                usuario1.Nombre = table.Rows[0]["nombreUsuario"].ToString();
                usuario1.Contrasenia = table.Rows[0]["contrasenia"].ToString();
                return usuario1;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            usuarioDao = new UsuarioDaoImpl();
            try
            {
                return usuarioDao.InsertarUsuario(usuario);
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
