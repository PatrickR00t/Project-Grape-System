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
    public partial class frmEnviar_email : Form
    {
        public frmEnviar_email()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocaction;

        private void Enviar()
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(txbDestinatario.Text);
            mmsg.Subject = txbAsunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(txbEmailUsuario.Text);

            mmsg.Body = txbCorpoEmail.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress(txbEmailUsuario.Text);

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential(txbEmailUsuario.Text, txbSenhaUsuario.Text);

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);

                MessageBox.Show("Enviado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao enviar o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEnviar_email_Load(object sender, EventArgs e)
        {
            lblEmailUsuario.Parent = pictureBox1;
            lblEmailUsuario.BackColor = Color.Transparent;
            lblSenhaDoUsuario.Parent = pictureBox1;
            lblSenhaDoUsuario.BackColor = Color.Transparent;
            lblDenstinatario.Parent = pictureBox1;
            lblDenstinatario.BackColor = Color.Transparent;
            lblAsunto.Parent = pictureBox1;
            lblAsunto.BackColor = Color.Transparent;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
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
