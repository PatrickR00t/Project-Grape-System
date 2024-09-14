namespace Grape_versão_de_avaliação
{
    partial class frmGrapeReprodutorDeMusicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrapeReprodutorDeMusicas));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbMusicas = new System.Windows.Forms.ListBox();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.cbModoAleatorio = new System.Windows.Forms.CheckBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblNomeDuração = new System.Windows.Forms.Label();
            this.lbltempo0 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnUltima = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeira = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnTocar = new System.Windows.Forms.Button();
            this.btnAdicionarMusicas = new System.Windows.Forms.Button();
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(350, 319);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(10, 10);
            this.Player.TabIndex = 0;
            // 
            // lbMusicas
            // 
            this.lbMusicas.FormattingEnabled = true;
            this.lbMusicas.ItemHeight = 16;
            this.lbMusicas.Location = new System.Drawing.Point(30, 60);
            this.lbMusicas.Name = "lbMusicas";
            this.lbMusicas.Size = new System.Drawing.Size(636, 388);
            this.lbMusicas.TabIndex = 32;
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.BackColor = System.Drawing.Color.Indigo;
            this.tbVolume.Location = new System.Drawing.Point(670, 490);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(56, 157);
            this.tbVolume.TabIndex = 31;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbVolume.Value = 50;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // cbModoAleatorio
            // 
            this.cbModoAleatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbModoAleatorio.AutoSize = true;
            this.cbModoAleatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbModoAleatorio.Location = new System.Drawing.Point(12, 588);
            this.cbModoAleatorio.Name = "cbModoAleatorio";
            this.cbModoAleatorio.Size = new System.Drawing.Size(124, 21);
            this.cbModoAleatorio.TabIndex = 30;
            this.cbModoAleatorio.Text = "Modo aleatório";
            this.cbModoAleatorio.UseVisualStyleBackColor = true;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuracao.Location = new System.Drawing.Point(553, 517);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(44, 17);
            this.lblDuracao.TabIndex = 29;
            this.lblDuracao.Text = "00:00";
            // 
            // lblNomeDuração
            // 
            this.lblNomeDuração.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeDuração.AutoSize = true;
            this.lblNomeDuração.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeDuração.Location = new System.Drawing.Point(485, 517);
            this.lblNomeDuração.Name = "lblNomeDuração";
            this.lblNomeDuração.Size = new System.Drawing.Size(62, 17);
            this.lblNomeDuração.TabIndex = 28;
            this.lblNomeDuração.Text = "Duração";
            // 
            // lbltempo0
            // 
            this.lbltempo0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltempo0.AutoSize = true;
            this.lbltempo0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltempo0.Location = new System.Drawing.Point(197, 517);
            this.lbltempo0.Name = "lbltempo0";
            this.lbltempo0.Size = new System.Drawing.Size(52, 17);
            this.lbltempo0.TabIndex = 27;
            this.lbltempo0.Text = "Tempo";
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTempo.Location = new System.Drawing.Point(255, 517);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(44, 17);
            this.lblTempo.TabIndex = 26;
            this.lblTempo.Text = "00:00";
            // 
            // btnUltima
            // 
            this.btnUltima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUltima.BackColor = System.Drawing.Color.Indigo;
            this.btnUltima.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUltima.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUltima.Location = new System.Drawing.Point(107, 467);
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Size = new System.Drawing.Size(75, 27);
            this.btnUltima.TabIndex = 25;
            this.btnUltima.Text = "Ultima";
            this.btnUltima.UseVisualStyleBackColor = false;
            this.btnUltima.Click += new System.EventHandler(this.btnUltima_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProxima.BackColor = System.Drawing.Color.Indigo;
            this.btnProxima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProxima.BackgroundImage")));
            this.btnProxima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProxima.Location = new System.Drawing.Point(313, 570);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(75, 54);
            this.btnProxima.TabIndex = 24;
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnterior.BackColor = System.Drawing.Color.Indigo;
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Location = new System.Drawing.Point(151, 570);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 54);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeira
            // 
            this.btnPrimeira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrimeira.BackColor = System.Drawing.Color.Indigo;
            this.btnPrimeira.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimeira.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrimeira.Location = new System.Drawing.Point(26, 467);
            this.btnPrimeira.Name = "btnPrimeira";
            this.btnPrimeira.Size = new System.Drawing.Size(75, 27);
            this.btnPrimeira.TabIndex = 22;
            this.btnPrimeira.Text = "Primeira";
            this.btnPrimeira.UseVisualStyleBackColor = false;
            this.btnPrimeira.Click += new System.EventHandler(this.btnPrimeira_Click);
            // 
            // btnResume
            // 
            this.btnResume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResume.BackColor = System.Drawing.Color.Indigo;
            this.btnResume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResume.BackgroundImage")));
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResume.Location = new System.Drawing.Point(556, 570);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 54);
            this.btnResume.TabIndex = 21;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnParar
            // 
            this.btnParar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParar.BackColor = System.Drawing.Color.Indigo;
            this.btnParar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParar.BackgroundImage")));
            this.btnParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParar.Location = new System.Drawing.Point(475, 570);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 54);
            this.btnParar.TabIndex = 20;
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPausar.BackColor = System.Drawing.Color.Indigo;
            this.btnPausar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPausar.BackgroundImage")));
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPausar.Location = new System.Drawing.Point(394, 570);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 54);
            this.btnPausar.TabIndex = 19;
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnTocar
            // 
            this.btnTocar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTocar.BackColor = System.Drawing.Color.Indigo;
            this.btnTocar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTocar.BackgroundImage")));
            this.btnTocar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTocar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTocar.Location = new System.Drawing.Point(232, 570);
            this.btnTocar.Name = "btnTocar";
            this.btnTocar.Size = new System.Drawing.Size(75, 54);
            this.btnTocar.TabIndex = 18;
            this.btnTocar.UseVisualStyleBackColor = false;
            this.btnTocar.Click += new System.EventHandler(this.btnTocar_Click);
            // 
            // btnAdicionarMusicas
            // 
            this.btnAdicionarMusicas.BackColor = System.Drawing.Color.Indigo;
            this.btnAdicionarMusicas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarMusicas.BackgroundImage")));
            this.btnAdicionarMusicas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarMusicas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarMusicas.Location = new System.Drawing.Point(30, 12);
            this.btnAdicionarMusicas.Name = "btnAdicionarMusicas";
            this.btnAdicionarMusicas.Size = new System.Drawing.Size(48, 42);
            this.btnAdicionarMusicas.TabIndex = 17;
            this.btnAdicionarMusicas.UseVisualStyleBackColor = false;
            this.btnAdicionarMusicas.Click += new System.EventHandler(this.btnAdicionarMusicas_Click);
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(682, 0);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 33;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(628, 0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimizar.TabIndex = 35;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(655, 0);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(27, 26);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximizar.TabIndex = 34;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 645);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // frmGrapeReprodutorDeMusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 645);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.ptbMaximizar);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.lbMusicas);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.cbModoAleatorio);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblNomeDuração);
            this.Controls.Add(this.lbltempo0);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnUltima);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeira);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnTocar);
            this.Controls.Add(this.btnAdicionarMusicas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrapeReprodutorDeMusicas";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprodutor de músicas";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ListBox lbMusicas;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.CheckBox cbModoAleatorio;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblNomeDuração;
        private System.Windows.Forms.Label lbltempo0;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnUltima;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeira;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnTocar;
        private System.Windows.Forms.Button btnAdicionarMusicas;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}