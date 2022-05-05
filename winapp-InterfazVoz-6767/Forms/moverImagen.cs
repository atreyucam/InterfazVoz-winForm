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

namespace winapp_InterfazVoz_6767
{
    public partial class moverImagen : Form
    {
        public moverImagen()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine();

        private void moverImagen_Load(object sender, EventArgs e)
        {
            Choices vocabulary = new Choices();
            vocabulary.Add(new string[] { "arriba", "abajo", "izquierda", "derecha" });
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(vocabulary);
            Grammar grammar = new Grammar(builder);

            engine.LoadGrammarAsync(grammar);
            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);
            engine.SpeechRecognized += Engine_SpeechRecognized;
        }

        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "arriba":
                    pictureRuuner.Location = new Point(407, 25);
                    break;
                case "abajo":
                    pictureRuuner.Location = new Point(417, 428);
                    break;
                case "izquierda":
                    pictureRuuner.Location = new Point(57, 218);
                    break;
                case "derecha":
                    pictureRuuner.Location = new Point(713, 218);
                    break;
                default:
                    break;
            }
        }
    }
}
