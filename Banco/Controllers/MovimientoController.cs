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
    public class MovimientoController : ControllerBase
    {
        [HttpGet("/getUltimoMovimientoId")]
        public IActionResult GetUltimoMovimientoId() {

            try
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetMovimientoService().ObtenerUltimoId());
            }
            catch (Exception)
            {
                return StatusCode(500, "No se pudo obtener el ultimo id");
            }
            
        }

        [HttpPost("/insertarMovimiento")]
        public IActionResult InsertarMovimiento(Movimiento movimiento)
        {
            try
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetMovimientoService().InsertarMovimiento(movimiento));
            }
            catch (Exception)
            {
                return StatusCode(500, "No se pudo insertar el movimiento.");
            }
            
        }
    }
}
