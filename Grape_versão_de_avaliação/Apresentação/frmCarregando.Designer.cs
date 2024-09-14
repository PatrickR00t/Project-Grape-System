namespace Grape_versão_de_avaliação
{
    partial class frmCarregando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregando));
            this.ptbCarregando = new System.Windows.Forms.PictureBox();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.lblPoucosSegundosComeçaremos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCarregando
            // 
            this.ptbCarregando.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbCarregando.Image = ((System.Drawing.Image)(resources.GetObject("ptbCarregando.Image")));
            this.ptbCarregando.Location = new System.Drawing.Point(105, 86);
            this.ptbCarregando.Name = "ptbCarregando";
            this.ptbCarregando.Size = new System.Drawing.Size(260, 288);
            this.ptbCarregando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCarregando.TabIndex = 0;
            this.ptbCarregando.TabStop = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCarregando.Location = new System.Drawing.Point(184, 394);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(83, 17);
            this.lblCarregando.TabIndex = 1;
            this.lblCarregando.Text = "Carregando";
            // 
            // lblPoucosSegundosComeçaremos
            // 
            this.lblPoucosSegundosComeçaremos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPoucosSegundosComeçaremos.AutoSize = true;
            this.lblPoucosSegundosComeçaremos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoucosSegundosComeçaremos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPoucosSegundosComeçaremos.Location = new System.Drawing.Point(-50, 217);
            this.lblPoucosSegundosComeçaremos.Name = "lblPoucosSegundosComeçaremos";
            this.lblPoucosSegundosComeçaremos.Size = new System.Drawing.Size(553, 32);
            this.lblPoucosSegundosComeçaremos.TabIndex = 2;
            this.lblPoucosSegundosComeçaremos.Text = "Dentro de poucos segundos começaremos";
            // 
            // frmCarregando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(517, 480);
            this.Controls.Add(this.lblPoucosSegundosComeçaremos);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.ptbCarregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarregando";
            this.Text = "Carregando";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCarregando_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCarregando;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Label lblPoucosSegundosComeçaremos;
    }
}