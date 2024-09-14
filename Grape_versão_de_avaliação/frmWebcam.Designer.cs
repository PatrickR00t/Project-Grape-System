namespace Grape_versão_de_avaliação
{
    partial class frmWebcam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebcam));
            this.ptbWebCam = new System.Windows.Forms.PictureBox();
            this.btnLigarDesligar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbWebCam
            // 
            this.ptbWebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbWebCam.Location = new System.Drawing.Point(13, 39);
            this.ptbWebCam.Name = "ptbWebCam";
            this.ptbWebCam.Size = new System.Drawing.Size(491, 420);
            this.ptbWebCam.TabIndex = 0;
            this.ptbWebCam.TabStop = false;
            // 
            // btnLigarDesligar
            // 
            this.btnLigarDesligar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLigarDesligar.BackColor = System.Drawing.Color.Lime;
            this.btnLigarDesligar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLigarDesligar.BackgroundImage")));
            this.btnLigarDesligar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLigarDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLigarDesligar.Location = new System.Drawing.Point(184, 465);
            this.btnLigarDesligar.Name = "btnLigarDesligar";
            this.btnLigarDesligar.Size = new System.Drawing.Size(43, 35);
            this.btnLigarDesligar.TabIndex = 1;
            this.btnLigarDesligar.UseVisualStyleBackColor = false;
            this.btnLigarDesligar.Click += new System.EventHandler(this.btnLigarDesligar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapturar.BackColor = System.Drawing.Color.LightGray;
            this.btnCapturar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapturar.BackgroundImage")));
            this.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapturar.Location = new System.Drawing.Point(233, 465);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(46, 35);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(434, 1);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimizar.TabIndex = 19;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(461, 1);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximizar.TabIndex = 18;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(487, 1);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 17;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 33);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 64);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // frmWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(515, 526);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.ptbMaximizar);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnLigarDesligar);
            this.Controls.Add(this.ptbWebCam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWebcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            ((System.ComponentModel.ISupportInitialize)(this.ptbWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbWebCam;
        private System.Windows.Forms.Button btnLigarDesligar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}