using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sEtalonnage
    {
        private int trial;
        private double averageMove;
        private double sDMove;
        private double averageRepeat;
        private double sDRepeat;
        private double averageScore;
        private double sDScore;

        public int Trial { get => trial; set => trial = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double SDMove { get => sDMove; set => sDMove = value; }
        public double AverageRepeat { get => averageRepeat; set => averageRepeat = value; }
        public double SDRepeat { get => sDRepeat; set => sDRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
        public double SDScore { get => sDScore; set => sDScore = value; }
    }
}
