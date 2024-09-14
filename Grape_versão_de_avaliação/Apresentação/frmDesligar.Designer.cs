namespace Grape_versão_de_avaliação
{
    partial class frmDesligar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesligar));
            this.ptbCarregandoDesligar = new System.Windows.Forms.PictureBox();
            this.lblDesligando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregandoDesligar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCarregandoDesligar
            // 
            this.ptbCarregandoDesligar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbCarregandoDesligar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCarregandoDesligar.Image")));
            this.ptbCarregandoDesligar.Location = new System.Drawing.Point(183, 347);
            this.ptbCarregandoDesligar.Name = "ptbCarregandoDesligar";
            this.ptbCarregandoDesligar.Size = new System.Drawing.Size(68, 78);
            this.ptbCarregandoDesligar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCarregandoDesligar.TabIndex = 0;
            this.ptbCarregandoDesligar.TabStop = false;
            // 
            // lblDesligando
            // 
            this.lblDesligando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesligando.AutoSize = true;
            this.lblDesligando.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesligando.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDesligando.Location = new System.Drawing.Point(107, 152);
            this.lblDesligando.Name = "lblDesligando";
            this.lblDesligando.Size = new System.Drawing.Size(239, 51);
            this.lblDesligando.TabIndex = 1;
            this.lblDesligando.Text = "Desligando";
            // 
            // frmDesligar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(479, 574);
            this.Controls.Add(this.lblDesligando);
            this.Controls.Add(this.ptbCarregandoDesligar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDesligar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Desligar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregandoDesligar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCarregandoDesligar;
        private System.Windows.Forms.Label lblDesligando;
    }
}