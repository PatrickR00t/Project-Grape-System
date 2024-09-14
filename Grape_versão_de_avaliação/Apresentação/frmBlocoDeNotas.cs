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
    public partial class frmBlocoDeNotas : Form
    {
        private bool isSaved = false;

        public frmBlocoDeNotas()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocaction;

        private void NewFile(bool saveFile)
        {
            if (saveFile == true)
            {
                SaveFile();
            }
            this.richTextBox1.Clear();
            this.Text = "Sem título";
            isSaved = false;
        }

        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK && richTextBox1.Text != "")
            {
                File.WriteAllText(sfd.FileName, this.richTextBox1.Text);
                this.Text = sfd.FileName;
            }
            isSaved = true;
        }

        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK && string.IsNullOrEmpty(this.richTextBox1.Text))
            {
                this.richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
            isSaved = false;
            this.Text = ofd.FileName;
        }

        private void frmBlocoDeNotas_Load(object sender, EventArgs e)
        {
            this.Text = "Bloco de notas";
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
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void novoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Deseja salvar o arquivo?", "Sair do programa", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    NewFile(true);
                }
                else if (result == DialogResult.No)
                {
                    NewFile(false);
                }
            }
        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
                this.richTextBox1.Font = fd.Font;
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
