namespace Pjt_Pitico
{
    partial class ConfigAudio
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lbl_narracao = new System.Windows.Forms.Label();
            this.lbl_dublagem = new System.Windows.Forms.Label();
            this.lbl_geral = new System.Windows.Forms.Label();
            this.lbl_vozes = new System.Windows.Forms.Label();
            this.lbl_ambiente = new System.Windows.Forms.Label();
            this.rdb_portugues = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_titulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbl_titulo.Location = new System.Drawing.Point(314, 88);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(377, 48);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Opções de Áudio";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_config_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(506, 297);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(80, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(506, 358);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lbl_narracao
            // 
            this.lbl_narracao.AutoSize = true;
            this.lbl_narracao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_narracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_narracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_narracao.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_narracao.Location = new System.Drawing.Point(245, 173);
            this.lbl_narracao.Name = "lbl_narracao";
            this.lbl_narracao.Size = new System.Drawing.Size(308, 25);
            this.lbl_narracao.TabIndex = 5;
            this.lbl_narracao.Text = "Descrição de áudio (narração):";
            // 
            // lbl_dublagem
            // 
            this.lbl_dublagem.AutoSize = true;
            this.lbl_dublagem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dublagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dublagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dublagem.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_dublagem.Location = new System.Drawing.Point(246, 244);
            this.lbl_dublagem.Name = "lbl_dublagem";
            this.lbl_dublagem.Size = new System.Drawing.Size(115, 25);
            this.lbl_dublagem.TabIndex = 6;
            this.lbl_dublagem.Text = "Dublagem:";
            // 
            // lbl_geral
            // 
            this.lbl_geral.AutoSize = true;
            this.lbl_geral.BackColor = System.Drawing.Color.Transparent;
            this.lbl_geral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_geral.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_geral.Location = new System.Drawing.Point(341, 307);
            this.lbl_geral.Name = "lbl_geral";
            this.lbl_geral.Size = new System.Drawing.Size(142, 25);
            this.lbl_geral.TabIndex = 7;
            this.lbl_geral.Text = "Volume Geral";
            // 
            // lbl_vozes
            // 
            this.lbl_vozes.AutoSize = true;
            this.lbl_vozes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vozes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vozes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vozes.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_vozes.Location = new System.Drawing.Point(341, 367);
            this.lbl_vozes.Name = "lbl_vozes";
            this.lbl_vozes.Size = new System.Drawing.Size(150, 25);
            this.lbl_vozes.TabIndex = 8;
            this.lbl_vozes.Text = "Volume Vozes";
            // 
            // lbl_ambiente
            // 
            this.lbl_ambiente.AutoSize = true;
            this.lbl_ambiente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ambiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ambiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ambiente.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_ambiente.Location = new System.Drawing.Point(341, 425);
            this.lbl_ambiente.Name = "lbl_ambiente";
            this.lbl_ambiente.Size = new System.Drawing.Size(180, 25);
            this.lbl_ambiente.TabIndex = 9;
            this.lbl_ambiente.Text = "Volume Ambiente";
            // 
            // rdb_portugues
            // 
            this.rdb_portugues.AutoSize = true;
            this.rdb_portugues.BackColor = System.Drawing.Color.Transparent;
            this.rdb_portugues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.rdb_portugues.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_portugues.Location = new System.Drawing.Point(576, 173);
            this.rdb_portugues.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_portugues.Name = "rdb_portugues";
            this.rdb_portugues.Size = new System.Drawing.Size(78, 30);
            this.rdb_portugues.TabIndex = 10;
            this.rdb_portugues.TabStop = true;
            this.rdb_portugues.Text = "Ligar";
            this.rdb_portugues.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.radioButton4.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton4.Location = new System.Drawing.Point(671, 173);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 30);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Desligar";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.radioButton1.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton1.Location = new System.Drawing.Point(474, 244);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 30);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Desligar";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.76F);
            this.radioButton2.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton2.Location = new System.Drawing.Point(379, 244);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 30);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ligar";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // ConfigAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pjt_Pitico.Properties.Resources.menu_opcoes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rdb_portugues);
            this.Controls.Add(this.lbl_ambiente);
            this.Controls.Add(this.lbl_vozes);
            this.Controls.Add(this.lbl_geral);
            this.Controls.Add(this.lbl_dublagem);
            this.Controls.Add(this.lbl_narracao);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_titulo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigAudio";
            this.Text = "ConfigAudio";
            this.Load += new System.EventHandler(this.ConfigAudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lbl_narracao;
        private System.Windows.Forms.Label lbl_dublagem;
        private System.Windows.Forms.Label lbl_geral;
        private System.Windows.Forms.Label lbl_vozes;
        private System.Windows.Forms.Label lbl_ambiente;
        private System.Windows.Forms.RadioButton rdb_portugues;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}