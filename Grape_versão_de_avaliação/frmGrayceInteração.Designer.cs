namespace Grape_versão_de_avaliação
{
    partial class frmGrayceInteração
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrayceInteração));
            this.ptbFundoInteração = new System.Windows.Forms.PictureBox();
            this.ptbEscutando = new System.Windows.Forms.PictureBox();
            this.lblEsperaFala = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundoInteração)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscutando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFundoInteração
            // 
            this.ptbFundoInteração.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFundoInteração.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbFundoInteração.Image = ((System.Drawing.Image)(resources.GetObject("ptbFundoInteração.Image")));
            this.ptbFundoInteração.Location = new System.Drawing.Point(0, 0);
            this.ptbFundoInteração.Name = "ptbFundoInteração";
            this.ptbFundoInteração.Size = new System.Drawing.Size(433, 515);
            this.ptbFundoInteração.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFundoInteração.TabIndex = 48;
            this.ptbFundoInteração.TabStop = false;
            this.ptbFundoInteração.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbFundoInteração_MouseDown);
            this.ptbFundoInteração.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbFundoInteração_MouseMove);
            this.ptbFundoInteração.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbFundoInteração_MouseUp);
            // 
            // ptbEscutando
            // 
            this.ptbEscutando.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbEscutando.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptbEscutando.Image = ((System.Drawing.Image)(resources.GetObject("ptbEscutando.Image")));
            this.ptbEscutando.Location = new System.Drawing.Point(73, 496);
            this.ptbEscutando.Name = "ptbEscutando";
            this.ptbEscutando.Size = new System.Drawing.Size(360, 16);
            this.ptbEscutando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEscutando.TabIndex = 50;
            this.ptbEscutando.TabStop = false;
            // 
            // lblEsperaFala
            // 
            this.lblEsperaFala.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEsperaFala.AutoSize = true;
            this.lblEsperaFala.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEsperaFala.ForeColor = System.Drawing.Color.Cyan;
            this.lblEsperaFala.Location = new System.Drawing.Point(-2, 494);
            this.lblEsperaFala.Name = "lblEsperaFala";
            this.lblEsperaFala.Size = new System.Drawing.Size(76, 17);
            this.lblEsperaFala.TabIndex = 49;
            this.lblEsperaFala.Text = "Diga algo :";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(433, 515);
            this.webBrowser1.TabIndex = 51;
            this.webBrowser1.Visible = false;
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(406, 1);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 31);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 52;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // frmGrayceInteração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(433, 515);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.ptbEscutando);
            this.Controls.Add(this.lblEsperaFala);
            this.Controls.Add(this.ptbFundoInteração);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrayceInteração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grayce interação";
            this.Load += new System.EventHandler(this.frmGrayceInteração_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundoInteração)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscutando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFundoInteração;
        private System.Windows.Forms.PictureBox ptbEscutando;
        private System.Windows.Forms.Label lblEsperaFala;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
    }
}