using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Grape_versão_de_avaliação
{
    public partial class frmDesktop : Form
    {
        public frmDesktop()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, ptbGrapeOperá.Width, ptbGrapeOperá.Height);
            ptbGrapeOperá.Region = new Region(forma);
        }

        private async void MenssagenParaAtivarAsync()
        {
            await Task.Delay(300000);

            MessageBox.Show("Ative o sistema para continuar usando", "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmDesktop_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            MenssagenParaAtivarAsync();
            
            lblGrace.Parent = ptbTrocaImagemDeFundo;
            lblGrace.BackColor = Color.Transparent;
            lblMusic.Parent = ptbTrocaImagemDeFundo;
            lblMusic.BackColor = Color.Transparent;

            ptbPonto6.Parent = ptbTrocaImagemDeFundo;
            ptbPonto6.BackColor = Color.Transparent;
            ptbPonto7.Parent = ptbTrocaImagemDeFundo;
            ptbPonto7.BackColor = Color.Transparent;
            ptbPonto8.Parent = ptbTrocaImagemDeFundo;
            ptbPonto8.BackColor = Color.Transparent;
            ptbPonto9.Parent = ptbTrocaImagemDeFundo;
            ptbPonto9.BackColor = Color.Transparent;
            ptbPonto10.Parent = ptbTrocaImagemDeFundo;
            ptbPonto10.BackColor = Color.Transparent;

            contextMenuStrip1.ForeColor = Color.White;
        }

        private void TMhora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlocoDeNotas fbn = new frmBlocoDeNotas();
            fbn.Show();
        }

        private void ptbLixeira_Click(object sender, EventArgs e)
        {
            frmLixeira fl = new frmLixeira();
            fl.Show();
        }

        private void lblLixeira_Click(object sender, EventArgs e)
        {
            frmLixeira fl = new frmLixeira();
            fl.Show();
        }

        private void tbSom_Scroll(object sender, EventArgs e)
        {
            lblValor.Text = tbSom.Value.ToString();
        }

        private void ptbSoftwareDeInteração_Click(object sender, EventArgs e)
        {
            frmGrayceInteração fgi = new frmGrayceInteração();
            fgi.Show();
        }

        private void ptbMédiaEscolar_Click(object sender, EventArgs e)
        {
            frmCalcularMédiaEscolar fcme = new frmCalcularMédiaEscolar();
            fcme.Show();
        }

        private void lblCalcularMédiaEscolar_Click(object sender, EventArgs e)
        {
            frmCalcularMédiaEscolar fcme = new frmCalcularMédiaEscolar();
            fcme.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonalizar fp = new frmPersonalizar();
            fp.Show();
        }

        private void personalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDefiniçõesDeTela fdt = new frmDefiniçõesDeTela();
            fdt.Show();
        }

        private void ptbGrapeMusic_Click(object sender, EventArgs e)
        {
            frmGrapeReprodutorDeMusicas fgrm = new frmGrapeReprodutorDeMusicas();
            fgrm.Show();
        }

        private void escolherProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscolher_Programas fp = new frmEscolher_Programas();
            fp.Show();
        }

        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalvarArquivos fsa = new frmSalvarArquivos();
            fsa.Show();
        }

        private void ptbPonto8_Click(object sender, EventArgs e)
        {
            frmMenu1 fm1 = new frmMenu1();
            fm1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmConectarWifi fcw = new frmConectarWifi();
            fcw.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbSom.Visible = true;
            lblValor.Visible = true;

            lblAjustarData_e_Hora.Visible = false;
            ptbData_e_Hora.Visible = false;
            dtp.Visible = false;
            mtbHora.Visible = false;
            btnAplicar.Visible = false;
        }

        private void ptbTrocaImagemDeFundo_Click_1(object sender, EventArgs e)
        {
            lblValor.Visible = false;
            tbSom.Visible = false;

            lblAjustarData_e_Hora.Visible = false;
            ptbData_e_Hora.Visible = false;
            dtp.Visible = false;
            mtbHora.Visible = false;
            btnAplicar.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tbSom.Visible = false;
            lblValor.Visible = false;

            lblAjustarData_e_Hora.Visible = true;
            ptbData_e_Hora.Visible = true;
            dtp.Visible = true;
            mtbHora.Visible = true;
            btnAplicar.Visible = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            TMhora.Enabled = false;

            if (dtp.Text != "")
            {
                lblData.Text = dtp.Text;
            }

            if (mtbHora.Text != "")
            {
                lblHora.Text = mtbHora.Text;
            }

            lblAjustarData_e_Hora.Visible = false;
            ptbData_e_Hora.Visible = false;
            dtp.Visible = false;
            mtbHora.Visible = false;
            btnAplicar.Visible = false;
        }

        private void ptbPonto10_Click(object sender, EventArgs e)
        {
            frmMenu2 fm2 = new frmMenu2();
            fm2.Show();
        }

        private void ptbPonto7_Click(object sender, EventArgs e)
        {
            frmMenu3 fm3 = new frmMenu3();
            fm3.Show();
        }

        private void ptbPonto9_Click(object sender, EventArgs e)
        {
            frmMenu4 fm4 = new frmMenu4();
            fm4.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            frmJanelasAbertas fja = new frmJanelasAbertas();
            fja.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmWebcam fw = new frmWebcam();
            fw.Show();
        }

        private void ptbGrapeOperá_Click(object sender, EventArgs e)
        {
            frmTSRD ftsrd = new frmTSRD();
            ftsrd.Show();
        }

        int ptb;
        private void ptbTrocarFundo_Click_1(object sender, EventArgs e)
        {
            if (ptb == 0)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._2;
                ptb = 1;
            }
            else if (ptb == 1)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._3;
                ptb = 2;
            }
            else if (ptb == 2)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._4;
                ptb = 3;
            }
            else if (ptb == 3)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._5;
                ptb = 4;
            }
            else if (ptb == 4)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._6;
                ptb = 5;
            }
            else if (ptb == 5)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._7;
                ptb = 6;
            }
            else if (ptb == 6)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._8;
                ptb = 7;
            }
            else if (ptb == 7)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._9;
                ptb = 8;
            }
            else if (ptb == 8)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._10;
                ptb = 9;
            }
            else if (ptb == 9)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._11;
                ptb = 10;
            }
            else if (ptb == 10)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._12;
                ptb = 11;
            }
            else if (ptb == 11)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._13;
                ptb = 12;
            }
            else if (ptb == 12)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._14;
                ptb = 13;
            }
            else if (ptb == 13)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._15;
                ptb = 14;
            }
            else if (ptb == 14)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._16;
                ptb = 15;
            }
            else if (ptb == 15)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._17;
                ptb = 16;
            }
            else if (ptb == 16)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._18;
                ptb = 17;
            }
            else if (ptb == 17)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._19;
                ptb = 18;
            }
            else if (ptb == 18)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._20;
                ptb = 19;
            }
            else if (ptb == 19)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._21;
                ptb = 20;
            }
            else if (ptb == 20)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._22;
                ptb = 21;
            }
            else if (ptb == 21)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._23;
                ptb = 22;
            }
            else if (ptb == 22)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._24;
                ptb = 23;
            }
            else if (ptb == 23)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._25;
                ptb = 24;
            }
            else if (ptb == 24)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._26;
                ptb = 25;
            }
            else if (ptb == 25)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._27;
                ptb = 26;
            }
            else if (ptb == 26)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._28;
                ptb = 27;
            }
            else if (ptb == 27)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._29;
                ptb = 28;
            }
            else if (ptb == 28)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._30;
                ptb = 29;
            }
            else if (ptb == 29)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._31;
                ptb = 30;
            }
            else if (ptb == 30)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._32;
                ptb = 31;
            }
            else if (ptb == 31)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._33;
                ptb = 32;
            }
            else if (ptb == 32)
            {
                ptbTrocaImagemDeFundo.Image = Properties.Resources._34;
                ptb = 0;
            }
        }

        private void AnotarTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarefasDoDia ftd = new frmTarefasDoDia();
            ftd.Show();
        }

        private void CriarPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            label1.Visible = true;
            txbNomeDaPasta.Visible = true;
            btnAplicarNomeCriarPasta.Visible = true;
        }

        int click;
        private void btnAplicarNomeCriarPasta_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                if (txbNomeDaPasta.Text != "")
                {
                    PictureBox pBox = new PictureBox();
                    pBox.Location = new Point(75, 22);
                    pBox.Name = "Pasta1";
                    pBox.Height = 48;
                    pBox.Width = 48;
                    pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pBox.Parent = ptbTrocaImagemDeFundo;
                    pBox.BackColor = Color.Transparent;
                    ptbTrocaImagemDeFundo.Controls.Add(pBox);
                    pBox.Image = Image.FromFile(@"C:\Greype\Sis\Img\pst.png");

                    Label lbl = new System.Windows.Forms.Label();
                    lbl.Location = new Point(78, 72);
                    lbl.ForeColor = Color.White;
                    lbl.Name = "Pasta1";
                    lbl.Text = txbNomeDaPasta.Text;
                    lbl.Parent = ptbTrocaImagemDeFundo;
                    lbl.BackColor = Color.Transparent;
                    ptbTrocaImagemDeFundo.Controls.Add(lbl);

                    pictureBox7.Visible = false;
                    label1.Visible = false;
                    txbNomeDaPasta.Visible = false;
                    btnAplicarNomeCriarPasta.Visible = false;
                    txbNomeDaPasta.Clear();
                }
                click = 1;
            }
            else if (click == 1)
            {
                if (txbNomeDaPasta.Text != "")
                {
                    PictureBox pBox2 = new PictureBox();
                    pBox2.Location = new Point(75, 102);
                    pBox2.Name = "Pasta1";
                    pBox2.Height = 48;
                    pBox2.Width = 48;
                    pBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pBox2.Parent = ptbTrocaImagemDeFundo;
                    pBox2.BackColor = Color.Transparent;
                    ptbTrocaImagemDeFundo.Controls.Add(pBox2);
                    pBox2.Image = Image.FromFile(@"C:\Greype\Sis\Img\pst.png");
                    
                    Label lbl = new System.Windows.Forms.Label();
                    lbl.Location = new Point(78, 152);
                    lbl.ForeColor = Color.White;
                    lbl.Name = "Pasta1";
                    lbl.Text = txbNomeDaPasta.Text;
                    lbl.Parent = ptbTrocaImagemDeFundo;
                    lbl.BackColor = Color.Transparent;
                    ptbTrocaImagemDeFundo.Controls.Add(lbl);
                    

                    pictureBox7.Visible = false;
                    label1.Visible = false;
                    txbNomeDaPasta.Visible = false;
                    btnAplicarNomeCriarPasta.Visible = false;
                }
            }
        }
    }
}