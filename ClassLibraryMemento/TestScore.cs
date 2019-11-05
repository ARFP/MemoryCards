using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public struct TestScore
    {
        private List<TrialScore> trialsScore;
        private double averageMove;
        private double avergaeRepeat;
        private double averageScore;

        public List<TrialScore> TrialsScore { get => trialsScore; set => trialsScore = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double AvergaeRepeat { get => avergaeRepeat; set => avergaeRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
    }
}
