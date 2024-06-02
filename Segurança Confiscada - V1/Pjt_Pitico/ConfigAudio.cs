using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pjt_Pitico
{
    public partial class ConfigAudio : Form
    {
        WindowsMediaPlayer player1;
        WindowsMediaPlayer player2;

        public ConfigAudio()
        {
            InitializeComponent();

        }

        private void ConfigAudio_Load(object sender, EventArgs e)
        {

        }

        private void lbl_config_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            player1.settings.volume = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            player2.settings.volume = trackBar2.Value;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
