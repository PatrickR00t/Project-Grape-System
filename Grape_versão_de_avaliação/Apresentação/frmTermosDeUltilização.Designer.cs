namespace Grape_versão_de_avaliação
{
    partial class frmTermosDeUltilização
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
            this.lblTermosDeUso = new System.Windows.Forms.Label();
            this.txbTermosDeUso = new System.Windows.Forms.TextBox();
            this.btnAceito = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTermosDeUso
            // 
            this.lblTermosDeUso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTermosDeUso.AutoSize = true;
            this.lblTermosDeUso.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTermosDeUso.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermosDeUso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTermosDeUso.Location = new System.Drawing.Point(25, 48);
            this.lblTermosDeUso.Name = "lblTermosDeUso";
            this.lblTermosDeUso.Size = new System.Drawing.Size(372, 20);
            this.lblTermosDeUso.TabIndex = 1;
            this.lblTermosDeUso.Text = "Termos de ultilização do software";
            // 
            // txbTermosDeUso
            // 
            this.txbTermosDeUso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTermosDeUso.Location = new System.Drawing.Point(12, 80);
            this.txbTermosDeUso.Multiline = true;
            this.txbTermosDeUso.Name = "txbTermosDeUso";
            this.txbTermosDeUso.Size = new System.Drawing.Size(467, 325);
            this.txbTermosDeUso.TabIndex = 2;
            // 
            // btnAceito
            // 
            this.btnAceito.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceito.Location = new System.Drawing.Point(249, 439);
            this.btnAceito.Name = "btnAceito";
            this.btnAceito.Size = new System.Drawing.Size(87, 29);
            this.btnAceito.TabIndex = 3;
            this.btnAceito.Text = "Aceito";
            this.btnAceito.UseVisualStyleBackColor = true;
            this.btnAceito.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.Location = new System.Drawing.Point(159, 439);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 29);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Você aceita todos os termos ?";
            // 
            // frmTermosDeUltilização
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(492, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAceito);
            this.Controls.Add(this.txbTermosDeUso);
            this.Controls.Add(this.lblTermosDeUso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTermosDeUltilização";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termos de ultilização";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTermosDeUso;
        private System.Windows.Forms.TextBox txbTermosDeUso;
        private System.Windows.Forms.Button btnAceito;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
    }
}