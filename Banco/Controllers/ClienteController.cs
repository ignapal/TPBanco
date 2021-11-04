using BancoBackend.Entidades;
using BancoBackend.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet("/getUltimoId")]
        public IActionResult GetUltimoId() {
            try
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetClienteService().GetUltimoId());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpPost("/insertarCliente")]
        public IActionResult InsertarCliente(Cliente cliente) {
            bool result = ServiceFactoryProducer.GetFactory().GetClienteService().InsertarCliente(cliente);
            if (result)
            {
                return Ok(result);
            }
            else { 
                return StatusCode(500,"Fallo al insertar cliente con cuentas");
            }
            
        }
        [HttpGet("/obtenerClientesActivos")]
        public IActionResult GetClientesActivos()
        {
            List<Cliente> clientes = ServiceFactoryProducer.GetFactory().GetClienteService().GetClientesActivos();
            if (clientes != null && clientes.Count > 0)
            {
                return Ok(clientes);
            }
            else
            {
                return Ok("No hay clientes activos");
            }

        }

        [HttpGet("/obtenerClientes")]
        public IActionResult GetClientes()
        {
            List<Cliente> clientes = ServiceFactoryProducer.GetFactory().GetClienteService().GetClientes();
            if (clientes != null && clientes.Count > 0)
            {
                return Ok(clientes);
            }
            else
            {
                return Ok("No hay clientes");
            }

        }
    }
}
