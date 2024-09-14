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
    public partial class frmCalcularMédiaEscolar : Form
    {
        public frmCalcularMédiaEscolar()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txbAluno.Text == "")
            {
                MessageBox.Show("O campo aluno não foi vazio", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Matéria", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lblBimestre1.Text == "")
            {
                MessageBox.Show("Digite o valor do primeiro bimestre", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lblBimestre2.Text == "")
            {
                MessageBox.Show("Digite o valor do segundo bimestre", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lblBimestre3.Text == "")
            {
                MessageBox.Show("Digite o valor do terceiro bimestre", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal b1, b2, b3, b4, media;
            b1 = Convert.ToDecimal(txbBimestre1.Text);
            b2 = Convert.ToDecimal(txbBimestre2.Text);
            b3 = Convert.ToDecimal(txbBimestre3.Text);
            b4 = Convert.ToDecimal(txbBimestre4.Text);

            media = (b1 + b2 + b3 + b4) / 4;

            txbMédia.Text = Convert.ToString(media);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbAluno.Text = string.Empty;
            cbMateria.SelectedIndex = -1;
            txbBimestre1.Text = string.Empty;
            txbBimestre2.Text = string.Empty;
            txbBimestre3.Text = string.Empty;
            txbBimestre4.Text = string.Empty;
            txbMédia.Text = string.Empty;
            txbAluno.Focus();
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalcularMédiaEscolar_Load(object sender, EventArgs e)
        {
            lblAluno.Parent = pictureBox1;
            lblAluno.BackColor = Color.Transparent;
            lblMatéria.Parent = pictureBox1;
            lblMatéria.BackColor = Color.Transparent;
            lblBimestre1.Parent = pictureBox1;
            lblBimestre1.BackColor = Color.Transparent;
            lblBimestre2.Parent = pictureBox1;
            lblBimestre2.BackColor = Color.Transparent;
            lblBimestre3.Parent = pictureBox1;
            lblBimestre3.BackColor = Color.Transparent;
            lblBimestre4.Parent = pictureBox1;
            lblBimestre4.BackColor = Color.Transparent;
            lblMédia.Parent = pictureBox1;
            lblMédia.BackColor = Color.Transparent;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
