using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelEtalonnage : ObservableObject
    {
        private Etalonnage etalonnage;

        public string NumberTrial { get { return etalonnage.NumberTrial; } set { etalonnage.NumberTrial = value; OnPropertyChanged(nameof(NumberTrial)); } }
        public double AverageMove { get { return etalonnage.AverageMove; } set { etalonnage.AverageMove = value; OnPropertyChanged(nameof(AverageMove)); } }
        public double SDMove { get { return etalonnage.SDMove; } set { etalonnage.SDMove = value; OnPropertyChanged(nameof(SDMove)); } }
        public double AverageRepeat { get { return etalonnage.AverageRepeat; } set { etalonnage.AverageRepeat = value; OnPropertyChanged(nameof(AverageRepeat)); } }
        public double SDRepeat { get { return etalonnage.SDRepeat; } set { etalonnage.SDRepeat = value; OnPropertyChanged(nameof(SDRepeat)); } }
        public double AverageScore { get { return etalonnage.AverageScore; } set { etalonnage.AverageScore = value; OnPropertyChanged(nameof(AverageScore)); } }
        public double SDScore { get { return etalonnage.SDScore; } set { etalonnage.SDScore = value; OnPropertyChanged(nameof(SDScore)); } }

        public ViewModelEtalonnage(Etalonnage _etalonnage)
        {
            etalonnage = _etalonnage;
        }
    }
}
