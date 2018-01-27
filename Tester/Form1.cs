using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PirateRadioLibrary;

namespace Tester
{
    public partial class Form1 : Form
    {
        private ScoreEngine ScoreEngine;

        public Form1()
        {
            InitializeComponent();
            ScoreEngine = new ScoreEngine();
        }
        
        private void StartGame_Click(object sender, EventArgs e)
        {
            ScoreEngine.Start();
            timer1.Start();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ScoreEngine.Reset();

            _tapePlaying = false;
            TapePlaying.Checked = false;
            Interference.Checked = false;
            aerial.Checked = true;
            PowerSwitch.Checked = true;
        }
        
        private void PowerSwitch_CheckedChanged(object sender, EventArgs e)
        {
            ScoreEngine.PowerSwitchOn = PowerSwitch.Checked;
        }

        private void aerial_CheckedChanged(object sender, EventArgs e)
        {
            ScoreEngine.AerialExtended = aerial.Checked;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ScoreEngine.Update();
            Rate.Text = ScoreEngine.CurrentScoreRate.ToString();
            Score.Text = ScoreEngine.CurrentScore.ToString();
            Time.Text = ScoreEngine.CurrentGameTime.ToString();
        }

        private void Interference_CheckedChanged(object sender, EventArgs e)
        {
            ScoreEngine.RadioInterference = Interference.Checked;
        }

        private bool _tapePlaying = false;

        private void TapePlaying_CheckedChanged(object sender, EventArgs e)
        {
            if(_tapePlaying != TapePlaying.Checked)
            {
                if(TapePlaying.Checked)
                {
                    ScoreEngine.PlayTape("test");
                }
                else
                {
                    ScoreEngine.TapeStopped();
                }
            }

            _tapePlaying = TapePlaying.Checked;
        }
    }
}
