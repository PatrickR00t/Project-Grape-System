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
    public partial class frmComprarLicença : Form
    {
        public frmComprarLicença()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;
        private void frmComprarLicença_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void frmComprarLicença_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmComprarLicença_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int click;
        private void ptbMaximizar_Click(object sender, EventArgs e)
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

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (txbChaveDeAtivação.Text == "12345")
            {
                MessageBox.Show("O sistema grape foi ativado com sucesso !", "Ativação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A chave de ativação digitada é invalida", "Chave desconhecida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
