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
    public partial class frmCalculadora : Form
    {
        double primeiro;
        double segundo;
        double resultado;
        string operação;
        public frmCalculadora()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;
        private void btn0_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + ".";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operação = "+";
            primeiro = double.Parse(txbVisor.Text);
            txbVisor.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operação = "-";
            primeiro = double.Parse(txbVisor.Text);
            txbVisor.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operação = "*";
            primeiro = double.Parse(txbVisor.Text);
            txbVisor.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operação = "/";
            primeiro = double.Parse(txbVisor.Text);
            txbVisor.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txbVisor.Text);

            switch (operação)
            {
                case "+":
                    resultado = primeiro + segundo;
                    txbVisor.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primeiro - segundo;
                    txbVisor.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primeiro * segundo;
                    txbVisor.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primeiro / segundo;
                    txbVisor.Text = resultado.ToString();
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operação = "Raiz";
            primeiro = double.Parse(txbVisor.Text);
            resultado = primeiro;
            txbVisor.Text = Math.Sqrt(primeiro).ToString();
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculadora_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void frmCalculadora_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmCalculadora_MouseUp(object sender, MouseEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
