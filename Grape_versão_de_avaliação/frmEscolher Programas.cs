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
    public partial class frmEscolher_Programas : Form
    {
        public frmEscolher_Programas()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;
        private void lblPicGrape_Click(object sender, EventArgs e)
        {
            this.Close();

            frmPicGrape fpg = new frmPicGrape();
            fpg.Show();
        }

        private void frmEscolher_Programas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void frmEscolher_Programas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmEscolher_Programas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
