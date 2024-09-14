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
    public partial class frmBemVindo : Form
    {
        public frmBemVindo()
        {
            InitializeComponent();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            frmTermosDeUltilização ftu = new frmTermosDeUltilização();
            ftu.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblBemVindo.Visible = true;
            btnInstalar.Visible = true;
            btnReparar.Visible = true;
            btnSair.Visible = true;
        }
    }
}
