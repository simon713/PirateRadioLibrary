using System;
using System.Collections.Generic;
using System.Text;

namespace PirateRadioLibrary.Models
{
    public class TapePlayer
    {
        public bool Playing { get; set; }
        public DateTime StartTime { get; set; }
        public Tape CurrentTape { get; set; }
    }
}
