using BancoBackend.Service.ClienteServ;
using BancoBackend.Service.CuentaServ;
using BancoBackend.Service.UsuarioServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service
{
    public abstract class AbstractServiceFactory
    {
         abstract public IUsuarioService GetUsuarioService();
         abstract public IClienteService GetClienteService();
         abstract public ICuentaService GetCuentaService();
    }
}
