using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class ExportarService
    {

        private ExportarRepository exportacionRepository;
        public ExportarService()
        {
            exportacionRepository = new ExportarRepository();
        }
        public string ExportarPorEntidad(string Tipo, IList<Entidad> entidades)
        {


            try
            {
                exportacionRepository.ExportarPorEntidad(Tipo, entidades);
                return $"Los datos de las entidades seleccionadas han sido exportados correctamente";
            }
            catch (Exception E)
            {
                return "Error de lectura o escritura de archivos: " + E.Message;
            }
        }
    }
}
