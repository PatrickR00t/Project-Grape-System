using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Grape_versão_de_avaliação
{
    public partial class frmWebcam : Form
    {
        bool mouseDown;
        Point lastLocaction;

        private VideoCaptureDevice videoSource;

        public frmWebcam()
        {
            InitializeComponent();

            var videoSources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoSources != null && videoSources.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoSources[0].MonikerString);
                videoSource.NewFrame += videoSource_NewFrame;
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (ptbWebCam.Image != null)
                ptbWebCam.Image.Dispose();
            
            ptbWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
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
            ptbWebCam.Dock = DockStyle.Fill;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLigarDesligar_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                btnLigarDesligar.BackColor = Color.IndianRed;
                videoSource.Stop();
                ptbWebCam.Image = null;
            }
            else
            {
                btnLigarDesligar.BackColor = Color.Lime;
                videoSource.Start();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (ptbWebCam.Image != null)
            {
                try
                {
                    videoSource.NewFrame -= videoSource_NewFrame;

                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.DefaultExt = "png";
                        dialog.AddExtension = true;

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            ptbWebCam.Image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
                finally
                {
                    videoSource.NewFrame += videoSource_NewFrame;
                }
            }

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

        /*
protected override void OnFormClosing(FormClosingEventArgs e)
{
   if (videoSource.IsRunning)
   {
       videoSource.Stop();
   }
   base.OnFormClosing(e);
}
*/
    }
}