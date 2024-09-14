namespace Grape_versão_de_avaliação
{
    partial class frmMeuIp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeuIp));
            this.label1 = new System.Windows.Forms.Label();
            this.txbMeuIp = new System.Windows.Forms.TextBox();
            this.btnMeuIp = new System.Windows.Forms.Button();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip:";
            // 
            // txbMeuIp
            // 
            this.txbMeuIp.Location = new System.Drawing.Point(59, 47);
            this.txbMeuIp.Name = "txbMeuIp";
            this.txbMeuIp.Size = new System.Drawing.Size(183, 22);
            this.txbMeuIp.TabIndex = 1;
            // 
            // btnMeuIp
            // 
            this.btnMeuIp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMeuIp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeuIp.Location = new System.Drawing.Point(102, 83);
            this.btnMeuIp.Name = "btnMeuIp";
            this.btnMeuIp.Size = new System.Drawing.Size(75, 31);
            this.btnMeuIp.TabIndex = 2;
            this.btnMeuIp.Text = "ver ip";
            this.btnMeuIp.UseVisualStyleBackColor = false;
            this.btnMeuIp.Click += new System.EventHandler(this.btnMeuIp_Click);
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(271, -1);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 35;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // frmMeuIp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(296, 130);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.btnMeuIp);
            this.Controls.Add(this.txbMeuIp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMeuIp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeuIp";
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMeuIp;
        private System.Windows.Forms.Button btnMeuIp;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
    }
}