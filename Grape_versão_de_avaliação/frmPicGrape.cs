﻿using System;
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
    public partial class frmPicGrape : Form
    {
        public frmPicGrape()
        {
            InitializeComponent();
        }
        bool mouseDown;
        Point lastLocaction;

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptbExibeImagem.Load(openFileDialog1.FileName);
            }
            ptbExibeImagem.SizeMode = PictureBoxSizeMode.StretchImage;
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
            ptbExibeImagem.Dock = DockStyle.Fill;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbLimpar_Click(object sender, EventArgs e)
        {
            ptbExibeImagem.Image = null;
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
