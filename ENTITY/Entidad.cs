using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Entidad
    {
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public string Numerorecibo { get; set; }

        public decimal ValorPagado { get; set; }

        public Entidad() { }
        public Entidad(string tipo, DateTime fecha, string numeroRecibo, decimal valorPagado)
        {

            Tipo = tipo;
            Fecha = fecha;
            Numerorecibo = numeroRecibo;
            ValorPagado = valorPagado;


        }
        public override string ToString()
        {
            return $"{Tipo};{Fecha};{Numerorecibo};{ValorPagado}";
        }
    }
}
