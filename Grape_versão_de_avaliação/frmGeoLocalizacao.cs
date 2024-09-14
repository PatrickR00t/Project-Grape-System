using System;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Grape_versão_de_avaliação
{
    public partial class frmGeoLocalizacao : Form
    {
        bool mouseDown;
        Point lastLocaction;

        public frmGeoLocalizacao()
        {
            InitializeComponent();
        }

        private void frmGeoLocalizacao_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            lblAguarde.Parent = pictureBox1;
            lblAguarde.BackColor = Color.Transparent;
        }

        private void btnLocationDetails_Click(object sender, EventArgs e)
        {
            if (txbIpAaddress.Text != "")
            {
                lblAguarde.Visible = true;

                txbIpLocationResult.Text = FetchCurrentIpLocation(txbIpAaddress.Text);

                if (txbIpLocationResult.Text != "")
                {
                    lblAguarde.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Insira o ip a ser rastreado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private string FetchCurrentIpLocation(string strIP)
        {
            string strIpLocation = string.Empty;

            
            var client = new RestClient("https://ipapi.co/" + strIP + "/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };
            

            var response = client.Execute(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIpLocation += key.ToString() + ": " + dictionary[key] + "\r\n";
            }

            return strIpLocation;
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
