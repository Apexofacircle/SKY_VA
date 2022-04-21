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



namespace Sky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bool Active = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            // speach to text
            SpeechRecognitionEngine recognizer =
             new SpeechRecognitionEngine(
             new System.Globalization.CultureInfo("en-US"));

            recognizer.LoadGrammar(new DictationGrammar());

            recognizer.SpeechRecognized +=
          new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            recognizer.SetInputToDefaultAudioDevice();

            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            
        }

        // Handle the SpeechRecognized event.  
        void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            TextRecognized.Text = e.Result.Text;

            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();

            
                synthesizer.Speak(e.Result.Text);
            
            
        }

        private void TextRecognized_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
