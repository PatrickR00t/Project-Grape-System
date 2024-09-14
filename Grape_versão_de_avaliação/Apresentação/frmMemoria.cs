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
    public partial class frmMemoria : Form
    {
        public frmMemoria()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmDadosDoUsuario fdu = new frmDadosDoUsuario();
            fdu.Show();

            this.Close();
        }
    }
}
