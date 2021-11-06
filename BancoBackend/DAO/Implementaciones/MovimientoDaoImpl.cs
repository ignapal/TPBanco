using BancoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DAO.Implementaciones
{
    class MovimientoDaoImpl : IMovimientoDao
    {
        public bool InsertarMovimiento(Movimiento movimiento)
        {
            Dictionary<string, object> parametros = new();
            parametros.Add("@idMovimiento",movimiento.IdMovimiento);
            parametros.Add("@cbuOrigen",movimiento.CbuOrigen);
            parametros.Add("@cbuDestino",movimiento.CbuDestino);
            parametros.Add("@monto",movimiento.Monto);

            return HelperDao.GetInstancia().InsertarEntidad("SP_INSERTAR_MOVIMIENTO",parametros);
        }

        public int ObtenerUltimoId()
        {
            return HelperDao.GetInstancia().GetUltimoId("OBTENER_PROXIMO_ID_MOVIMIENTO", "@proximoID");
        }
    }
}
