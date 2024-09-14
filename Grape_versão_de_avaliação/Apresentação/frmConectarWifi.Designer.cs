namespace Grape_versão_de_avaliação
{
    partial class frmConectarWifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConectarWifi));
            this.lvWifi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ptbBotãoFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lvWifi
            // 
            this.lvWifi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvWifi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWifi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvWifi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lvWifi.Location = new System.Drawing.Point(0, 27);
            this.lvWifi.Name = "lvWifi";
            this.lvWifi.Size = new System.Drawing.Size(405, 493);
            this.lvWifi.TabIndex = 0;
            this.lvWifi.UseCompatibleStateImageBehavior = false;
            this.lvWifi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rede";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sinal";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 168;
            // 
            // ptbBotãoFechar
            // 
            this.ptbBotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBotãoFechar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBotãoFechar.Image")));
            this.ptbBotãoFechar.Location = new System.Drawing.Point(378, 0);
            this.ptbBotãoFechar.Name = "ptbBotãoFechar";
            this.ptbBotãoFechar.Size = new System.Drawing.Size(27, 26);
            this.ptbBotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBotãoFechar.TabIndex = 10;
            this.ptbBotãoFechar.TabStop = false;
            this.ptbBotãoFechar.Click += new System.EventHandler(this.ptbBotãoFechar_Click_1);
            // 
            // frmConectarWifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 520);
            this.Controls.Add(this.ptbBotãoFechar);
            this.Controls.Add(this.lvWifi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(710, 350);
            this.Name = "frmConectarWifi";
            this.Opacity = 0.84D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi";
            this.Load += new System.EventHandler(this.frmConectarWifi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConectarWifi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConectarWifi_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmConectarWifi_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotãoFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvWifi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox ptbBotãoFechar;
    }
}