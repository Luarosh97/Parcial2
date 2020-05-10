using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class EntidadElectricaribe : Entidad
    {

        public EntidadElectricaribe() { }
        public EntidadElectricaribe(string tipo, DateTime fecha, string numeroRecibo, decimal valorPagado) :
            base("electricaribe", fecha, numeroRecibo, valorPagado)
        {
        }
    }
}
