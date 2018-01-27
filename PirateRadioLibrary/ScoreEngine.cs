using PirateRadioLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PirateRadioLibrary
{
    public class ScoreEngine
    {
        private const double GROWTHRATEPERSECOND = 5;
        private const double DEADAIRGRACEPERIODINSECONDS = 3;
        private const double DEADAIRDEDUCTIONRATEPERSECOND = 3;

        private DateTime _startTime;
        private DateTime _previousUpdateTime;
        private bool _transmitting;
        private DateTime _transmittionStopedTime;

        public double CurrentScore { get; set; }
        public TimeSpan CurrentGameTime { get; set; }
        public double CurrentScoreRate { get; set; }

        public TapePlayer TapePlayer { get; set; }
        public Aerial Aerial { get; set; }
        public Radio Radio { get; set; }
        public PowerSwitch PowerSwitch { get;set;}
        public Shutters Shutters { get; set; }

        public ScoreEngine()
        {
            Reset();
        }

        public void Reset()
        {
            TapePlayer = new TapePlayer { Playing = true };
            Aerial = new Aerial { Extended = true };
            Radio = new Radio { ClearSignal = true };
            PowerSwitch = new PowerSwitch { On = true };
            Shutters = new Shutters { Open = true };

            CurrentScore = 0;
            CurrentScoreRate = 0;
            _startTime = DateTime.Now;
            _previousUpdateTime = DateTime.Now;
        }

        public void Start()
        {
            _startTime = DateTime.Now;
            _previousUpdateTime = DateTime.Now;
        }

        public void Update()
        {
            CalculateCurrentScore();
        }

        private void CalculateCurrentScore()
        {
            var now = DateTime.Now;
            var diff = now - _previousUpdateTime;
            var previousScore = CurrentScore;

            // Base Score Change - only if transmitting
            if (PowerSwitch.On && Shutters.Open && Aerial.Extended && TapePlayer.Playing)
            {
                _transmitting = true;
                CurrentScore += diff.TotalSeconds * GROWTHRATEPERSECOND;
            }
            else
            {
                if (_transmitting == true)
                {
                    _transmittionStopedTime = now;
                    _transmitting = false;
                }
            }

            // Dead air detractors
            if(!_transmitting && (now - _transmittionStopedTime).TotalSeconds > DEADAIRGRACEPERIODINSECONDS)
            {
                CurrentScore += ((now - _transmittionStopedTime).TotalSeconds - DEADAIRGRACEPERIODINSECONDS) * (DEADAIRDEDUCTIONRATEPERSECOND * -1) ;
            }

            // Interference detractors

            // Tape cut off early detractors

            // Same old music detractors

            // Figure out rate
            CurrentScoreRate = CurrentScore - previousScore;

            // Can't have minus listeners
            if(CurrentScore < 0)
            {
                CurrentScore = 0;
                CurrentScoreRate = 0;
            }

            // Update times
            _previousUpdateTime = now;
            CurrentGameTime = now - _startTime;
        }

    }
}
