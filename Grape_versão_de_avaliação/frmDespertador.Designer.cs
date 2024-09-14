namespace Grape_versão_de_avaliação
{
    partial class frmDespertador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespertador));
            this.txbMusica = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtivarAlarme = new System.Windows.Forms.Button();
            this.btnPararAlarme = new System.Windows.Forms.Button();
            this.lblHoraDespertar = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMarcadorDeHora = new System.Windows.Forms.Label();
            this.T_HoraAtual = new System.Windows.Forms.Timer(this.components);
            this.T_HoraDespertar = new System.Windows.Forms.Timer(this.components);
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMusica
            // 
            this.txbMusica.Location = new System.Drawing.Point(25, 75);
            this.txbMusica.Name = "txbMusica";
            this.txbMusica.Size = new System.Drawing.Size(364, 22);
            this.txbMusica.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionar.Location = new System.Drawing.Point(404, 71);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(34, 31);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtivarAlarme
            // 
            this.btnAtivarAlarme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtivarAlarme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtivarAlarme.BackgroundImage")));
            this.btnAtivarAlarme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtivarAlarme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtivarAlarme.Location = new System.Drawing.Point(25, 216);
            this.btnAtivarAlarme.Name = "btnAtivarAlarme";
            this.btnAtivarAlarme.Size = new System.Drawing.Size(75, 53);
            this.btnAtivarAlarme.TabIndex = 2;
            this.btnAtivarAlarme.UseVisualStyleBackColor = false;
            this.btnAtivarAlarme.Click += new System.EventHandler(this.btnAtivarAlarme_Click);
            // 
            // btnPararAlarme
            // 
            this.btnPararAlarme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPararAlarme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPararAlarme.BackgroundImage")));
            this.btnPararAlarme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPararAlarme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPararAlarme.Location = new System.Drawing.Point(117, 216);
            this.btnPararAlarme.Name = "btnPararAlarme";
            this.btnPararAlarme.Size = new System.Drawing.Size(75, 53);
            this.btnPararAlarme.TabIndex = 3;
            this.btnPararAlarme.UseVisualStyleBackColor = false;
            this.btnPararAlarme.Click += new System.EventHandler(this.btnPararAlarme_Click);
            // 
            // lblHoraDespertar
            // 
            this.lblHoraDespertar.AutoSize = true;
            this.lblHoraDespertar.ForeColor = System.Drawing.Color.Teal;
            this.lblHoraDespertar.Location = new System.Drawing.Point(44, 126);
            this.lblHoraDespertar.Name = "lblHoraDespertar";
            this.lblHoraDespertar.Size = new System.Drawing.Size(64, 17);
            this.lblHoraDespertar.TabIndex = 4;
            this.lblHoraDespertar.Text = "00:00:00";
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(25, 146);
            this.mtbHora.Mask = "00:00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(100, 22);
            this.mtbHora.TabIndex = 5;
            this.mtbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(144, 231);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(24, 23);
            this.wmp.TabIndex = 6;
            this.wmp.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHora.Location = new System.Drawing.Point(22, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 17);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora :";
            // 
            // lblMarcadorDeHora
            // 
            this.lblMarcadorDeHora.AutoSize = true;
            this.lblMarcadorDeHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarcadorDeHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMarcadorDeHora.Location = new System.Drawing.Point(75, 9);
            this.lblMarcadorDeHora.Name = "lblMarcadorDeHora";
            this.lblMarcadorDeHora.Size = new System.Drawing.Size(64, 17);
            this.lblMarcadorDeHora.TabIndex = 8;
            this.lblMarcadorDeHora.Text = "00:00:00";
            // 
            // T_HoraAtual
            // 
            this.T_HoraAtual.Enabled = true;
            this.T_HoraAtual.Interval = 1000;
            this.T_HoraAtual.Tick += new System.EventHandler(this.T_HoraAtual_Tick);
            // 
            // T_HoraDespertar
            // 
            this.T_HoraDespertar.Tick += new System.EventHandler(this.T_HoraDespertar_Tick);
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(444, 0);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 9;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione sua musica de toque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(38, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ativar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(132, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parar";
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(391, 0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimizar.TabIndex = 18;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(417, 0);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximizar.TabIndex = 17;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // frmDespertador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.ptbMaximizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.lblMarcadorDeHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.lblHoraDespertar);
            this.Controls.Add(this.btnPararAlarme);
            this.Controls.Add(this.btnAtivarAlarme);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbMusica);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDespertador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despertador";
            this.Load += new System.EventHandler(this.frmDespertador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMusica;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtivarAlarme;
        private System.Windows.Forms.Button btnPararAlarme;
        private System.Windows.Forms.Label lblHoraDespertar;
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMarcadorDeHora;
        private System.Windows.Forms.Timer T_HoraAtual;
        private System.Windows.Forms.Timer T_HoraDespertar;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}