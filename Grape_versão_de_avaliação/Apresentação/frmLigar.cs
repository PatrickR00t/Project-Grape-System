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
    public partial class frmLigar : Form
    {
        public frmLigar()
        {
            InitializeComponent();
        }

        private async void frmLigar_LoadAsync(object sender, EventArgs e)
        {
            await Task.Delay(3000);

            frmAutenticar fa = new frmAutenticar();
            fa.Show();
        }
    }
}
