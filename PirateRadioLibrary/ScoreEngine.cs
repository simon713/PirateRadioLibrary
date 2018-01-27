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

        private const double POLICEGRACEPERIODINSECONDS = 10;
        private const double POLICEDEDUCTIONRATEPERSECOND = 3;

        private const double RADIOINTERFERENCEGRACEPERIODINSECONDS = 3;
        private const double RADIOINTERFERENCEDEDUCTIONRATEPERSECOND = 3;


        private DateTime _startTime;
        private DateTime _previousUpdateTime;
        
        public double CurrentScore { get; set; }
        public TimeSpan CurrentGameTime { get; set; }
        public double CurrentScoreRate { get; set; }

        private bool _tapePlayerPlaying;
        private DateTime _tapePlayerOffTime;
        private bool TapePlayerPlaying { get { return _tapePlayerPlaying; } set { if (_tapePlayerPlaying && !value) { _tapePlayerOffTime = DateTime.Now; } _tapePlayerPlaying = value; } }

        public void PlayTape(string name)
        {
            TapePlayerPlaying = true;
        }

        public void TapeStopped()
        {
            TapePlayerPlaying = false;
        }

        private bool _radioInterference;
        private DateTime _radioInterferenceTime;
        public bool RadioInterference { get { return _radioInterference; } set { if (!_radioInterference && value) { _radioInterferenceTime = DateTime.Now; } _radioInterference = value; } }

        private DateTime _policeOffTime;
        private bool _aerialExtended;
        public bool AerialExtended
        {
            get { return _aerialExtended; }
            set {
                if (_powerSwitchOn && _shuttersOpen && _aerialExtended && !value)
                {
                    _policeOffTime = DateTime.Now;
                }
                _aerialExtended = value;
            }
        }
        private bool _powerSwitchOn;
        public bool PowerSwitchOn
        {
            get { return _powerSwitchOn; }
            set
            {
                if (_powerSwitchOn && _shuttersOpen && _aerialExtended && !value)
                {
                    _policeOffTime = DateTime.Now;
                }
                _powerSwitchOn = value;
            }
        }
        private bool _shuttersOpen;
        public bool ShuttersOpen
        {
            get { return _shuttersOpen; }
            set
            {
                if (_powerSwitchOn && _shuttersOpen && _aerialExtended && !value)
                {
                    _policeOffTime = DateTime.Now;
                }
                _shuttersOpen = value;
            }
        }

        public ScoreEngine()
        {
            Reset();
        }

        public void Reset()
        {
            TapePlayerPlaying = true;
            AerialExtended = true ;
            RadioInterference = false;
            PowerSwitchOn = true;
            ShuttersOpen = true;

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
            if (PowerSwitchOn && ShuttersOpen && AerialExtended && TapePlayerPlaying)
            {
                CurrentScore += diff.TotalSeconds * GROWTHRATEPERSECOND;
            }
            
            // police detractors
            if((!PowerSwitchOn || !ShuttersOpen || !AerialExtended) && (now - _policeOffTime).TotalSeconds > POLICEGRACEPERIODINSECONDS)
            {
                CurrentScore += diff.TotalSeconds * (POLICEDEDUCTIONRATEPERSECOND * -1) ;
            }

            // Dead air/tape-off detractors
            if (!TapePlayerPlaying && (now - _tapePlayerOffTime).TotalSeconds > DEADAIRGRACEPERIODINSECONDS)
            {
                CurrentScore += diff.TotalSeconds * (DEADAIRDEDUCTIONRATEPERSECOND * -1);
            }

            // Interference detractors
            if (_radioInterference && (now - _radioInterferenceTime).TotalSeconds > RADIOINTERFERENCEGRACEPERIODINSECONDS)
            {
                CurrentScore += diff.TotalSeconds * (RADIOINTERFERENCEDEDUCTIONRATEPERSECOND * -1);
            }
            
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
