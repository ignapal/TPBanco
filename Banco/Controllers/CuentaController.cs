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
    public class CuentaController : ControllerBase
    {
        [HttpGet("/getTiposCuenta")]
        public IActionResult GetTipoCuentas() {
            try
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetCuentaService().GetCuentas());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
            
        }


        [HttpGet("/validarCbu/{cbu}")]
        public IActionResult ValidarCbu(decimal cbu)
        {
            try
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetCuentaService().ValidarCbu(cbu));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
