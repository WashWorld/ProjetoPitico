namespace Pjt_Pitico
{
    partial class Creditos
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_creditos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_voltar.ForeColor = System.Drawing.Color.Orange;
            this.btn_voltar.Location = new System.Drawing.Point(762, 509);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(151, 37);
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Orange;
            this.lbl_titulo.Location = new System.Drawing.Point(401, 81);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(198, 48);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Créditos";
            // 
            // lbl_creditos
            // 
            this.lbl_creditos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_creditos.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_creditos.Location = new System.Drawing.Point(220, 156);
            this.lbl_creditos.Name = "lbl_creditos";
            this.lbl_creditos.Size = new System.Drawing.Size(580, 303);
            this.lbl_creditos.TabIndex = 2;
            this.lbl_creditos.Text = "                 AHHHHHHHHHH\r\n                 Bhhhhhhhhhhhhhhhhh";
            this.lbl_creditos.Click += new System.EventHandler(this.lbl_creditos_Click);
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pjt_Pitico.Properties.Resources.Créditos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.lbl_creditos);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_voltar);
            this.DoubleBuffered = true;
            this.Name = "Creditos";
            this.Text = "Créditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_creditos;
    }
}