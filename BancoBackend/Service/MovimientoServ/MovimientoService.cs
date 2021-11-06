using BancoBackend.DAO;
using BancoBackend.DAO.Implementaciones;
using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service.MovimientoServ
{
    public class MovimientoService : IMovimientoService
    {
        IMovimientoDao movimientoDao;
        public bool InsertarMovimiento(Movimiento movimiento)
        {
            movimientoDao = new MovimientoDaoImpl();
            try
            {
                return movimientoDao.InsertarMovimiento(movimiento);
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public int ObtenerUltimoId()
        {
            movimientoDao = new MovimientoDaoImpl();
            return movimientoDao.ObtenerUltimoId();
            
        }
    }
}
