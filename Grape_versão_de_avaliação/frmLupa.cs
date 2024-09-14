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
    public partial class frmLupa : Form
    {
        Bitmap Bit;
        Graphics Graf;
        int Zoom = 2;

        public frmLupa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bit = new Bitmap(ptbTelaZoom.Width / Zoom, ptbTelaZoom.Height / Zoom, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graf = Graphics.FromImage(Bit);
            Graf.CopyFromScreen(MousePosition.X - ptbTelaZoom.Width / (Zoom * 2), MousePosition.Y - ptbTelaZoom.Height / (Zoom * 2), 0, 0, ptbTelaZoom.Size, CopyPixelOperation.SourceCopy);
            ptbTelaZoom.Image = Bit;
        }

        private void txtZoom_TextChanged(object sender, EventArgs e)
        {
            Zoom = Convert.ToInt32(txtZoom.Text);
            
        }
    }
}
