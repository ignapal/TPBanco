﻿using BancoBackend.Service.ClienteServ;
using BancoBackend.Service.CuentaServ;
using BancoBackend.Service.MovimientoServ;
using BancoBackend.Service.UsuarioServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service
{
    public class ServiceFactoryImpl : AbstractServiceFactory
    {
        public override IClienteService GetClienteService()
        {
            return new ClienteService();
        }

        public override ICuentaService GetCuentaService()
        {
            return new CuentaService();
        }

        public override IMovimientoService GetMovimientoService()
        {
            return new MovimientoService();
        }

        public override IUsuarioService GetUsuarioService()
        {
            return new UsuarioService();
        }
        
    }
}
