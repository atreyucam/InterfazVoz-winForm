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
    public partial class lineasFiguras : Form
    {
        public lineasFiguras()
        {
            InitializeComponent();
            pictureFigura.Size = new Size(174, 130);
            pictureFigura.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMicrophone.Visible = false;
        }
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine(); 

        private void IniciarRecoFigura_Click(object sender, EventArgs e)
        {
            iconMicrophone.Visible = true;
            IniciarRecoFigura.BackColor = Color.FromArgb(220, 73, 85);
            Choices vocabulary = new Choices();
            vocabulary.Add(new string[]
            {
                //Lineas
                "Vertical", "Horizontal", "Diagonal", "Quebrada", "Ondulada", "Zig zag", "Curva",
                //Poligonos
                "Triangulo", "Cuadrilatero", "Pentagono", "Hexagono", "Heptagono", "Octagono",
                //Elipses
                "elipseVertical", "elipseHorizontal"
            });
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(vocabulary);
            Grammar grammar = new Grammar(builder);

            engine.LoadGrammar(grammar);
            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);
            engine.SpeechRecognized += Engine_SpeechRecognized;
        }

        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Vertical":
                    inputVoice.Text = "Vertical";
                    pictureFigura.Image = Properties.Resources.line;
                    break;
                case "Horizontal":
                    inputVoice.Text = "Horizontal";
                    pictureFigura.Image = Properties.Resources.minus_horizontal_straight_line;
                    break;
                case "Diagonal":
                    inputVoice.Text = "Diagonal";
                    pictureFigura.Image = Properties.Resources.diagonal_line;
                    break;
                case "Ondulada":
                    inputVoice.Text = "Ondulada";
                    pictureFigura.Image = Properties.Resources.agua;
                    break;
                case "Zig zag":
                    inputVoice.Text = "Zig zag";
                    pictureFigura.Image = Properties.Resources.bigote_en_zigzag;
                    break;
                case "Curva":
                    inputVoice.Text = "Curva";
                    pictureFigura.Image = Properties.Resources.linea_curva;
                    break;
                case "Triangulo":
                    inputVoice.Text = "Triangulo";
                    pictureFigura.Image = Properties.Resources.triangulo;
                    break;
                case "Cuadrilatero":
                    inputVoice.Text = "Cuadrilatero";
                    pictureFigura.Image = Properties.Resources.rectangulo;
                    break;
                case "Pentagono":
                    inputVoice.Text = "Pentagono";
                    pictureFigura.Image = Properties.Resources.pentagono;
                    break;
                case "Hexagono":
                    inputVoice.Text = "Hexagono";
                    pictureFigura.Image = Properties.Resources.hexagono;
                    break;
                case "Heptagono":
                    inputVoice.Text = "Heptagono";
                    pictureFigura.Image = Properties.Resources.heptagono;
                    break;
                case "Octagono":
                    inputVoice.Text = "Octagono";
                    pictureFigura.Image = Properties.Resources.octagono;
                    break;
                case "elipseVertical":
                    inputVoice.Text = "elipseVertical";
                    pictureFigura.Image = Properties.Resources.elipseVertical;
                    break;
                case "elipseHorizontal":
                    inputVoice.Text = "elipseHorizontal";
                    pictureFigura.Image = Properties.Resources.elipseHorizontal;
                    break;
                default:
                    break;
            }
        }
    }
}
