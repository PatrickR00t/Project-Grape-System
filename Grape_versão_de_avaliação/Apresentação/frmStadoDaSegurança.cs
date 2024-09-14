using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Grape_versão_de_avaliação
{
    public partial class frmStadoDaSegurança : Form
    {
        int virus;
        string[] virusList = new string[] { "vírus", "virus", "trojan", "cavalo de tróia", "keyloger", "hacker", "hackear", "hacked", "hack" };

        public frmStadoDaSegurança()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocaction;

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

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSelecionarArquivos_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblPasta.Text = folderBrowserDialog1.SelectedPath;
            virus = 0;
            progressBar1.Value = 0;
            listBox1.Items.Clear();
        }

        private void btnScanear_Click(object sender, EventArgs e)
        {
            List<string> search = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.*").ToList();
            progressBar1.Maximum = search.Count;

            lblVirus.Text = "Virus :" + virus.ToString();

            foreach (string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();

                    foreach (string st in virusList)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            virus += 1;
                            lblVirus.Text = "Virus :" + virus.ToString();
                            listBox1.Items.Add(item);
                        }
                        progressBar1.Increment(1);
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }

        private void frmStadoDaSegurança_Load(object sender, EventArgs e)
        {
            lblEstadoAtualDeSegurança.Parent = ptbFundoAntivirus;
            lblEstadoAtualDeSegurança.BackColor = Color.Transparent;
            lblEstadoPcProtegido.Parent = ptbFundoAntivirus;
            lblEstadoPcProtegido.BackColor = Color.Transparent;
            lblPasta.Parent = ptbFundoAntivirus;
            lblPasta.BackColor = Color.Transparent;
            lblFitaVerdeSeguro.Parent = ptbFundoAntivirus;
            lblFitaVerdeSeguro.BackColor = Color.Transparent;
            lblFitaLaranjaAlerta.Parent = ptbFundoAntivirus;
            lblFitaLaranjaAlerta.BackColor = Color.Transparent;
            lblFitaVermelhaInfectado.Parent = ptbFundoAntivirus;
            lblFitaVermelhaInfectado.BackColor = Color.Transparent;
        }

        private void ptbFundoAntivirus_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void ptbFundoAntivirus_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void ptbFundoAntivirus_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
