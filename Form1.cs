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

namespace TextToSpeech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SpeechSynthesizer voice = new SpeechSynthesizer();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SpeakBtn_Click(object sender, EventArgs e)
        {
            
            voice.Volume = VolumeTrackBar.Value;
            voice.Rate = SpeedTrackBar.Value;

            if(PersonComboBox.Text == "Male")
            {
                voice.SelectVoiceByHints(VoiceGender.Male);
            }
            if (PersonComboBox.Text == "Female")
            {
                voice.SelectVoiceByHints(VoiceGender.Female);
            }
            
            voice.Speak(MaintextBox.Text);

        }
    }
}
