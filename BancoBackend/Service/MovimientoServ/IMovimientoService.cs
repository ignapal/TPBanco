using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.MovimientoServ
{
    public interface IMovimientoService
    {
        bool InsertarMovimiento(Movimiento movimiento);
        int ObtenerUltimoId();
    }
}
