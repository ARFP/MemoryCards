using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sResumeEtalonnageAllAge
    {
        private string ageRange;
        private int numberPersoneTest;
        private double averageAge;
        private double sDAge;

        public string AgeRange { get => ageRange; set => ageRange = value; }
        public int NumberPersoneTest { get => numberPersoneTest; set => numberPersoneTest = value; }
        public double AverageAge { get => averageAge; set => averageAge = value; }
        public double SDAge { get => sDAge; set => sDAge = value; }
    }
}
