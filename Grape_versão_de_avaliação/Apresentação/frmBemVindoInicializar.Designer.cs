namespace Grape_versão_de_avaliação
{
    partial class frmBemVindoInicializar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBemVindoInicializar));
            this.ptbHomenDados = new System.Windows.Forms.PictureBox();
            this.ptbMulherDados = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomenDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMulherDados)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbHomenDados
            // 
            this.ptbHomenDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbHomenDados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ptbHomenDados.Image = ((System.Drawing.Image)(resources.GetObject("ptbHomenDados.Image")));
            this.ptbHomenDados.Location = new System.Drawing.Point(326, 52);
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
            this.ptbMulherDados.Location = new System.Drawing.Point(46, 52);
            this.ptbMulherDados.Name = "ptbMulherDados";
            this.ptbMulherDados.Size = new System.Drawing.Size(274, 275);
            this.ptbMulherDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMulherDados.TabIndex = 13;
            this.ptbMulherDados.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bem vindo(a)";
            // 
            // frmBemVindoInicializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbMulherDados);
            this.Controls.Add(this.ptbHomenDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBemVindoInicializar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmBemVindoInicializar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBemVindoInicializar_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomenDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMulherDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHomenDados;
        private System.Windows.Forms.PictureBox ptbMulherDados;
        private System.Windows.Forms.Label label1;
    }
}