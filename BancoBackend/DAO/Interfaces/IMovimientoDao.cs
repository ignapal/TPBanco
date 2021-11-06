﻿using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO
{
    interface IMovimientoDao
    {
        bool InsertarMovimiento(Movimiento movimiento);
        int ObtenerUltimoId();
    }
}
