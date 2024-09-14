namespace Grape_versão_de_avaliação
{
    partial class frmLigar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLigar));
            this.ptbMarca = new System.Windows.Forms.PictureBox();
            this.ptbCarregandoLigar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregandoLigar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbMarca
            // 
            this.ptbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbMarca.Image = ((System.Drawing.Image)(resources.GetObject("ptbMarca.Image")));
            this.ptbMarca.Location = new System.Drawing.Point(108, 81);
            this.ptbMarca.Name = "ptbMarca";
            this.ptbMarca.Size = new System.Drawing.Size(100, 124);
            this.ptbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMarca.TabIndex = 0;
            this.ptbMarca.TabStop = false;
            // 
            // ptbCarregandoLigar
            // 
            this.ptbCarregandoLigar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbCarregandoLigar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCarregandoLigar.Image")));
            this.ptbCarregandoLigar.Location = new System.Drawing.Point(129, 292);
            this.ptbCarregandoLigar.Name = "ptbCarregandoLigar";
            this.ptbCarregandoLigar.Size = new System.Drawing.Size(57, 70);
            this.ptbCarregandoLigar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCarregandoLigar.TabIndex = 1;
            this.ptbCarregandoLigar.TabStop = false;
            // 
            // frmLigar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.ptbCarregandoLigar);
            this.Controls.Add(this.ptbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLigar";
            this.Text = "Ligar";
            this.Load += new System.EventHandler(this.frmLigar_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregandoLigar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbMarca;
        private System.Windows.Forms.PictureBox ptbCarregandoLigar;
    }
}