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
    public partial class frmDespertador : Form
    {
        bool mouseDown;
        Point lastLocaction;

        string musica;
        public frmDespertador()
        {
            InitializeComponent();
        }

        private void btnAtivarAlarme_Click(object sender, EventArgs e)
        {
            lblHoraDespertar.Text = mtbHora.Text;
            mtbHora.Text = "";
            T_HoraDespertar.Start();
        }

        private void btnPararAlarme_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.stop();
            T_HoraDespertar.Stop();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                musica = open.FileName;
                txbMusica.Text = open.SafeFileName;
            }
        }

        private void T_HoraAtual_Tick(object sender, EventArgs e)
        {
            lblMarcadorDeHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void T_HoraDespertar_Tick(object sender, EventArgs e)
        {
            if (lblMarcadorDeHora.Text == lblHoraDespertar.Text)
            {
                wmp.URL = musica;
            }
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

        private void frmDespertador_Load(object sender, EventArgs e)
        {
            lblHora.Parent = pictureBox1;
            lblHora.BackColor = Color.Transparent;
            lblMarcadorDeHora.Parent = pictureBox1;
            lblMarcadorDeHora.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            lblHoraDespertar.Parent = pictureBox1;
            lblHoraDespertar.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
