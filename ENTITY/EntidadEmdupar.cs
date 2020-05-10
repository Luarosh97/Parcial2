using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class EntidadEmdupar : Entidad
    {
        public EntidadEmdupar() { }
        public EntidadEmdupar(string tipo, DateTime fecha, string numeroRecibo, decimal valorPagado) :
            base("Emdupar", fecha, numeroRecibo, valorPagado)
        {
        }
    }
}
