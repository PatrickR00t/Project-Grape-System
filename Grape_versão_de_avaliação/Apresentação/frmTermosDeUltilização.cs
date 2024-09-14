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
    public partial class frmTermosDeUltilização : Form
    {
        public frmTermosDeUltilização()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmMemoria fm = new frmMemoria();
            fm.Show();

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmBemVindo fb = new frmBemVindo();
            fb.Show();

            this.Close();
        }
    }
}
