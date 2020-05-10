using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class EntidadGasCaribe : Entidad
    {
        public EntidadGasCaribe() { }

        public EntidadGasCaribe(string tipo, DateTime fecha, string numeroRecibo, decimal valorPagado) :
            base("GasCaribe", fecha, numeroRecibo, valorPagado)
        {
        }
    }
}
