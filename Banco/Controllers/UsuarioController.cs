using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoBackend.Entidades;
using BancoBackend.Service;
using BancoBackend.Service.UsuarioServ;

namespace BancoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpPost("/obtenerUsuario")]
        public IActionResult GetUsuario(Usuario usuario)
        {
            try
            { if (ServiceFactoryProducer.GetFactory().GetUsuarioService().GetUsuario(usuario) == null)
                {
                    return Ok("No hay usuarios que coincidan");
                }
                else {
                    return Ok(ServiceFactoryProducer.GetFactory().GetUsuarioService().GetUsuario(usuario));
                }
            }
            catch (Exception)
            {
                return BadRequest("Ingrese un usuario Valido");
            }

        }

        [HttpPost("/insertarUsuario")]
        public IActionResult InsertarUsuario(Usuario usuario) {

            if (ServiceFactoryProducer.GetFactory().GetUsuarioService().InsertarUsuario(usuario))
            {
                return Ok(ServiceFactoryProducer.GetFactory().GetUsuarioService().InsertarUsuario(usuario));
            }
            else
            {
                return BadRequest("No se pudo insertar el usuario");
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
