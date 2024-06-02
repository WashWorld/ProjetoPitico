using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using NAudio;
using System.IO;
using System.Net;
using NAudio.Wave;
using Pjt_Pitico.Properties;

namespace Pjt_Pitico
{
    public partial class EscolhaFase : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string audioFilePath;
        private Image animatedImage;
        private Timer animationTimer;
        // Velocidade de movimento do personagem (em pixels por tick)
        private int velocidade = 1000;
        private int jumpHeight = 50; // Altura do pulo
        private int jumpSpeed = 5; // Velocidade do pulo
        private int jumpCount = 0;
        private bool goingUp = false;
        private Timer timer; 
        private bool spaceKeyPressed = false;
        private bool isJumping = false;
        public EscolhaFase()
        {
            InitializeComponent();
            InitializeTimer();
            this.KeyPreview = true;  // Permite que o formulário capture eventos de teclado
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);

        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 30; // Intervalo em milissegundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (spaceKeyPressed)
            {
                if (goingUp)
                {
                    pictureBox1.Top -= jumpSpeed;
                    jumpCount += jumpSpeed;
                    if (jumpCount >= jumpHeight)
                    {
                        goingUp = false;
                        jumpCount = 0;
                    }
                }
                else
                {
                    pictureBox1.Top += jumpSpeed;
                    jumpCount += jumpSpeed;
                    if (jumpCount >= jumpHeight)
                    {
                        goingUp = true;
                        jumpCount = 0;
                        spaceKeyPressed = false; // Redefine a variável para permitir outro salto
                        isJumping = false; // Define a variável de salto para false
                    }
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int moveStep = 5; // Define a quantidade de pixels a mover

            // Obter as bordas do formulário
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Obter a posição atual da PictureBox
            int currentLeft = pictureBox1.Left;
            int currentTop = pictureBox1.Top;
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;
            switch (e.KeyCode)
            {
                case Keys.W:
                    // Move para cima, garantindo que não saia da borda superior
                    if (currentTop - moveStep >= 0)
                    {
                        pictureBox1.Top -= moveStep;
                        pictureBox1.Image = Properties.Resources.pitico_andando_de_costas__1_;
                    }
                    break;
                case Keys.S:
                    // Move para baixo, garantindo que não saia da borda inferior
                    if (currentTop + moveStep + pictureBoxHeight <= formHeight)
                    {
                        pictureBox1.Top += moveStep;
                        pictureBox1.Image = Properties.Resources.pitico_walk__1_;
                    }
                    break;
                case Keys.A:
                    // Move para a esquerda, garantindo que não saia da borda esquerda
                    if (currentLeft - moveStep >= 0)
                    {
                        pictureBox1.Left -= moveStep;
                        pictureBox1.Image = Properties.Resources.pitico_andando_pra_esquerda__1_;
                    }
                    break;
                case Keys.D:
                    // Move para a direita, garantindo que não saia da borda direita
                    if (currentLeft + moveStep + pictureBoxWidth <= formWidth)
                    {
                        pictureBox1.Left += moveStep;
                        pictureBox1.Image = Properties.Resources.pitico_andando_pra_direita__1_;
                    }
                    break;
            }
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                spaceKeyPressed = true;
                isJumping = true;
            }
        }


           
              

        private void EscolhaFase_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string videoUrl = "https://www.youtube.com/watch?v=M7CTQ7OeqCg"; // Substitua pelo URL do vídeo do YouTube

            // Marca o tempo de início do download
            var startTime = DateTime.Now;

          
        
            try
            {
                // Baixa o áudio do YouTube
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(videoUrl);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                var audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                if (audioStreamInfo != null)
                {
                    string folderPath = @"C:\audio"; // Substitua pelo diretório desejado
                    string fileName = $"{video.Id}.mp3"; // Nome do arquivo será o ID do vídeo com extensão .mp3
                    string filePath = Path.Combine(folderPath, fileName);

                  await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, filePath);
                    PlayAudio(filePath);
                    // Calcula o tempo decorrido
                    var elapsedTime = DateTime.Now - startTime;
                    Console.WriteLine($"Tempo total para download: {elapsedTime.TotalMilliseconds} ms");
                }
                else
                {
                    MessageBox.Show("Nenhum stream de áudio encontrado para este vídeo.");
                }
            }
            catch (Exception ex)
            {
                // Se ocorrer um erro, imprime a mensagem de erro
                Console.WriteLine($"Erro ao baixar ou reproduzir o áudio: {ex.Message}");
                MessageBox.Show("Erro ao baixar ou reproduzir o áudio: " + ex.Message);
            }
        }

        private void PlayAudio(string filePath)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Libera os recursos ao fechar o formulário
            outputDevice?.Dispose();
            audioFile?.Dispose();
            base.OnFormClosing(e);

            // Não é necessário deletar o arquivo, pois ele é salvo em um local específico definido pelo código
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}    
    