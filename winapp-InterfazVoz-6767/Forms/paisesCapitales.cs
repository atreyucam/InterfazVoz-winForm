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
    public partial class paisesCapitales : Form
    {
        public paisesCapitales()
        {
            InitializeComponent();
            countryImg.Size = new Size(174, 130);
            iconMicrophone.Visible = false;
        }

        SpeechRecognitionEngine engine = new SpeechRecognitionEngine();

        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Ecuador":
                    inputPais.Text = "Ecuador";
                    outputCapital.Text = "Quito";
                    countryImg.Image = Properties.Resources.ecuador;
                    break;
                case "Venezuela":
                    inputPais.Text = "Venezuela";
                    outputCapital.Text = "Caracas";
                    countryImg.Image = Properties.Resources.venezuela;
                    break;
                case "Colombia":
                    inputPais.Text = "Colombia";
                    outputCapital.Text = "Bogotá";
                    countryImg.Image = Properties.Resources.colombia;
                    break;
                case "Perú":
                    inputPais.Text = "Perú";
                    outputCapital.Text = "Lima";
                    countryImg.Image = Properties.Resources.peru;
                    break;
                case "Bolivia":
                    inputPais.Text = "Bolivia";
                    outputCapital.Text = "Sucre";
                    countryImg.Image = Properties.Resources.bolivia;
                    break;
                case "Chile":
                    inputPais.Text = "Chile";
                    outputCapital.Text = "Santiago";
                    countryImg.Image = Properties.Resources.chile;
                    break;
                case "Argentina":
                    inputPais.Text = "Argentina";
                    outputCapital.Text = "Buenos Aires";
                    countryImg.Image = Properties.Resources.argentina;
                    break;
                case "Paraguay":
                    inputPais.Text = "Paraguay";
                    outputCapital.Text = "Asunción";
                    countryImg.Image = Properties.Resources.paraguay;
                    break;
                case "Uruguay":
                    inputPais.Text = "Uruguay";
                    outputCapital.Text = "Montevideo";
                    countryImg.Image = Properties.Resources.uruguay;
                    break;
                case "Guayana":
                    inputPais.Text = "Guayana";
                    outputCapital.Text = "Georgetown";
                    countryImg.Image = Properties.Resources.guayana;
                    break;
                case "Surinam":
                    inputPais.Text = "Surinam";
                    outputCapital.Text = "Paramaribo";
                    countryImg.Image = Properties.Resources.surinam;
                    break;
                case "Brasil":
                    inputPais.Text = "Brasil";
                    outputCapital.Text = "Brasilia";
                    countryImg.Image = Properties.Resources.brasil;
                    break;
                default:
                    break;
            }
        }

        private void IniciarRecoPais_Click(object sender, EventArgs e)
        {
            iconMicrophone.Visible = true;
            IniciarRecoPais.BackColor = Color.FromArgb(220, 73, 85);
            Choices vocabulary = new Choices();
            vocabulary.Add(new string[]
            {
                "Ecuador", "Venezuela", "Colombia", "Perú", "Bolivia", "Chile",
                "Argentina", "Brasil", "Paraguay", "Uruguay", "Guayana", "Surinam"
            });
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(vocabulary);
            Grammar grammar = new Grammar(builder);

            engine.LoadGrammar(grammar);
            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);
            engine.SpeechRecognized += Engine_SpeechRecognized;
            
        }
    }
}
