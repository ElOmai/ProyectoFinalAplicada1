using ProyectoAplicadaI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProyectoAplicadaI.BLL
{
    public class EmpeñosDetalleBLL
    {
        public static List<EmpeñosDetalle> GetList(Expression<Func<EmpeñosDetalle, bool>> expression)
        {
            List<EmpeñosDetalle> recibos = new List<EmpeñosDetalle>();
            Contexto contexto = new Contexto();
            try
            {
                recibos = contexto.Detalles.Where(expression).ToList();
                recibos.ToList().Count();
            }
            catch (Exception) { throw; }
            return recibos;
        }
    }
}
