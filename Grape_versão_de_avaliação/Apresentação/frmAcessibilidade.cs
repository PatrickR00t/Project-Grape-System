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
    public partial class frmAcessibilidade : Form
    {
        public frmAcessibilidade()
        {
            InitializeComponent();
        }

        private void lblLupa_Click(object sender, EventArgs e)
        {
            frmLupa fl = new frmLupa();
            fl.Show();
        }
    }
}
