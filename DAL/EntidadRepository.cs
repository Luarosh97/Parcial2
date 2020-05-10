using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    public class EntidadRepository
    {
        private string ruta = @"entidades.txt";
        public IList<Entidad> entidades;

        public EntidadRepository()
        {
            entidades = new List<Entidad>();
        }
        public void Guardar(Entidad entidad)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter stream = new StreamWriter(fileStream);
            stream.WriteLine(entidad.ToString());
            stream.Close();
            fileStream.Close();
        }
        public IList<Entidad> Consultar()
        {
            entidades.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Entidad entidad = MapearEntidad(linea);
                entidades.Add(entidad);
            }
            lector.Close();
            fileStream.Close();
            return entidades;
        }

       public  Entidad MapearEntidad(string linea)
        {
            string[] datos = linea.Split(';');
           
            string Tipo = datos[0];
            DateTime Fecha = DateTime.Parse(datos[1]);
            string NumeroRecibo= datos[2];
            decimal ValorPagado = decimal.Parse( datos[3]);

            if (Tipo == "Electricaribe")
            {
                Entidad entidadElectricaribe = new EntidadElectricaribe(Tipo, Fecha, NumeroRecibo, ValorPagado);


                return entidadElectricaribe;
            }
           if (Tipo=="Emdupar")
            {
                Entidad entidadEmdupar = new EntidadEmdupar(Tipo, Fecha, NumeroRecibo, ValorPagado);


                return entidadEmdupar;
            }
           else
            {

                Entidad EntidadGasCaribe = new EntidadGasCaribe(Tipo, Fecha, NumeroRecibo, ValorPagado);
                return EntidadGasCaribe;
            }

}

        public Entidad Buscar(string numeroRecibo)
        {
           entidades.Clear();
            entidades = Consultar();

            foreach (var item in entidades)
            {
                if (item.Numerorecibo.Equals(numeroRecibo))
                {
                    return item;
                }
            }
            return null;
        }


        public int TotalizarEntidades()
        {
            return entidades.Count();
        }


        public int TotalizarElectricaribes()
        {
            return entidades.Where(l => l.Tipo == "electricaribe").Count();
        }
        public int TotalizarEmdupares()
        {
            return entidades.Where(l => l.Tipo == "emdupar").Count();
        }
        public int TotalizarGasCaribes()
        {
            return entidades.Where(l => l.Tipo == "gascaribe").Count();
        }


        public IList<Entidad> ListaElectribes()
        {
            return entidades.Where(l => l.Tipo == "electricaribe").ToList();
        }

        public IList<Entidad> ListaEmdupares()
        {
            return entidades.Where(l => l.Tipo == "emdupar").ToList();
        }
        public IList<Entidad> ListaGasCaribes()
        {
            return entidades.Where(l => l.Tipo == "gascaribe").ToList();
        }


        public decimal SumarEntidades()
        {
            return entidades.Sum(l => l.ValorPagado);

        }
        public decimal SumarElectricaribes()
        {
            return entidades.Where(l => l.Tipo == "electricaribe").Sum(l => l.ValorPagado);
        }

        public decimal SumarEmdupares()
        {
            return entidades.Where(l => l.Tipo == "emdupar").Sum(l => l.ValorPagado);
        }
        public decimal SumarGascaribes()
        {
            return entidades.Where(l => l.Tipo == "gascaribe").Sum(l => l.ValorPagado);
        }


    }
}
