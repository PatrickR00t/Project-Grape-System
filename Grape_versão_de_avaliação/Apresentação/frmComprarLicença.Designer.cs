namespace Grape_versão_de_avaliação
{
    partial class frmComprarLicença
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprarLicença));
            this.label1 = new System.Windows.Forms.Label();
            this.lblChaveDeAtivação = new System.Windows.Forms.Label();
            this.txbChaveDeAtivação = new System.Windows.Forms.TextBox();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para comprar a licença, acesse o link do nosso site abaixo :";
            // 
            // lblChaveDeAtivação
            // 
            this.lblChaveDeAtivação.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChaveDeAtivação.AutoSize = true;
            this.lblChaveDeAtivação.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblChaveDeAtivação.Location = new System.Drawing.Point(12, 300);
            this.lblChaveDeAtivação.Name = "lblChaveDeAtivação";
            this.lblChaveDeAtivação.Size = new System.Drawing.Size(133, 17);
            this.lblChaveDeAtivação.TabIndex = 4;
            this.lblChaveDeAtivação.Text = "Chave de ativação :";
            // 
            // txbChaveDeAtivação
            // 
            this.txbChaveDeAtivação.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbChaveDeAtivação.BackColor = System.Drawing.SystemColors.Control;
            this.txbChaveDeAtivação.Location = new System.Drawing.Point(148, 299);
            this.txbChaveDeAtivação.Name = "txbChaveDeAtivação";
            this.txbChaveDeAtivação.Size = new System.Drawing.Size(247, 22);
            this.txbChaveDeAtivação.TabIndex = 5;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtivar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAtivar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtivar.Location = new System.Drawing.Point(192, 427);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(101, 32);
            this.btnAtivar.TabIndex = 6;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = false;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(463, 3);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 7;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(430, 3);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximizar.TabIndex = 16;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(397, 3);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimizar.TabIndex = 17;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // frmComprarLicença
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 507);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.ptbMaximizar);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.txbChaveDeAtivação);
            this.Controls.Add(this.lblChaveDeAtivação);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComprarLicença";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar licença";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmComprarLicença_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmComprarLicença_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmComprarLicença_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChaveDeAtivação;
        private System.Windows.Forms.TextBox txbChaveDeAtivação;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
    }
}