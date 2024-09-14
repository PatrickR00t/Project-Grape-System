namespace Grape_versão_de_avaliação
{
    partial class frmGeoLocalizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeoLocalizacao));
            this.label1 = new System.Windows.Forms.Label();
            this.txbIpAaddress = new System.Windows.Forms.TextBox();
            this.btnLocationDetails = new System.Windows.Forms.Button();
            this.txbIpLocationResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            this.lblAguarde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // txbIpAaddress
            // 
            this.txbIpAaddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbIpAaddress.Location = new System.Drawing.Point(60, 73);
            this.txbIpAaddress.Name = "txbIpAaddress";
            this.txbIpAaddress.Size = new System.Drawing.Size(178, 22);
            this.txbIpAaddress.TabIndex = 1;
            // 
            // btnLocationDetails
            // 
            this.btnLocationDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLocationDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLocationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocationDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocationDetails.Location = new System.Drawing.Point(244, 73);
            this.btnLocationDetails.Name = "btnLocationDetails";
            this.btnLocationDetails.Size = new System.Drawing.Size(78, 23);
            this.btnLocationDetails.TabIndex = 3;
            this.btnLocationDetails.Text = "Localizar";
            this.btnLocationDetails.UseVisualStyleBackColor = false;
            this.btnLocationDetails.Click += new System.EventHandler(this.btnLocationDetails_Click);
            // 
            // txbIpLocationResult
            // 
            this.txbIpLocationResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbIpLocationResult.BackColor = System.Drawing.SystemColors.Control;
            this.txbIpLocationResult.Enabled = false;
            this.txbIpLocationResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbIpLocationResult.Location = new System.Drawing.Point(29, 170);
            this.txbIpLocationResult.Multiline = true;
            this.txbIpLocationResult.Name = "txbIpLocationResult";
            this.txbIpLocationResult.Size = new System.Drawing.Size(293, 263);
            this.txbIpLocationResult.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(282, 0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimizar.TabIndex = 22;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(309, 0);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximizar.TabIndex = 21;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(336, 0);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 20;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // lblAguarde
            // 
            this.lblAguarde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAguarde.AutoSize = true;
            this.lblAguarde.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAguarde.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAguarde.Location = new System.Drawing.Point(26, 150);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(74, 17);
            this.lblAguarde.TabIndex = 23;
            this.lblAguarde.Text = "Aguarde...";
            this.lblAguarde.Visible = false;
            // 
            // frmGeoLocalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(363, 471);
            this.Controls.Add(this.lblAguarde);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.ptbMaximizar);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.btnLocationDetails);
            this.Controls.Add(this.txbIpAaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbIpLocationResult);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeoLocalizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGeoLocalizacao";
            this.Load += new System.EventHandler(this.frmGeoLocalizacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIpAaddress;
        private System.Windows.Forms.Button btnLocationDetails;
        private System.Windows.Forms.TextBox txbIpLocationResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
        private System.Windows.Forms.Label lblAguarde;
    }
}