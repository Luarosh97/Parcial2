using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Parcial2Entidad
{
    public partial class ConsultarEntidadesGUI : Form
    {
       EntidadService entidadService =  new EntidadService();
        ResponseConsulta respuestaConsulta = new ResponseConsulta();
        string entidades;
        string TotalEntidades;
        string TotalElectricaribes;
        string Electricaribes;
        string TotalEmdupares;
        string Emdupares;
        string TotalGacaribes;
        string Gascaribes;

        public ConsultarEntidadesGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            respuestaConsulta = entidadService.Consultar();
            entidades = entidadService.TotalizarEntidades().ToString();
            Electricaribes = entidadService.TotalizarElectricaribes().ToString();
            Emdupares= entidadService.TotalizarEmdupares().ToString();
            Gascaribes = entidadService.TotalizarGasCaribes().ToString();
            TotalEntidades = entidadService.SumarEntidades().ToString();

            Consultar();

        }

        public void Consultar()
        {
            if (TipoConsultacmb.SelectedIndex==0)
            {
                respuestaConsulta = entidadService.Consultar();
                dataGridView1.DataSource = respuestaConsulta.entidades;
                TotalEntidades = entidadService.SumarEntidades().ToString();
                TotalElectricaribes = "0";
                TotalGacaribes = "0";
                TotalEmdupares = "0";

            }

            else if (TipoConsultacmb.SelectedIndex==1)
            {
                dataGridView1.DataSource = entidadService.ListaElectribes();
                entidades = Electricaribes;
                Emdupares = "0";
                Gascaribes = "0";
                TotalEmdupares = "0";
               TotalEntidades = "0";
                TotalGacaribes = "0";
                TotalElectricaribes = entidadService.SumarElectricaribes().ToString();
               
            }

            else if (TipoConsultacmb.SelectedIndex==2)
            {
                dataGridView1.DataSource = entidadService.ListaEmdupares();
                entidades = Emdupares;
                Electricaribes = "0";
                Gascaribes = "0";
                TotalEntidades = "0";
                TotalGacaribes = "0";
                TotalElectricaribes = "0";
                TotalEmdupares = entidadService.SumarEmdupares().ToString();

            }

            else if (TipoConsultacmb.SelectedIndex==3) {

                dataGridView1.DataSource = entidadService.ListaGasCaribes();
                entidades =Gascaribes;
                Electricaribes = "0";
                Emdupares= "0";
                TotalEntidades = "0";
                TotalGacaribes = entidadService.SumarGascaribes().ToString();
                TotalElectricaribes = "0";
                TotalEmdupares = "0";
            }

            LlenarCampos();

        }

        private void LlenarCampos()
        {
       entidadestxt.Text=entidades;
         electricaribetxt.Text = Electricaribes;
         gascaribestxt.Text = Gascaribes ;
          emduparestxt.Text = Emdupares ;
           totalentidadestxt.Text = TotalEntidades ;
           totalelectricaribestxt.Text= TotalElectricaribes ;
           totalemduparestxt.Text= TotalEmdupares ;
          totalgascaribestxt.Text = TotalGacaribes;
        }
    }
}
