using System;

namespace Pjt_Pitico
{
    partial class Menu
    {
        private const bool V = false;

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_opcoes = new System.Windows.Forms.Button();
            this.btn_creditos = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Iniciar.Location = new System.Drawing.Point(694, 225);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(151, 37);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click_1);
            // 
            // btn_opcoes
            // 
            this.btn_opcoes.BackColor = System.Drawing.Color.LightCyan;
            this.btn_opcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opcoes.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_opcoes.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_opcoes.Location = new System.Drawing.Point(694, 277);
            this.btn_opcoes.Name = "btn_opcoes";
            this.btn_opcoes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_opcoes.Size = new System.Drawing.Size(151, 37);
            this.btn_opcoes.TabIndex = 1;
            this.btn_opcoes.Text = "Opções";
            this.btn_opcoes.UseVisualStyleBackColor = false;
            this.btn_opcoes.Click += new System.EventHandler(this.Btn_opcoes_Click);
            // 
            // btn_creditos
            // 
            this.btn_creditos.BackColor = System.Drawing.Color.LightCyan;
            this.btn_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creditos.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_creditos.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_creditos.Location = new System.Drawing.Point(694, 326);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Size = new System.Drawing.Size(151, 37);
            this.btn_creditos.TabIndex = 2;
            this.btn_creditos.Text = "Créditos";
            this.btn_creditos.UseVisualStyleBackColor = false;
            this.btn_creditos.Click += new System.EventHandler(this.btn_creditos_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightCyan;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("MS PGothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_sair.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_sair.Location = new System.Drawing.Point(694, 378);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(151, 37);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("MS PGothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_titulo.Location = new System.Drawing.Point(175, 43);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(646, 64);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Segurança Confiscada";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pjt_Pitico.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_creditos);
            this.Controls.Add(this.btn_opcoes);
            this.Controls.Add(this.btn_Iniciar);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_opcoes;
        private System.Windows.Forms.Button btn_creditos;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_titulo;
    }
}

