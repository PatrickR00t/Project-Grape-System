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
    public partial class frmMenu1 : Form
    {
        public frmMenu1()
        {
            InitializeComponent();
        }

        private void frmMenu1_Load(object sender, EventArgs e)
        {
            ptbPonto6.Parent = panel1;
            ptbPonto6.BackColor = Color.Transparent;
            ptbPonto7.Parent = panel1;
            ptbPonto7.BackColor = Color.Transparent;
            ptbPonto9.Parent = panel1;
            ptbPonto9.BackColor = Color.Transparent;
            ptbPonto10.Parent = panel1;
            ptbPonto10.BackColor = Color.Transparent;

            lblExploradorDeFicheiros.Parent = pictureBox1;
            lblExploradorDeFicheiros.BackColor = Color.Transparent;
            lblModoFone.Parent = pictureBox1;
            lblModoFone.BackColor = Color.Transparent;
            lblNavegador.Parent = pictureBox1;
            lblNavegador.BackColor = Color.Transparent;
            lblReprodutorVideo.Parent = pictureBox1;
            lblReprodutorVideo.BackColor = Color.Transparent;
            lblFotos.Parent = pictureBox1;
            lblFotos.BackColor = Color.Transparent;
            lblGraci.Parent = pictureBox1;
            lblGraci.BackColor = Color.Transparent;
            lblDespertador.Parent = pictureBox1;
            lblDespertador.BackColor = Color.Transparent;
            lblGrapeNote.Parent = pictureBox1;
            lblGrapeNote.BackColor = Color.Transparent;
            lblCalculadora.Parent = pictureBox1;
            lblCalculadora.BackColor = Color.Transparent;
            lblProtegerArquivos.Parent = pictureBox1;
            lblProtegerArquivos.BackColor = Color.Transparent;
            lblBluetooth.Parent = pictureBox1;
            lblBluetooth.BackColor = Color.Transparent;
            lblWebcam.Parent = pictureBox1;
            lblWebcam.BackColor = Color.Transparent;
            lblDesenhar.Parent = pictureBox1;
            lblDesenhar.BackColor = Color.Transparent;
            lblCalcularNota.Parent = pictureBox1;
            lblCalcularNota.BackColor = Color.Transparent;
            lblJanelasAbertas.Parent = pictureBox1;
            lblJanelasAbertas.BackColor = Color.Transparent;
            lblGrapyMusicas.Parent = pictureBox1;
            lblGrapyMusicas.BackColor = Color.Transparent;
            lblGrapyShadow.Parent = pictureBox1;
            lblGrapyShadow.BackColor = Color.Transparent;
            lblNotificacoes.Parent = pictureBox1;
            lblNotificacoes.BackColor = Color.Transparent;
            lblWifi.Parent = pictureBox1;
            lblWifi.BackColor = Color.Transparent;
            lblRastrear.Parent = pictureBox1;
            lblRastrear.BackColor = Color.Transparent;
            lblMeuIp.Parent = pictureBox1;
            lblMeuIp.BackColor = Color.Transparent;
            lblWorks.Parent = pictureBox1;
            lblWorks.BackColor = Color.Transparent;
            lblMail.Parent = pictureBox1;
            lblMail.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel1.BackColor = Color.GhostWhite;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            panel1.BackColor = Color.Black;
        }

        private void ptbPonto6_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

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

        private void ptbPicGrape_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmPicGrape fpg = new frmPicGrape();
            fpg.Show();
        }

        private void ptbPonto10_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmMenu2 fm2 = new frmMenu2();
            fm2.Show();
        }

        private void ptbPonto7_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmMenu3 fm3 = new frmMenu3();
            fm3.Show();
        }

        private void ptbPonto9_Click(object sender, EventArgs e)
        {
            frmMenu2.ActiveForm.Close();

            frmMenu4 fm4 = new frmMenu4();
            fm4.Show();
        }

        private void ptbSoftwareDeInteração_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmGrayceInteração fgi = new frmGrayceInteração();
            fgi.Show();
        }

        private void ptbExploradorDeArquivos_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            System.Diagnostics.Process.Start(@"C:\Greype\Sis\FileFolderList\bin\Debug\FileFolderList.exe");
            /*
            frmGerenciadorDeFicheiros fgf = new frmGerenciadorDeFicheiros();
            fgf.Show();
            */
        }

        private void ptbWebcam_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmWebcam fw = new frmWebcam();
            fw.Show();
        }

        private void ptbDespertador_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmDespertador fd = new frmDespertador();
            fd.Show();
        }

        private void ptbGrapyNote_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmBlocoDeNotas fbn = new frmBlocoDeNotas();
            fbn.Show();
        }

        private void ptbCalculadora_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmCalculadora fc = new frmCalculadora();
            fc.Show();
        }

        private void ptbMusicas_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmGrapeReprodutorDeMusicas fgrm = new frmGrapeReprodutorDeMusicas();
            fgrm.Show();
        }

        private void ptbModoFone_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmDesktop2 fd2 = new frmDesktop2();
            fd2.Show();
        }

        private void ptbNavegador_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmNavegador fn = new frmNavegador();
            fn.Show();
        }

        private void ptbWifi_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmConectarWifi fcw = new frmConectarWifi();
            fcw.Show();
        }

        private void ptbCalcularNotas_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmCalcularMédiaEscolar fcme = new frmCalcularMédiaEscolar();
            fcme.Show();
        }

        private void ptbMovie_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmGrapyVideo fgv = new frmGrapyVideo();
            fgv.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmGrapyDesenhar fgd = new frmGrapyDesenhar();
            fgd.Show();
        }

        private void ptbJanelasAbertas_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmJanelasAbertas fja = new frmJanelasAbertas();
            fja.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmMeuIp fm = new frmMeuIp();
            fm.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmBloquearPasta fbp = new frmBloquearPasta();
            fbp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmGeoLocalizacao fgl = new frmGeoLocalizacao();
            fgl.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmTarefasDoDia ftd = new frmTarefasDoDia();
            ftd.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmMenu1.ActiveForm.Close();

            frmEnviar_email fee = new frmEnviar_email();
            fee.Show();
        }
    }
}
