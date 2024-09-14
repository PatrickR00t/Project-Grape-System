namespace Grape_versão_de_avaliação
{
    partial class frmAutenticar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutenticar));
            this.ptbHomenDados = new System.Windows.Forms.PictureBox();
            this.ptbMulherDados = new System.Windows.Forms.PictureBox();
            this.ptbFundoAutenticar = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.TMhora = new System.Windows.Forms.Timer(this.components);
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomenDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMulherDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundoAutenticar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbHomenDados
            // 
            this.ptbHomenDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbHomenDados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ptbHomenDados.Image = ((System.Drawing.Image)(resources.GetObject("ptbHomenDados.Image")));
            this.ptbHomenDados.Location = new System.Drawing.Point(306, 60);
            this.ptbHomenDados.Name = "ptbHomenDados";
            this.ptbHomenDados.Size = new System.Drawing.Size(274, 275);
            this.ptbHomenDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHomenDados.TabIndex = 12;
            this.ptbHomenDados.TabStop = false;
            // 
            // ptbMulherDados
            // 
            this.ptbMulherDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbMulherDados.BackColor = System.Drawing.Color.Magenta;
            this.ptbMulherDados.Image = ((System.Drawing.Image)(resources.GetObject("ptbMulherDados.Image")));
            this.ptbMulherDados.Location = new System.Drawing.Point(26, 60);
            this.ptbMulherDados.Name = "ptbMulherDados";
            this.ptbMulherDados.Size = new System.Drawing.Size(274, 275);
            this.ptbMulherDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMulherDados.TabIndex = 13;
            this.ptbMulherDados.TabStop = false;
            // 
            // ptbFundoAutenticar
            // 
            this.ptbFundoAutenticar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbFundoAutenticar.Image = global::Grape_versão_de_avaliação.Properties.Resources._17;
            this.ptbFundoAutenticar.Location = new System.Drawing.Point(0, 0);
            this.ptbFundoAutenticar.Name = "ptbFundoAutenticar";
            this.ptbFundoAutenticar.Size = new System.Drawing.Size(612, 722);
            this.ptbFundoAutenticar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFundoAutenticar.TabIndex = 14;
            this.ptbFundoAutenticar.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNome.Location = new System.Drawing.Point(151, 451);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome :";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Magenta;
            this.lblSenha.Location = new System.Drawing.Point(147, 510);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 17);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha :";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(210, 445);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(174, 27);
            this.txbNome.TabIndex = 17;
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(210, 504);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(174, 27);
            this.txbSenha.TabIndex = 18;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 674);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(86, 38);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(10, 606);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(115, 51);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "Hora";
            // 
            // TMhora
            // 
            this.TMhora.Enabled = true;
            this.TMhora.Tick += new System.EventHandler(this.TMhora_Tick);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrar.Location = new System.Drawing.Point(237, 591);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(106, 33);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmAutenticar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 722);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ptbMulherDados);
            this.Controls.Add(this.ptbHomenDados);
            this.Controls.Add(this.ptbFundoAutenticar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutenticar";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAutenticar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomenDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMulherDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundoAutenticar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHomenDados;
        private System.Windows.Forms.PictureBox ptbMulherDados;
        private System.Windows.Forms.PictureBox ptbFundoAutenticar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer TMhora;
        private System.Windows.Forms.Button btnEntrar;
    }
}