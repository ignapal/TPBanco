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

        [HttpPost]
        public Usuario GetUsuario(Usuario usuario)
        {
           return ServiceFactoryProducer.GetFactory().GetUsuarioService().GetUsuario(usuario);
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
