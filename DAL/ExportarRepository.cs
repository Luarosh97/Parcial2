using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;

namespace DAL
{
    public class ExportarRepository
    {
        private string ruta;

        public void ExportarPorEntidad(string Tipo, IList<Entidad> entidades)
        {
            AsignarRuta(Tipo);
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            Guardado Archivo = new Guardado();
            foreach (var item in entidades)
            {
                Archivo.Guardar(item, ruta);
            }
        }
        public void AsignarRuta(string Tipo)
        {
            ruta = @"EntidadEmdupares.txt";
            if (Tipo == "Emdupares")
            {
                ruta = @"EntidadesEmdupares.txt";
            }
        }
    }
}
