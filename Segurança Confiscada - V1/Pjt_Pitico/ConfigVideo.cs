using Pjt_Pitico;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pjt_Pitico
{



public partial class ConfigVideo : Form
        {
            private Historinha historinhaForm;
            private bool ligadoChecked;
            private bool desligadoChecked;

            public ConfigVideo(Historinha historinha)
            {
                InitializeComponent();
                this.historinhaForm = historinha;

            Console.WriteLine("Instância de Historinha recebida: " + (historinha != null ? "Válida" : "Nula"));
        }
    

        public ConfigVideo()
        {
            InitializeComponent();
        }

        private void ConfigVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
      
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            
                // Verificar qual RadioButton está marcado
                if (rdb_ligado.Checked)
                {
                    AppConfig.RadioButtonState = "ligado";
                }
                else if (rdb_desligado.Checked)
                {
                    AppConfig.RadioButtonState = "desligado";
                }
                this.Hide();


            Configuracoes configuracoesForm = new Configuracoes(this.historinhaForm);
            configuracoesForm.Closed += (s, args) => this.Close();
            configuracoesForm.Show();

        }

        private void ConfigVideo_Load(object sender, EventArgs e)
        {
            // Carregar o estado inicial dos RadioButtons a partir das configurações
            string radioButtonState = AppConfig.RadioButtonState;
            if (radioButtonState == "ligado")
            {
                ligadoChecked = true;
                desligadoChecked = false;
            }
            else if (radioButtonState == "desligado")
            {
                desligadoChecked = true;
                ligadoChecked = false;
            }

            // Definir o estado dos RadioButtons com base nas variáveis carregadas
            rdb_ligado.Checked = ligadoChecked;
            rdb_desligado.Checked = desligadoChecked;
        }

        private void rdb_ligado_CheckedChanged(object sender, EventArgs e)

        {

        }



        private void rdb_desligado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_desligado.Checked)
            {
                Properties.Settings.Default.RadioButtonState = "desligado";
                Properties.Settings.Default.Save();
                    {
                    }

            }
              }
    }
}





