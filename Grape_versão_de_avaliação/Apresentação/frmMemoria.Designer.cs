namespace Grape_versão_de_avaliação
{
    partial class frmMemoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemoria));
            this.ptbDiscoDeMemoria = new System.Windows.Forms.PictureBox();
            this.lblDigiteTamanhoDaMemoria = new System.Windows.Forms.Label();
            this.txbMemoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiscoDeMemoria)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbDiscoDeMemoria
            // 
            this.ptbDiscoDeMemoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbDiscoDeMemoria.Image = ((System.Drawing.Image)(resources.GetObject("ptbDiscoDeMemoria.Image")));
            this.ptbDiscoDeMemoria.Location = new System.Drawing.Point(96, 167);
            this.ptbDiscoDeMemoria.Name = "ptbDiscoDeMemoria";
            this.ptbDiscoDeMemoria.Size = new System.Drawing.Size(163, 150);
            this.ptbDiscoDeMemoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDiscoDeMemoria.TabIndex = 0;
            this.ptbDiscoDeMemoria.TabStop = false;
            // 
            // lblDigiteTamanhoDaMemoria
            // 
            this.lblDigiteTamanhoDaMemoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDigiteTamanhoDaMemoria.AutoSize = true;
            this.lblDigiteTamanhoDaMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteTamanhoDaMemoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDigiteTamanhoDaMemoria.Location = new System.Drawing.Point(-8, 383);
            this.lblDigiteTamanhoDaMemoria.Name = "lblDigiteTamanhoDaMemoria";
            this.lblDigiteTamanhoDaMemoria.Size = new System.Drawing.Size(305, 18);
            this.lblDigiteTamanhoDaMemoria.TabIndex = 1;
            this.lblDigiteTamanhoDaMemoria.Text = "Digite a quantidade de momória a ser usada :";
            // 
            // txbMemoria
            // 
            this.txbMemoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMemoria.Location = new System.Drawing.Point(335, 383);
            this.txbMemoria.Name = "txbMemoria";
            this.txbMemoria.Size = new System.Drawing.Size(38, 22);
            this.txbMemoria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(376, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "GB";
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProximo.Location = new System.Drawing.Point(124, 351);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(125, 29);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // frmMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMemoria);
            this.Controls.Add(this.lblDigiteTamanhoDaMemoria);
            this.Controls.Add(this.ptbDiscoDeMemoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemoria";
            this.Text = "Memoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiscoDeMemoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbDiscoDeMemoria;
        private System.Windows.Forms.Label lblDigiteTamanhoDaMemoria;
        private System.Windows.Forms.TextBox txbMemoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProximo;
    }
}