using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExcel
{
    public struct OneRangeAgeEtalonnage
    {
        private string ageRange;
        private string numberPersoneTest;
        private string averageAge;
        private string sDAge;

        public string AgeRange { get => ageRange; set => ageRange = value; }
        public string NumberPersoneTest { get => numberPersoneTest; set => numberPersoneTest = value; }
        public string AverageAge { get => averageAge; set => averageAge = value; }
        public string SDAge { get => sDAge; set => sDAge = value; }
    }
}
