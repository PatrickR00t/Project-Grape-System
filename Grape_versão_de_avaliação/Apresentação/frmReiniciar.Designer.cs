namespace Grape_versão_de_avaliação
{
    partial class frmReiniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReiniciar));
            this.lblReiniciando = new System.Windows.Forms.Label();
            this.ptbCarregandoReiniciar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregandoReiniciar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReiniciando
            // 
            this.lblReiniciando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReiniciando.AutoSize = true;
            this.lblReiniciando.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReiniciando.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblReiniciando.Location = new System.Drawing.Point(151, 163);
            this.lblReiniciando.Name = "lblReiniciando";
            this.lblReiniciando.Size = new System.Drawing.Size(249, 51);
            this.lblReiniciando.TabIndex = 2;
            this.lblReiniciando.Text = "Reiniciando";
            // 
            // ptbCarregandoReiniciar
            // 
            this.ptbCarregandoReiniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbCarregandoReiniciar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCarregandoReiniciar.Image")));
            this.ptbCarregandoReiniciar.Location = new System.Drawing.Point(224, 227);
            this.ptbCarregandoReiniciar.Name = "ptbCarregandoReiniciar";
            this.ptbCarregandoReiniciar.Size = new System.Drawing.Size(68, 78);
            this.ptbCarregandoReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCarregandoReiniciar.TabIndex = 3;
            this.ptbCarregandoReiniciar.TabStop = false;
            // 
            // frmReiniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(559, 522);
            this.Controls.Add(this.ptbCarregandoReiniciar);
            this.Controls.Add(this.lblReiniciando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReiniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reiniciar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregandoReiniciar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReiniciando;
        private System.Windows.Forms.PictureBox ptbCarregandoReiniciar;
    }
}