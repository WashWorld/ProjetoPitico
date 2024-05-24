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
    // Form1.cs
    public partial class Menu : Form
    {
        public EventHandler<bool> Form1_RadioButtonPortuguesChanged { get; private set; }

        public Menu()
        {
            InitializeComponent();
        }

        private void btn_opcoes_Click(object sender, EventArgs e)
        {
            // Cria uma instância de Configuracoes
            Configuracoes configuracoes = new Configuracoes();

           
            configuracoes.RadioButtonInglesChanged += Form1_RadioButtonInglesChanged;
            configuracoes.RadioButtonPortuguesChanged += Form1_RadioButtonPortuguesChanged;

            // Mostra o formulário de configurações
            configuracoes.Show();
        }

      
        private void Form1_RadioButtonInglesChanged(object sender, bool isChecked)
        {
            // Realize ações com base no estado do RadioButton
            if (isChecked)
            {
                btn_Iniciar.Text = "Start";
                btn_opcoes.Text = "Options";
                btn_creditos.Text = "Credits";
                btn_sair.Text = "Exit";
            }
            else 
            {
                btn_Iniciar.Text = "Iniciar";
          btn_opcoes.Text = "Opções";
            btn_creditos.Text = "Créditos";
            btn_sair.Text = "Sair";
        }

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
    
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


        }
    }
}



