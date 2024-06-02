using AngleSharp.Io;
using AxWMPLib;
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
    public partial class CutscenePiticoPuxado : Form
    {
        public CutscenePiticoPuxado()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite que o formulário capture eventos de teclado
            this.KeyPress += new KeyPressEventHandler(FormVideoPlayer_KeyPress);
        }
        private void FormVideoPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PlayVideo();
            }
        }
        private void PlayVideo()
        {
            if (axWindowsMediaPlayer2.URL == string.Empty)
            {
                // Especificar o caminho do vídeo
                axWindowsMediaPlayer2.URL = "C:\\Users\\rafae\\Downloads/lv_0_20240506003910.mp4"; // Substitua pelo caminho do seu vídeo
            }

            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void FormVideoPlayer_Load(object sender, EventArgs e)
        {
            // Configure o caminho do vídeo aqui ou em outro lugar apropriado
            axWindowsMediaPlayer2.URL = "C:\\Users\\rafae\\Downloads/lv_0_20240506003910.mp4";// Substitua pelo caminho do seu vídeo
        }

    private void axWindowsMediaPlayer2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
    {
        // Verifique se o estado é 'MediaEnded'
        if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
        {
            // Vídeo terminou, abra o próximo formulário
            Form proximoFormulario = new EscolhaFase();
            proximoFormulario.Show();
            this.Close();
        }

        }
    }
}