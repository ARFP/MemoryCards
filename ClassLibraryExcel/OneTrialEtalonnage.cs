using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExcel
{
    public struct OneTrialEtalonnage
    {
        private string trial;
        private string averageMove;
        private string sDMove;
        private string averageRepeat;
        private string sDRepeat;
        private string averageScore;
        private string sDScore;

        public string Trial { get => trial; set => trial = value; }
        public string AverageMove { get => averageMove; set => averageMove = value; }
        public string SDMove { get => sDMove; set => sDMove = value; }
        public string AverageRepeat { get => averageRepeat; set => averageRepeat = value; }
        public string SDRepeat { get => sDRepeat; set => sDRepeat = value; }
        public string AverageScore { get => averageScore; set => averageScore = value; }
        public string SDScore { get => sDScore; set => sDScore = value; }
    }
}
