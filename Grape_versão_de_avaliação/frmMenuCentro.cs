using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grape_versão_de_avaliação
{
    public partial class frmMenuCentro : Form
    {
        public frmMenuCentro()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(forma);
        }

        private void frmMenuCentro_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
