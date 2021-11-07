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
                return Ok(ServiceFactoryProducer.GetFactory().GetCuentaService().GetTiposCuentas());
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

        [HttpGet("/obtenerCuentasActivas/{idCliente}")]
        public IActionResult GetCuentasActivas(int idCliente)
        {
            List<Cuenta> cuentas = ServiceFactoryProducer.GetFactory().GetCuentaService().GetCuentasActivas(idCliente);
            if (cuentas != null && cuentas.Count > 0)
            {
                return Ok(cuentas);
            }
            else
            {
                return Ok("No hay cuentas activos");
            }

        }

        [HttpGet("/obtenerCuentas/{idCliente}")]
        public IActionResult GetCuentas(int idCliente)
        {
            List<Cuenta> cuentas = ServiceFactoryProducer.GetFactory().GetCuentaService().GetCuentas(idCliente);
            if (cuentas != null && cuentas.Count > 0)
            {
                return Ok(cuentas);
            }
            else
            {
                return Ok("No hay cuentas");
            }

        }
        [HttpPost("/insertarCuenta")]
        public IActionResult InsertarCuenta(Cuenta cuenta)
        {
            try
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetCuentaService().InsertarCuenta(cuenta));
            }
            catch (Exception)
            {
                return StatusCode(500, "No se pudo insertar la cuenta");
            }

        }
    }
}
