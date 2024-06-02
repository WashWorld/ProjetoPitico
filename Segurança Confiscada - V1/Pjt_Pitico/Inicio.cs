using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pjt_Pitico
{
    public partial class Inicio : Form
    {
        private Historinha historinhaForm;
        public Inicio()
        {
            InitializeComponent();
        }
        int[] targetColor = { 255, 255, 255 };
        int[] fadeRGB = new int[3];

    private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }


        void Form2_Load(object sender, EventArgs e)
        {
            lbl_titulo.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);

        }

         void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
                fadeOut();
                Opacity += .2;
            }
          void fadeOut()
            {
                fadeRGB[0] = lbl_titulo.ForeColor.R;
                fadeRGB[1] = lbl_titulo.ForeColor.G;
                fadeRGB[2] = lbl_titulo.ForeColor.B;

            if (fadeRGB[0] > this.BackColor.R)
                    fadeRGB[0]--;
            else if (fadeRGB[0] < this.BackColor.R)
                    fadeRGB[0]++;
                if (fadeRGB[1] > this.BackColor.G)
                    fadeRGB[1]--;
                else if (fadeRGB[1] < this.BackColor.G)
                    fadeRGB[1]++;
                if (fadeRGB[2] > this.BackColor.B)
                    fadeRGB[2]--;
                else if (fadeRGB[2] < this.BackColor.B)
                    fadeRGB[2]++;
                if (fadeRGB[0] == this.BackColor.R && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
                 

                lbl_titulo.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            }
        void fadeIn()
        {
            fadeRGB[0] = lbl_titulo.ForeColor.R;
            fadeRGB[1] = lbl_titulo.ForeColor.G;
            fadeRGB[2] = lbl_titulo.ForeColor.B;

            if (fadeRGB[0] > this.targetColor[0])
                fadeRGB[0]--;
            else if (fadeRGB[0] < this.targetColor[0])
                fadeRGB[0]++;
            if (fadeRGB[1] > this.targetColor[1])
                fadeRGB[1]--;
            else if (fadeRGB[1] < this.targetColor[1])
                fadeRGB[1]++;
            if (fadeRGB[2] > this.targetColor[2])
                fadeRGB[2]--;
            else if (fadeRGB[2] < this.targetColor[2])
                fadeRGB[2]++;
            if (fadeRGB[0] == this.targetColor[0] && fadeRGB[1] == this.targetColor[2] && fadeRGB[2] == this.targetColor[2])
                timer1.Stop();

            lbl_titulo.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.Hide();
                Form form = new Historinha();
                form.Closed += (s, args) => this.Close();
                form.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Historinha historinhaForm = new Historinha();
            ConfigVideo configVideoForm = new ConfigVideo(this.historinhaForm);

        }
    }
}

    


