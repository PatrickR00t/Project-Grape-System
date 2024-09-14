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
    public partial class frmMenuDeTransição : Form
    {
        public frmMenuDeTransição()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbConfigurações_Click(object sender, EventArgs e)
        {
            frmConfigurações fc = new frmConfigurações();
            fc.Show();
        }

        private void lblConfigurações_Click(object sender, EventArgs e)
        {
            frmConfigurações fc = new frmConfigurações();
            fc.Show();
        }
    }
}
