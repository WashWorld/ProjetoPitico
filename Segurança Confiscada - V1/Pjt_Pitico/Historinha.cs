using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Pjt_Pitico
{
    public partial class Historinha : Form
    {
        private List<string> textos1 = new List<string> { "→ Oi mãe, o professor liberou minha sala mais cedo!", "Que bom meu filho mas, cadê seu irmão? ele não veio com você?", "→Ele disse que ia na casa do amigo dele e depois iria voltar para casa.", "Entendi, só peço que preste atenção nele. Seu irmão está meio…mal…", "Eu entendo mãe, pode deixar…irei mexer um pouco no computador.", "Após o almoço, Pitico se dirige ao seu quarto, deixando suas coisas ao lado de sua cama e indo ligar seu computador. " };

        private List<string> textos2 = new List<string> { "→ Vamos lá, vou ver minhas tarefas da escola e depois jogar um pouco!", "\r\nPitico começa a fazer suas tarefas da escola e logo em seguida abre o stardew valley para cuidar da sua fazenda, quando de repente, seu pc dá erro e começa a aparecer um monte de anúncios que tomam conta da tela do pc. \r\n", " “Você acaba de ganhar 10 mil reais!  Clique no link abaixo agora!”", "CATAPIMBAS, isso seria ótimo", "Pitico escuta uma risada vindo do PC e um portal se abre a sua frente, surgindo um anzol de pesca o agarrando pela camisa e o puxando pra dentro do portal" };
    private List<string> textosAtual;
        private int indice = 0;


        public Historinha()
        {
            textosAtual = textos1;
            InitializeComponent();



        }

        private void Historinha_Load(object sender, EventArgs e)
        {
            string radioButtonState = Properties.Settings.Default.RadioButtonState;
            if (radioButtonState == "desligado")
            {
                textBox1.Visible = false; // Desativa a TextBox se o RadioButton estiver desligado
            }
            else
            {
                textBox1.Visible = true; // Ativa a TextBox caso contrário
            }
       

        }


         
            
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Opacity += .2;
        }

        private void pcb_imagem1_Click(object sender, EventArgs e)
        {

        }

 

   

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String rota = "C:\\Users\\gabri\\Downloads/lv_0_20240505171610.mp4";
            axWindowsMediaPlayer1.URL = rota;

            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

  

        private void button4_Click(object sender, EventArgs e)
        {
            if (btn_iniciar.CanSelect)
            {
                String rota = "C:\\Users\\gabri\\Downloads/lv_0_20240505171610.mp4";
                axWindowsMediaPlayer1.URL = rota;
                btn_iniciar.Visible = false;
                btn_cont.Visible = true; ;
                textBox1.Text = "Pitico chega em casa cansado depois de um longo dia estudando e vai direto à cozinha conversar com sua mãe que está preparando o almoço...";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            String rota = "C:\\Users\\gabri\\Downloads/lv_0_20240505212541.mp4";
            axWindowsMediaPlayer1.URL = rota;
            btn_cont.Visible = false;

            textBox1.Text = "Após o almoço, Pitico se dirige ao seu quarto, deixando suas coisas ao lado de sua cama e indo ligar seu computador, logo abre suas redes sociais para conversar com seus amigos";
            btn_ultimo.Visible = true;
    
   
           
        }
    


    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Historinha_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          EscolhaFase sForm = new EscolhaFase();
            sForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormANUNCIO nform = new FormANUNCIO();
            nform.Show();

        }


        private void btn_anuncio_Click(object sender, EventArgs e)
        {
            
        }
    }
}















