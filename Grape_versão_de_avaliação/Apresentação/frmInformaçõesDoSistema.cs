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
    public partial class frmInformaçõesDoSistema : Form
    {
        public frmInformaçõesDoSistema()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;
        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInformaçõesDoSistema_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void frmInformaçõesDoSistema_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmInformaçõesDoSistema_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        int click;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                click = 1;
            }
            else if (click == 1)
            {
                this.WindowState = FormWindowState.Normal;
                click = 0;
            }
        }
    }
}
