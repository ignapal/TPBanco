using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.UsuarioServ
{
    public interface IUsuarioService
    {
        Usuario GetUsuario(Usuario usuario);
        bool InsertarUsuario(Usuario usuario);
    }
}
