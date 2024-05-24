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
    public partial class Historinha : Form
    {
        public Historinha()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            button2.Visible = false;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.CanSelect)
                pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.CanSelect)
                pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }
    }
}
