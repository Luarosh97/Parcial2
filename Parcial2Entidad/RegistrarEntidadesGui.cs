using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace Parcial2Entidad
{
    public partial class RegistrarEntidadesGui : Form
    {
        EntidadService entidadService = new EntidadService();
        public RegistrarEntidadesGui()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Entidad entidad= MapearEntidad();
            string mensaje = entidadService.Guardar(entidad);
            MessageBox.Show(mensaje);
        }

       public  Entidad MapearEntidad()
        {
            Entidad Entidad;

            if (TipoCombo.SelectedIndex == 0)
            {
               Entidad = new EntidadElectricaribe();


            }
            if (TipoCombo.SelectedIndex == 1)
            {
                Entidad = new EntidadEmdupar();
            }
            else {

                Entidad = new EntidadGasCaribe();
                    
                    }
            Entidad.Tipo = TipoCombo.Text;
            Entidad.Fecha = DtFecha.Value.Date;
            Entidad.Numerorecibo= NumeroRegistrotxt.Text;
            Entidad.ValorPagado = decimal.Parse(valorPagadotxt.Text);
           
            return Entidad;
        }
    }
}
