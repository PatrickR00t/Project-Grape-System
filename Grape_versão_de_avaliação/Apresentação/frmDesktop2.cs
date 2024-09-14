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
    public partial class frmDesktop2 : Form
    {
        public frmDesktop2()
        {
            InitializeComponent();
        }

        private void ptbMostrarMenuSuperior_Click(object sender, EventArgs e)
        {
            ptbFecharMenuSuperior.Visible = true;

            TMMostrarMenuSuperior.Start();
        }
        int Tamanho = 37;
        private void ptbFecharMenuSuperior_Click(object sender, EventArgs e)
        {
            ptbFecharMenuSuperior.Visible = false;

            TMEsconderMenuSuperior.Start();
        }

        private void TMEsconderMenuSuperior_Tick(object sender, EventArgs e)
        {
            if (Tamanho > 16)
            {
                this.pnMenu.Size = new Size(this.pnMenu.Size.Width, Tamanho);
                Tamanho -= 20;
            }
            else
            {
                TMEsconderMenuSuperior.Stop();
            }
        }

        private void TMMostrarMenuSuperior_Tick(object sender, EventArgs e)
        {

            if (Tamanho > 170)
            {
                TMMostrarMenuSuperior.Stop();
            }
            else
            {
                this.pnMenu.Size = new Size(this.pnMenu.Size.Width, Tamanho);
                Tamanho += 20;
            }
        }

        private void frmDesktop2_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            lblTrocarFundo2.Parent = ptbTrocarFundo2;
            lblTrocarFundo2.BackColor = Color.Transparent;
            lblModoDesktop.Parent = ptbTrocarFundo2;
            lblModoDesktop.BackColor = Color.Transparent;
            lblHora.Parent = pnMenu;
            lblHora.BackColor = Color.Transparent;
            lblData.Parent = pnMenu;
            lblData.BackColor = Color.Transparent;
            lblGrace.Parent = pnMenu;
            lblGrace.BackColor = Color.Transparent;
        }

        private void TMHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmDesktop fd = new frmDesktop();
            fd.Show();
        }

        private void ptbMenuDeTransição_Click(object sender, EventArgs e)
        {
            frmMenuDeTransição fmt = new frmMenuDeTransição();
            fmt.Show();
        }

        private void lblConfigurações_Click(object sender, EventArgs e)
        {
            frmConfigurações fc = new frmConfigurações();
            fc.Show();
        }

        private void ptbConfigurações_Click(object sender, EventArgs e)
        {
            frmConfigurações fc = new frmConfigurações();
            fc.Show();
        }

        int ptb;

        private void lblTrocarFundo2_Click(object sender, EventArgs e)
        {
            if (ptb == 0)
            {
                ptbTrocarFundo2.Image = Properties.Resources._2;
                ptb = 1;
            }
            else if (ptb == 1)
            {
                ptbTrocarFundo2.Image = Properties.Resources._3;
                ptb = 2;
            }
            else if (ptb == 2)
            {
                ptbTrocarFundo2.Image = Properties.Resources._4;
                ptb = 3;
            }
            else if (ptb == 3)
            {
                ptbTrocarFundo2.Image = Properties.Resources._5;
                ptb = 4;
            }
            else if (ptb == 4)
            {
                ptbTrocarFundo2.Image = Properties.Resources._6;
                ptb = 5;
            }
            else if (ptb == 5)
            {
                ptbTrocarFundo2.Image = Properties.Resources._7;
                ptb = 6;
            }
            else if (ptb == 6)
            {
                ptbTrocarFundo2.Image = Properties.Resources._8;
                ptb = 7;
            }
            else if (ptb == 7)
            {
                ptbTrocarFundo2.Image = Properties.Resources._9;
                ptb = 8;
            }
            else if (ptb == 8)
            {
                ptbTrocarFundo2.Image = Properties.Resources._10;
                ptb = 9;
            }
            else if (ptb == 9)
            {
                ptbTrocarFundo2.Image = Properties.Resources._11;
                ptb = 10;
            }
            else if (ptb == 10)
            {
                ptbTrocarFundo2.Image = Properties.Resources._12;
                ptb = 11;
            }
            else if (ptb == 11)
            {
                ptbTrocarFundo2.Image = Properties.Resources._13;
                ptb = 12;
            }
            else if (ptb == 12)
            {
                ptbTrocarFundo2.Image = Properties.Resources._14;
                ptb = 13;
            }
            else if (ptb == 13)
            {
                ptbTrocarFundo2.Image = Properties.Resources._15;
                ptb = 14;
            }
            else if (ptb == 14)
            {
                ptbTrocarFundo2.Image = Properties.Resources._16;
                ptb = 15;
            }
            else if (ptb == 15)
            {
                ptbTrocarFundo2.Image = Properties.Resources._17;
                ptb = 16;
            }
            else if (ptb == 16)
            {
                ptbTrocarFundo2.Image = Properties.Resources._18;
                ptb = 17;
            }
            else if (ptb == 17)
            {
                ptbTrocarFundo2.Image = Properties.Resources._19;
                ptb = 18;
            }
            else if (ptb == 18)
            {
                ptbTrocarFundo2.Image = Properties.Resources._20;
                ptb = 19;
            }
            else if (ptb == 19)
            {
                ptbTrocarFundo2.Image = Properties.Resources._21;
                ptb = 20;
            }
            else if (ptb == 20)
            {
                ptbTrocarFundo2.Image = Properties.Resources._22;
                ptb = 21;
            }
            else if (ptb == 21)
            {
                ptbTrocarFundo2.Image = Properties.Resources._23;
                ptb = 22;
            }
            else if (ptb == 22)
            {
                ptbTrocarFundo2.Image = Properties.Resources._24;
                ptb = 23;
            }
            else if (ptb == 23)
            {
                ptbTrocarFundo2.Image = Properties.Resources._25;
                ptb = 24;
            }
            else if (ptb == 24)
            {
                ptbTrocarFundo2.Image = Properties.Resources._26;
                ptb = 25;
            }
            else if (ptb == 25)
            {
                ptbTrocarFundo2.Image = Properties.Resources._27;
            }
        }

        private void ptbSoftwareDeInteração_Click(object sender, EventArgs e)
        {
            frmGrayceInteração fgi = new frmGrayceInteração();
            fgi.Show();
        }

        private void lblGrace_Click(object sender, EventArgs e)
        {
            frmGrayceInteração fgi = new frmGrayceInteração();
            fgi.Show();
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
