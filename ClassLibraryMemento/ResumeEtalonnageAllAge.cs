using ClassLibraryIPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class ResumeEtalonnageAllAge
    {
        private string ageRange;
        private int numberPersoneTest;
        private double averageAge;
        private double sDAge;

        public string AgeRange { get => ageRange; set => ageRange = value; }
        public int NumberPersoneTest { get => numberPersoneTest; set => numberPersoneTest = value; }
        public double AverageAge { get => averageAge; set => averageAge = value; }
        public double SDAge { get => sDAge; set => sDAge = value; }

        public ResumeEtalonnageAllAge(string _ageRange, int _numberPersoneTest, double _avergaeAge, double _sDAge)
        {
            ageRange = _ageRange;
            numberPersoneTest = _numberPersoneTest;
            averageAge = _avergaeAge;
            sDAge = _sDAge;
        }

        public static implicit operator sResumeEtalonnageAllAge(ResumeEtalonnageAllAge _resumeEtalonnageAllAge)
        {
            return new sResumeEtalonnageAllAge()
            {
                AgeRange = _resumeEtalonnageAllAge.ageRange,
                NumberPersoneTest = _resumeEtalonnageAllAge.numberPersoneTest,
                AverageAge = _resumeEtalonnageAllAge.averageAge,
                SDAge = _resumeEtalonnageAllAge.sDAge
            };
        }

        public static implicit operator ResumeEtalonnageAllAge(sResumeEtalonnageAllAge _sResumeEtalonnageAllAge)
        {
            return new ResumeEtalonnageAllAge
            (
                _sResumeEtalonnageAllAge.AgeRange,
                _sResumeEtalonnageAllAge.NumberPersoneTest,
                _sResumeEtalonnageAllAge.AverageAge,
                _sResumeEtalonnageAllAge.SDAge
            );
        }
    }
}
