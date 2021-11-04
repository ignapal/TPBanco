using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.ClienteServ
{
    public interface IClienteService
    {
        int GetUltimoId();
        bool InsertarCliente(Cliente cliente);
        List<Cliente> GetClientesActivos();
        List<Cliente> GetClientes();
    }
}
