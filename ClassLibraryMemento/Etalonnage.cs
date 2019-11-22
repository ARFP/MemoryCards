using ClassLibraryIPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Etalonnage
    {
        private string numberTrial;
        private double averageMove;
        private double sDMove;
        private double averageRepeat;
        private double sDRepeat;
        private double averageScore;
        private double sDScore;

        public string NumberTrial { get => numberTrial; set => numberTrial = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double SDMove { get => sDMove; set => sDMove = value; }
        public double AverageRepeat { get => averageRepeat; set => averageRepeat = value; }
        public double SDRepeat { get => sDRepeat; set => sDRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
        public double SDScore { get => sDScore; set => sDScore = value; }

        public Etalonnage(string _numberTrial, double _averageMove, double _sDMove, double _averageRepeat, double _sDRepeat, double _averageScore, double _sDScore)
        {
            numberTrial = _numberTrial;
            averageMove = _averageMove;
            sDMove = _sDMove;
            averageRepeat = _averageRepeat;
            sDRepeat = _sDRepeat;
            averageScore = _averageScore;
            sDScore = _sDScore;
        }

        public static implicit operator sEtalonnage(Etalonnage _etalonnage)
        {
            return new sEtalonnage()
            {
                NumberTrial = _etalonnage.NumberTrial,
                AverageMove = _etalonnage.AverageMove,
                SDMove = _etalonnage.SDMove,
                AverageRepeat = _etalonnage.AverageRepeat,
                SDRepeat = _etalonnage.SDRepeat,
                AverageScore = _etalonnage.AverageScore,
                SDScore = _etalonnage.SDScore,
            };
        }

        public static implicit operator Etalonnage(sEtalonnage _sEtalonnage)
        {
            return new Etalonnage
            (
                _sEtalonnage.NumberTrial,
                _sEtalonnage.AverageMove,
                _sEtalonnage.SDMove,
                _sEtalonnage.AverageRepeat,
                _sEtalonnage.SDRepeat,
                _sEtalonnage.AverageScore,
                _sEtalonnage.SDScore
            );
        }
    }
}
