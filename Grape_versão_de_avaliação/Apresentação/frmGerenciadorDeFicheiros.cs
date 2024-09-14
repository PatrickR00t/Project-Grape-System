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

namespace Grape_versão_de_avaliação
{
    public partial class frmGerenciadorDeFicheiros : Form
    {
        bool mouseDown;
        Point lastLocaction;

        public frmGerenciadorDeFicheiros()
        {
            InitializeComponent();
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

        private void Discos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pastas.Items.Clear();

            try
            {
                DriveInfo drive = (DriveInfo)Discos.SelectedItem;

                foreach (DirectoryInfo dirInfo in drive.RootDirectory.GetDirectories())
                    Pastas.Items.Add(dirInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arquivos.Items.Clear();

            DirectoryInfo dir = (DirectoryInfo)Pastas.SelectedItem;
            foreach (FileInfo fi in dir.GetFiles())
                Arquivos.Items.Add(fi);
        }

        private void frmGerenciadorDeFicheiros_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo di in DriveInfo.GetDrives())
                Discos.Items.Add(di);
        }
        private void frmGerenciadorDeFicheiros_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }
        private void frmGerenciadorDeFicheiros_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmGerenciadorDeFicheiros_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Pastas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pastas.Visible = false;
        }

        private void ptbAnterior_Click(object sender, EventArgs e)
        {
            Pastas.Visible = true;
        }

        private void ptbAvançar_Click(object sender, EventArgs e)
        {
            Pastas.Visible = false;
        }
    }
}
