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
    public partial class frmMenu2 : Form
    {
        public frmMenu2()
        {
            InitializeComponent();
        }

        private void frmMenu2_Load(object sender, EventArgs e)
        {
            ptbPonto6.Parent = panel1;
            ptbPonto6.BackColor = Color.Transparent;
            ptbPonto7.Parent = panel1;
            ptbPonto7.BackColor = Color.Transparent;
            ptbPonto8.Parent = panel1;
            ptbPonto8.BackColor = Color.Transparent;
            ptbPonto9.Parent = panel1;
            ptbPonto9.BackColor = Color.Transparent;
            lblNoticias.Parent = pictureBox1;

            lblNoticias.BackColor = Color.Transparent;
            lblTempo.Parent = pictureBox1;
            lblTempo.BackColor = Color.Transparent;
            lblDiversos.Parent = pictureBox1;
            lblDiversos.BackColor = Color.Transparent;
            lblEsportes.Parent = pictureBox1;
            lblEsportes.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            panel1.BackColor = Color.GhostWhite;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            panel1.BackColor = Color.Black;
        }

        private void ptbPonto8_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmMenu1 fm1 = new frmMenu1();
            fm1.Show();
        }

        private void ptbPonto7_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmMenu3 fm3 = new frmMenu3();
            fm3.Show();
        }

        private void ptbPonto6_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmDesktop fd = new frmDesktop();
            fd.Show();

            frmDesktop fecharForm = new frmDesktop();
            if (Application.OpenForms.OfType<frmDesktop>().Count() > 0)
            {
                fecharForm = null;
                foreach (var item in Application.OpenForms)
                {
                    if (item.ToString().Contains("frmDesktop"))
                    {
                        fecharForm = ((frmDesktop)item);
                    }
                }
                if (fecharForm != null)
                {
                    fecharForm.Close();
                }
            }
        }

        private void ptbPonto9_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmMenu4 fm4 = new frmMenu4();
            fm4.Show();
        }
    }
}
