using System;
using System.Windows.Forms;

namespace Pjt_Pitico
{
    public partial class Configuracoes : Form
    {
        private Historinha historinhaForm;
        private bool _inglesCheckedTemp;
        private bool _portuguesCheckedTemp;


        public event EventHandler<bool> RadioButtonInglesChanged;
        public event EventHandler<bool> RadioButtonPortuguesChanged;

        public Configuracoes()
        {
            InitializeComponent();

            rdb_ingles.CheckedChanged += Rdb_ingles_CheckedChanged;
            rdb_portugues.CheckedChanged += Rdb_portugues_CheckedChanged;
        }

        public void SetRadioButtonStates(bool inglesChecked, bool portuguesChecked)
        {
            rdb_ingles.Checked = inglesChecked;
            rdb_portugues.Checked = portuguesChecked;
        }

     
        private void Rdb_ingles_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonInglesChanged?.Invoke(this, rdb_ingles.Checked);
            RadioButtonPortuguesChanged?.Invoke(this, !rdb_ingles.Checked); 
        }

      
        private void Rdb_portugues_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonInglesChanged?.Invoke(this, !rdb_portugues.Checked); 
            RadioButtonPortuguesChanged?.Invoke(this, rdb_portugues.Checked);
        }


        public Configuracoes(Historinha historinha)
        {
            InitializeComponent();
            this.historinhaForm = historinha;
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
            Historinha historinhaForm = new Historinha();
            ConfigVideo configVideoForm = new ConfigVideo(this.historinhaForm);
       

        }
        private void rdb_ingles_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_ingles.Checked)
            {
                btn_audio.Text = "Audio Options";
                btn_video.Text = "Video Options";
                btn_controles.Text = "Controls";
                btn_voltar.Text = "Back";
                lbl_idioma.Text = "Language";
                lbl_titulo.Text = "Options";
            }
        }

        private void rdb_portugues_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_portugues.Checked)
            {
                btn_audio.Text = "Opções de Áudio";
                btn_video.Text = "Opções de Video";
                btn_controles.Text = "Controles";
                btn_voltar.Text = "Voltar";
                lbl_idioma.Text = "Idioma";
                lbl_titulo.Text = "Opções";
            }
        }


        private void btn_audio_Click(object sender, EventArgs e)
        {
    
            _inglesCheckedTemp = rdb_ingles.Checked;
            _portuguesCheckedTemp = rdb_portugues.Checked;

            Form novoFormulario = new ConfigAudio();
            novoFormulario.FormClosed += NovoFormulario_FormClosed; 
            novoFormulario.Show();
        }

    
        private void NovoFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {

            rdb_ingles.Checked = _inglesCheckedTemp;
            rdb_portugues.Checked = _portuguesCheckedTemp;
        }


        private void btn_video_Click(object sender, EventArgs e)
        {
            Historinha historinhaForm = new Historinha();
            ConfigVideo configVideoForm = new ConfigVideo(historinhaForm);
            configVideoForm.Show();
        }


        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }
    }
}




