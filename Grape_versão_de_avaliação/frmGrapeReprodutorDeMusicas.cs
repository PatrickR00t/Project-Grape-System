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
    public partial class frmGrapeReprodutorDeMusicas : Form
    {
        bool mouseDown;
        Point lastLocaction;

        string[] Musicas = new string[1000];
        int cont;

        public frmGrapeReprodutorDeMusicas()
        {
            InitializeComponent();
        }

        private void btnTocar_Click(object sender, EventArgs e)
        {
            Player.URL = Musicas[lbMusicas.SelectedIndex];
            timer1.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
            Player.Ctlcontrols.currentPosition = Convert.ToDouble(lblTempo.Text.Replace(":", ""));
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
            Player.Ctlcontrols.currentPosition = Convert.ToDouble(lblTempo.Text.Replace(":", ""));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lbMusicas.SelectedIndex != 0)
            {
                lbMusicas.SetSelected(lbMusicas.SelectedIndex - 1, true);
                Player.URL = Musicas[lbMusicas.SelectedIndex];
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (lbMusicas.SelectedIndex != lbMusicas.Items.Count - 1)
            {
                lbMusicas.SetSelected(lbMusicas.SelectedIndex + 1, true);
                Player.URL = Musicas[lbMusicas.SelectedIndex];
            }
        }

        private void btnPrimeira_Click(object sender, EventArgs e)
        {
            lbMusicas.SetSelected(0, true);
            Player.URL = Musicas[lbMusicas.SelectedIndex];
        }

        private void btnUltima_Click(object sender, EventArgs e)
        {
            lbMusicas.SetSelected(lbMusicas.Items.Count - 1, true);
            Player.URL = Musicas[lbMusicas.SelectedIndex];
        }

        private void btnAdicionarMusicas_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (lbMusicas.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        lbMusicas.Items.Add(open.SafeFileNames.GetValue(i));
                        Musicas[cont] = open.FileNames.GetValue(i).ToString();
                        cont += 1;
                    }
                }

                if (lbMusicas.SelectedIndex < 0) { lbMusicas.SetSelected(0, true); }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbModoAleatorio.Checked == true && lblTempo.Text != "" && Convert.ToInt32(lblTempo.Text.Replace(":", "")) == Convert.ToInt32(lblDuracao.Text.Replace(":", "")) - 2)
            {
                Random random = new Random();

                lbMusicas.SetSelected(random.Next(lbMusicas.Items.Count), true);
                Player.URL = Musicas[lbMusicas.SelectedIndex];
            }

            lblDuracao.Text = Player.currentMedia.durationString;
            lblTempo.Text = Player.Ctlcontrols.currentPositionString;
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = tbVolume.Value;
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
                lbMusicas.Size = new Size(948, 556);
                this.WindowState = FormWindowState.Maximized;
                click = 1;
            }
            else if (click == 1)
            {
                lbMusicas.Size = new Size(468, 356);
                this.WindowState = FormWindowState.Normal;
                click = 0;
            }
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
