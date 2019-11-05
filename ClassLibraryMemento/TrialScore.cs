using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public struct TrialScore
    {
        private int trialNumber;
        private string typeTest;
        private int numberCards;
        private bool sound;
        private bool shuffle;
        private int move;
        private int repeat;
        private double scoreTrial;

        public int TrialNumber { get => trialNumber; set => trialNumber = value; }
        public string TypeTest { get => typeTest; set => typeTest = value; }
        public int NumberCards { get => numberCards; set => numberCards = value; }
        public bool Sound { get => sound; set => sound = value; }
        public bool Shuffle { get => shuffle; set => shuffle = value; }
        public int Move { get => move; set => move = value; }
        public int Repeat { get => repeat; set => repeat = value; }
        public double ScoreTrial { get => scoreTrial; set => scoreTrial = value; }
    }
}