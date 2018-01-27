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
        }

        private void Play_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PowerSwitch_CheckedChanged(object sender, EventArgs e)
        {
            ScoreEngine.PowerSwitchOn = PowerSwitch.Checked;
        }

        private void aerial_CheckedChanged(object sender, EventArgs e)
        {
            ScoreEngine.AerialExtended = aerial.Checked;
        }

        private void tape1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tape2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tape3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tape4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tape5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScoreEngine.Update();
            Rate.Text = ScoreEngine.CurrentScoreRate.ToString();
            Score.Text = ScoreEngine.CurrentScore.ToString();
            Time.Text = ScoreEngine.CurrentGameTime.ToString();
        }

        private void ShuttersOpen_CheckedChanged(object sender, EventArgs e)
        {
            ScoreEngine.ShuttersOpen = ShuttersOpen.Checked;
        }
    }
}
