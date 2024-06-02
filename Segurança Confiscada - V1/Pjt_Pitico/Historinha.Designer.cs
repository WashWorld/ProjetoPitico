using System;

namespace Pjt_Pitico
{
    partial class Historinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historinha));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(26, 612);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1239, 122);
            this.textBox1.TabIndex = 10;
            this.textBox1.UseWaitCursor = true;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(1257, 612);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(130, 122);
            this.btn_iniciar.TabIndex = 11;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, -5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(26, -81);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1063, 692);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ultimo.BackgroundImage = global::Pjt_Pitico.Properties.Resources.kisspng_arrow_symbol_left_arrow_5ac71892140cd1_9018364915229973940821;
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_ultimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ultimo.Location = new System.Drawing.Point(1242, 612);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(130, 122);
            this.btn_ultimo.TabIndex = 23;
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Visible = false;
            this.btn_ultimo.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.BackgroundImage = global::Pjt_Pitico.Properties.Resources.kisspng_arrow_symbol_left_arrow_5ac71892140cd1_9018364915229973940821;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.PeachPuff;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1242, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 122);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cont
            // 
            this.btn_cont.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_cont.BackgroundImage = global::Pjt_Pitico.Properties.Resources.kisspng_arrow_symbol_left_arrow_5ac71892140cd1_9018364915229973940821;
            this.btn_cont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cont.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_cont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cont.Location = new System.Drawing.Point(1242, 612);
            this.btn_cont.Name = "btn_cont";
            this.btn_cont.Size = new System.Drawing.Size(130, 122);
            this.btn_cont.TabIndex = 12;
            this.btn_cont.UseVisualStyleBackColor = false;
            this.btn_cont.Visible = false;
            this.btn_cont.Click += new System.EventHandler(this.button5_Click);
            // 
            // Historinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1399, 773);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cont);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Historinha";
            this.Opacity = 0D;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Historinha_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   
   

        
        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_cont;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ultimo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}