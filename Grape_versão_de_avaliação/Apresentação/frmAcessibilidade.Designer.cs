namespace Grape_versão_de_avaliação
{
    partial class frmAcessibilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcessibilidade));
            this.ptbLupa = new System.Windows.Forms.PictureBox();
            this.lblLupa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLupa
            // 
            this.ptbLupa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbLupa.Image = ((System.Drawing.Image)(resources.GetObject("ptbLupa.Image")));
            this.ptbLupa.Location = new System.Drawing.Point(31, 25);
            this.ptbLupa.Name = "ptbLupa";
            this.ptbLupa.Size = new System.Drawing.Size(56, 56);
            this.ptbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLupa.TabIndex = 0;
            this.ptbLupa.TabStop = false;
            // 
            // lblLupa
            // 
            this.lblLupa.AutoSize = true;
            this.lblLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLupa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLupa.Location = new System.Drawing.Point(38, 93);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(40, 17);
            this.lblLupa.TabIndex = 1;
            this.lblLupa.Text = "Lupa";
            this.lblLupa.Click += new System.EventHandler(this.lblLupa_Click);
            // 
            // frmAcessibilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(426, 435);
            this.Controls.Add(this.lblLupa);
            this.Controls.Add(this.ptbLupa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcessibilidade";
            this.Opacity = 0.83D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcessibilidade";
            ((System.ComponentModel.ISupportInitialize)(this.ptbLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLupa;
        private System.Windows.Forms.Label lblLupa;
    }
}