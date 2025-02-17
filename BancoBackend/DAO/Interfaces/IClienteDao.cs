﻿using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO
{
    interface IClienteDao
    {
        int GetUltimoId();

        bool InsertarCliente(Cliente cliente);
        DataTable GetClientes();
    }
}
