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
    public partial class frmBemVindoInicializar : Form
    {
        public frmBemVindoInicializar()
        {
            InitializeComponent();
        }

        private async void frmBemVindoInicializar_LoadAsync(object sender, EventArgs e)
        {
            await Task.Delay(3000);

            frmDesktop fd = new frmDesktop();
            fd.Show();

            this.Close();
        }
    }
}
