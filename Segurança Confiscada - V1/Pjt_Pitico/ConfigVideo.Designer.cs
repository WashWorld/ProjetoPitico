namespace Pjt_Pitico
{
    partial class ConfigVideo
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_legendas = new System.Windows.Forms.Label();
            this.lbl_daltonico = new System.Windows.Forms.Label();
            this.lbl_altocontraste = new System.Windows.Forms.Label();
            this.lbl_brilho = new System.Windows.Forms.Label();
            this.rdb_ligado = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdb_desligado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_titulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_titulo.Location = new System.Drawing.Point(323, 96);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(381, 48);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Opções de Vídeo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_legendas
            // 
            this.lbl_legendas.AutoSize = true;
            this.lbl_legendas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_legendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_legendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legendas.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_legendas.Location = new System.Drawing.Point(243, 189);
            this.lbl_legendas.Name = "lbl_legendas";
            this.lbl_legendas.Size = new System.Drawing.Size(113, 25);
            this.lbl_legendas.TabIndex = 6;
            this.lbl_legendas.Text = "Legendas:";
            // 
            // lbl_daltonico
            // 
            this.lbl_daltonico.AutoSize = true;
            this.lbl_daltonico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_daltonico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_daltonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daltonico.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_daltonico.Location = new System.Drawing.Point(243, 259);
            this.lbl_daltonico.Name = "lbl_daltonico";
            this.lbl_daltonico.Size = new System.Drawing.Size(162, 25);
            this.lbl_daltonico.TabIndex = 7;
            this.lbl_daltonico.Text = "Modo Daltônico";
            // 
            // lbl_altocontraste
            // 
            this.lbl_altocontraste.AutoSize = true;
            this.lbl_altocontraste.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altocontraste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_altocontraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altocontraste.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_altocontraste.Location = new System.Drawing.Point(243, 328);
            this.lbl_altocontraste.Name = "lbl_altocontraste";
            this.lbl_altocontraste.Size = new System.Drawing.Size(148, 25);
            this.lbl_altocontraste.TabIndex = 8;
            this.lbl_altocontraste.Text = "Alto Contraste";
            // 
            // lbl_brilho
            // 
            this.lbl_brilho.AutoSize = true;
            this.lbl_brilho.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_brilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brilho.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_brilho.Location = new System.Drawing.Point(243, 397);
            this.lbl_brilho.Name = "lbl_brilho";
            this.lbl_brilho.Size = new System.Drawing.Size(67, 25);
            this.lbl_brilho.TabIndex = 9;
            this.lbl_brilho.Text = "Brilho";
            // 
            // rdb_ligado
            // 
            this.rdb_ligado.AutoSize = true;
            this.rdb_ligado.BackColor = System.Drawing.Color.Transparent;
            this.rdb_ligado.Checked = true;
            this.rdb_ligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_ligado.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_ligado.Location = new System.Drawing.Point(379, 186);
            this.rdb_ligado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_ligado.Name = "rdb_ligado";
            this.rdb_ligado.Size = new System.Drawing.Size(74, 31);
            this.rdb_ligado.TabIndex = 14;
            this.rdb_ligado.TabStop = true;
            this.rdb_ligado.Text = "Ligar";
            this.rdb_ligado.UseCompatibleTextRendering = true;
            this.rdb_ligado.UseVisualStyleBackColor = false;
            this.rdb_ligado.CheckedChanged += new System.EventHandler(this.rdb_ligado_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rdb_desligado
            // 
            this.rdb_desligado.AutoSize = true;
            this.rdb_desligado.BackColor = System.Drawing.Color.Transparent;
            this.rdb_desligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_desligado.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_desligado.Location = new System.Drawing.Point(487, 189);
            this.rdb_desligado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_desligado.Name = "rdb_desligado";
            this.rdb_desligado.Size = new System.Drawing.Size(110, 30);
            this.rdb_desligado.TabIndex = 17;
            this.rdb_desligado.Text = "Desligar";
            this.rdb_desligado.UseVisualStyleBackColor = false;
            this.rdb_desligado.CheckedChanged += new System.EventHandler(this.rdb_desligado_CheckedChanged);
            // 
            // ConfigVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pjt_Pitico.Properties.Resources.menu_opcoes1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.rdb_desligado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdb_ligado);
            this.Controls.Add(this.lbl_brilho);
            this.Controls.Add(this.lbl_altocontraste);
            this.Controls.Add(this.lbl_daltonico);
            this.Controls.Add(this.lbl_legendas);
            this.Controls.Add(this.lbl_titulo);
            this.DoubleBuffered = true;
            this.Name = "ConfigVideo";
            this.Text = "ConfigVideo";
            this.Load += new System.EventHandler(this.ConfigVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_legendas;
        private System.Windows.Forms.Label lbl_daltonico;
        private System.Windows.Forms.Label lbl_altocontraste;
        private System.Windows.Forms.Label lbl_brilho;
        private System.Windows.Forms.RadioButton rdb_ligado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdb_desligado;
    }
}