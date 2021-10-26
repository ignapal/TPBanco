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
    [Route("banco/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        IService clienteService = new ClienteService();


        [HttpGet]
        public IActionResult GetCliente() {
            try
            {
                return Ok(clienteService.GetCliente());
            }
            catch {
                return BadRequest("Error al obtener el cliente");
            }
            
        }
    }
}
