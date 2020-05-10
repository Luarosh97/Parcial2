using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class ResponseConsulta
    {
        public string Mensaje { get; set; }
        public IList<Entidad> entidades { get; set; }
        public bool Error { get; set; }

    }
    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public Entidad entidad { get; set; }
        public bool Error { get; set; }
    }
}

