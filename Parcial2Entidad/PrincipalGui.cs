using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Entidad
{
    public partial class PrincipalGui : Form
    {
        public PrincipalGui()
        {
            InitializeComponent();
        }

        private void registrarEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEntidadesGui registrarEntidadesGUI = new RegistrarEntidadesGui();
            registrarEntidadesGUI.Show();
        }

        private void consultarEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEntidadesGUI consultarEntidadesGUI = new ConsultarEntidadesGUI();
            consultarEntidadesGUI.Show();
        }
    }
}
