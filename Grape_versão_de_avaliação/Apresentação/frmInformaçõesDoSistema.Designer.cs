namespace Grape_versão_de_avaliação
{
    partial class frmInformaçõesDoSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformaçõesDoSistema));
            this.ptbMarca = new System.Windows.Forms.PictureBox();
            this.lblVersãoDoSistema = new System.Windows.Forms.Label();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbMarca
            // 
            this.ptbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbMarca.Image = ((System.Drawing.Image)(resources.GetObject("ptbMarca.Image")));
            this.ptbMarca.Location = new System.Drawing.Point(204, 39);
            this.ptbMarca.Name = "ptbMarca";
            this.ptbMarca.Size = new System.Drawing.Size(100, 149);
            this.ptbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMarca.TabIndex = 3;
            this.ptbMarca.TabStop = false;
            // 
            // lblVersãoDoSistema
            // 
            this.lblVersãoDoSistema.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVersãoDoSistema.AutoSize = true;
            this.lblVersãoDoSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVersãoDoSistema.Location = new System.Drawing.Point(141, 191);
            this.lblVersãoDoSistema.Name = "lblVersãoDoSistema";
            this.lblVersãoDoSistema.Size = new System.Drawing.Size(211, 17);
            this.lblVersãoDoSistema.TabIndex = 4;
            this.lblVersãoDoSistema.Text = "A versão atual do sistema é: 1.0";
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(503, -2);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 5;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(476, -2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 26);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 16;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(449, -2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // frmInformaçõesDoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(529, 600);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.lblVersãoDoSistema);
            this.Controls.Add(this.ptbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformaçõesDoSistema";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do sistema";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmInformaçõesDoSistema_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmInformaçõesDoSistema_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmInformaçõesDoSistema_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbMarca;
        private System.Windows.Forms.Label lblVersãoDoSistema;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}