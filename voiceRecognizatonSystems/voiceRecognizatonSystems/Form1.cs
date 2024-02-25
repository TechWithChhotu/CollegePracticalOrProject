using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;


namespace voiceRecognizatonSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 10;
        }

        private void ClickToListen_Click(object sender, EventArgs e)
        {
            
            if (TextToSpeech.Text != "")
            {
                
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Volume = trackBar1.Value;
                synth.Speak(TextToSpeech.Text);
            }
            else
            {
                MessageBox.Show("Plz write something");
            }
        }

        private void ClickToSpeack_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine speech = new SpeechRecognitionEngine();
            Grammar word  = new DictationGrammar();
            speech.LoadGrammar(word);

            try
            {
                SpeechToText.Text = "Listening Now..............";
                speech.SetInputToDefaultAudioDevice();
                RecognitionResult result = speech.Recognize();
                SpeechToText.Clear();
                SpeechToText.Text = result.Text;
            }catch(Exception ex)
            {
                SpeechToText.Clear();
                MessageBox.Show(ex.Message);
            }finally { 
                speech.UnloadAllGrammars();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
        }
    }
}
