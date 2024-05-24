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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void lbl_creditos_Click(object sender, EventArgs e)
        {

        }
    }
}
