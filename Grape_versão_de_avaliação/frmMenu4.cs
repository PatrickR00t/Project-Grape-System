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
    public partial class frmMenu4 : Form
    {
        public frmMenu4()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            panel1.BackColor = Color.GhostWhite;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            panel1.BackColor = Color.Black;
        }

        private void frmMenu4_Load(object sender, EventArgs e)
        {
            ptbPonto6.Parent = panel1;
            ptbPonto6.BackColor = Color.Transparent;
            ptbPonto7.Parent = panel1;
            ptbPonto7.BackColor = Color.Transparent;
            ptbPonto8.Parent = panel1;
            ptbPonto8.BackColor = Color.Transparent;
            ptbPonto9.Parent = panel1;
            ptbPonto9.BackColor = Color.Transparent;
            ptbPonto10.Parent = panel1;
            ptbPonto10.BackColor = Color.Transparent;

            CentralDeComandos.Parent = pictureBox1;
            CentralDeComandos.BackColor = Color.Transparent;
            lblConfiguracoes.Parent = pictureBox1;
            lblConfiguracoes.BackColor = Color.Transparent;
            lblAcessibilidade.Parent = pictureBox1;
            lblAcessibilidade.BackColor = Color.Transparent;
            lblInformaçõesSistema.Parent = pictureBox1;
            lblInformaçõesSistema.BackColor = Color.Transparent;
            lblAntivirus.Parent = pictureBox1;
            lblAntivirus.BackColor = Color.Transparent;
            lblAjuda.Parent = pictureBox1;
            lblAjuda.BackColor = Color.Transparent;
        }

        private void ptbPonto7_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmMenu3 fm3 = new frmMenu3();
            fm3.Show();
        }

        private void ptbPonto6_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

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

        private void ptbPonto8_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmMenu1 fm1 = new frmMenu1();
            fm1.Show();
        }

        private void ptbPonto10_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmMenu2 fm2 = new frmMenu2();
            fm2.Show();
        }

        private void ptbMarcaSistema_Click(object sender, EventArgs e)
        {
            frmInformaçõesDoSistema fis = new frmInformaçõesDoSistema();
            fis.Show();
        }

        private void lblInformaçõesSistema_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmInformaçõesDoSistema fis = new frmInformaçõesDoSistema();
            fis.Show();
        }

        private void lblComprarLicença_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmComprarLicença fcl = new frmComprarLicença();
            fcl.Show();
        }

        private void lblConfiguracoes_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmConfigurações fc = new frmConfigurações();
            fc.Show();
        }

        private void lblAntivirus_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmStadoDaSegurança fss = new frmStadoDaSegurança();
            fss.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmCentralDeComandos fcc = new frmCentralDeComandos();
            fcc.Show();
        }

        /*
        private void lblDefiniçõesDeTela_Click(object sender, EventArgs e)
        {
            frmMenu4.ActiveForm.Close();

            frmDefiniçõesDeTela fdt = new frmDefiniçõesDeTela();
            fdt.Show();
        }
        */
    }
}
