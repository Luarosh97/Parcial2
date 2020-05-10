using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class EntidadService
    {

        private EntidadRepository entidadRepositorio;

        public EntidadService()
        {
            entidadRepositorio = new EntidadRepository();
        }
        public string Guardar(Entidad entidad)
        {
            try
            {
                if (entidadRepositorio.Buscar(entidad.Numerorecibo) == null)
                {
                   entidadRepositorio.Guardar(entidad);
                    return $"Los datos de la Entidad con numero {entidad.Numerorecibo} han sido guardados correctamente";
                }
                return $"No es posible registrar la Entidad con numero {entidad.Numerorecibo}, porque ya se encuentra registrada";
            }
            catch (Exception E)
            {
                return "Error de lectura " + E.Message;
            }
        }

        public ResponseConsulta Consultar()
        {
            ResponseConsulta respuesta = new ResponseConsulta();
            try
            {
                respuesta.Error = false;
                IList<Entidad> entidades = entidadRepositorio.Consultar();
                if (entidades.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de liquidaciones";
                    respuesta.entidades= entidades;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.entidades= null;
                }

            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.entidades = null;
            }
            return respuesta;

        }

        public RespuestaBusqueda Buscar(string numeroRecibo)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
              Entidad Entidad = entidadRepositorio.Buscar(numeroRecibo);
                if (Entidad == null)
                {
                    respuesta.Mensaje = $"La Liquidaacion con  numero {numeroRecibo} no se encuentra registrada";
                    respuesta.entidad= null;
                }
                else
                {
                    respuesta.entidad= Entidad;
                    respuesta.Mensaje = "liquidacion encontrada\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.entidad = null;
                respuesta.Error = true;
            }
            return respuesta;
        }

        public int TotalizarEntidades()
        {
            return entidadRepositorio.TotalizarEntidades();
        }


        public int TotalizarElectricaribes()
        {
            return entidadRepositorio.TotalizarElectricaribes();
        }
        public int TotalizarEmdupares()
        {
            return entidadRepositorio.TotalizarEmdupares();
        }
        public int TotalizarGasCaribes()
        {
            return entidadRepositorio.TotalizarGasCaribes();
        }


        public IList<Entidad> ListaElectribes()
        {
            return entidadRepositorio.ListaElectribes();
        }

        public IList<Entidad> ListaEmdupares()
        {
            return entidadRepositorio.ListaEmdupares();
        }
        public IList<Entidad> ListaGasCaribes()
        {
            return entidadRepositorio.ListaGasCaribes();
        }


        public decimal SumarEntidades()
        {
            return entidadRepositorio.SumarEntidades();

        }
        public decimal SumarElectricaribes()
        {
            return entidadRepositorio.SumarElectricaribes();
        }

        public decimal SumarEmdupares()
        {
            return entidadRepositorio.SumarEmdupares();
        }
        public decimal SumarGascaribes()
        {
            return entidadRepositorio.SumarGascaribes();
        }

    }


}
