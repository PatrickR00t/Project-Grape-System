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
    public partial class frmDefiniçõesDeTela : Form
    {
        public frmDefiniçõesDeTela()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;

        private void frmDefiniçõesDeTela_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void frmDefiniçõesDeTela_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void frmDefiniçõesDeTela_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void frmDefiniçõesDeTela_Load(object sender, EventArgs e)
        {
            lblDefiniçõesDeTela.Parent = pictureBox1;
            lblDefiniçõesDeTela.BackColor = Color.Transparent;
            lblResoluçãoDeTela.Parent = pictureBox1;
            lblResoluçãoDeTela.BackColor = Color.Transparent;
            lblBrilhoDaTela.Parent = pictureBox1;
            lblBrilhoDaTela.BackColor = Color.Transparent;
            lblValorDoBrilho.Parent = pictureBox1;
            lblValorDoBrilho.BackColor = Color.Transparent;
        }

        private void tbBrilho_Scroll(object sender, EventArgs e)
        {
            lblValorDoBrilho.Text = tbBrilho.Value.ToString();
        }
    }
}
