using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;

namespace winapp_InterfazVoz_6767
{
    public partial class outputVoice : Form
    {
        public outputVoice()
        {
            InitializeComponent();
            iconMicrophone.Visible = false;
        }
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine(); 

        private void IniciarReconocimiento_Click(object sender, EventArgs e)
        {
            iconMicrophone.Visible = true;
            IniciarReconocimiento.BackColor = Color.FromArgb(220, 73, 85);
            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammar(new DictationGrammar());
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconocimiento);
            engine.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                outputReconociemiento.Text += palabra.Text + " ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread salida = new Thread(new ParameterizedThreadStart(hablar));
            salida.Start(outputReconociemiento.Text);
        }

        private void hablar(object obj)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(obj.ToString());
        }
    }
}
