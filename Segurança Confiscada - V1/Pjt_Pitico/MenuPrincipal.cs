// Form1.cs
using System;
using System.Windows.Forms;

namespace Pjt_Pitico
{
    public partial class Menu : Form
    {
        private Historinha historinhaForm;
        private bool radioButtonInglesCheckedState;
        private bool radioButtonPortuguesCheckedState;
        private bool primeiravisita = true; // 

        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_opcoes_Click(object sender, EventArgs e)
        {

            Configuracoes configuracoes = new Configuracoes();


            if (!primeiravisita)
            {
                configuracoes.SetRadioButtonStates(radioButtonInglesCheckedState, radioButtonPortuguesCheckedState);
            }

            configuracoes.RadioButtonInglesChanged += Configuracoes_RadioButtonInglesChanged;
            configuracoes.RadioButtonPortuguesChanged += Configuracoes_RadioButtonPortuguesChanged;

            // Mostra o formulário de configurações
            configuracoes.ShowDialog();
        }

        // Método chamado quando o RadioButton de inglês é alterado no formulário de configurações
        private void Configuracoes_RadioButtonInglesChanged(object sender, bool isChecked)
        {
            // Armazena o estado do RadioButton de inglês
            radioButtonInglesCheckedState = isChecked;


            if (isChecked)
            {
                btn_Iniciar.Text = "Start";
                btn_opcoes.Text = "Options";
                btn_creditos.Text = "Credits";
                btn_sair.Text = "Exit";
            }
        }

        // Método chamado quando o RadioButton de português é alterado no formulário de configurações
        private void Configuracoes_RadioButtonPortuguesChanged(object sender, bool isChecked)
        {
            // Armazena o estado do RadioButton de português
            radioButtonPortuguesCheckedState = isChecked;

            // Realiza ações com base no estado do RadioButton
            if (isChecked)
            {
                btn_Iniciar.Text = "Iniciar";
                btn_opcoes.Text = "Opções";
                btn_creditos.Text = "Créditos";
                btn_sair.Text = "Sair";
            }
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Creditos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Iniciar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Inicio();
            form.Closed += (s, args) => this.Close();
            form.Show();

            Historinha historinhaForm = new Historinha();
            ConfigVideo configVideoForm = new ConfigVideo(this.historinhaForm);

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            if (primeiravisita)
            {
                radioButtonInglesCheckedState = true;
                radioButtonPortuguesCheckedState = false;
                primeiravisita = false;
            }
        }
    }
}






