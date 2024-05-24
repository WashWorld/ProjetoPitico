using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pjt_Pitico
{
    // Configuracoes.cs
    public partial class Configuracoes : Form
    {
        // Define o evento RadioButtonInglesChanged
        public event EventHandler<bool> RadioButtonInglesChanged;
        public event EventHandler<bool> RadioButtonPortuguesChanged;

        public Configuracoes()
        {
            InitializeComponent();


            rdb_ingles.CheckedChanged += Rdb_ingles_CheckedChanged;
            rdb_portugues.CheckedChanged += rdb_portugues_CheckedChanged;

        }

        private void Rdb_ingles_CheckedChanged(object sender, EventArgs e)
        {
         
            RadioButtonInglesChanged?.Invoke(this, rdb_ingles.Checked);
            RadioButtonPortuguesChanged?.Invoke(this, rdb_ingles.Checked);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();

         
            

        }

        private void rkb_portugues_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rkb_ingles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_ingles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ingles.Checked == true) ;
            btn_audio.Text = ("Options Audio");
            btn_video.Text = ("Video Options");
            btn_controles.Text = ("Controls");
            btn_voltar.Text = ("Back");
            lbl_titulo.Text = ("Options");
            lbl_idioma.Text = ("Language");

           
        }

        private void rdb_portugues_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_portugues.Checked == true);
            btn_audio.Text = ("Opções de Áudio");
            btn_video.Text = ("Opções de Video");
            btn_controles.Text = ("Controles");
            btn_voltar.Text = ("Voltar");
            lbl_titulo.Text = ("Opções");
            lbl_idioma.Text = ("Idioma");

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }
    }
}
 
