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
    }
}
