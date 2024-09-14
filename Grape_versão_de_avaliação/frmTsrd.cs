using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grape_versão_de_avaliação
{
    public partial class frmTSRD : Form
    {
        public frmTSRD()
        {
            InitializeComponent();
        }

        private void lblTrocarDeUsuario_Click(object sender, EventArgs e)
        {
            frmAutenticar fa = new frmAutenticar();
            fa.Show();
        }

        private void lblReiniciar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 0");

            frmReiniciar fr = new frmReiniciar();
            fr.Show();
        }

        private void lblDesligar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");

            frmDesligar fd = new frmDesligar();
            fd.Show();
        }
    }
}