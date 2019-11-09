using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDialogExcel
{
    public class OneTrialEtalonnage
    {
        private string trial;
        private double averageMove;
        private double sDMove;
        private double averageReapeat;
        private double sDRepeat;
        private double averageScore;
        private double sDScore;

        public string Trial { get => trial; set => trial = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double SDMove { get => sDMove; set => sDMove = value; }
        public double AverageReapeat { get => averageReapeat; set => averageReapeat = value; }
        public double SDRepeat { get => sDRepeat; set => sDRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
        public double SDScore { get => sDScore; set => sDScore = value; }
    }
}
