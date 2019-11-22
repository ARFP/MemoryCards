using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelTrial : ObservableObject
    {
        private Trial trial;
        public List<ViewModelCard> ListCards;
        public int TrialNumber { get { return trial.TrialNumber; } set { trial.TrialNumber = value; OnPropertyChanged(nameof(TrialNumber)); } }
        public string TypeTest { get { return trial.TypeTest; } set { trial.TypeTest = value; OnPropertyChanged(nameof(TypeTest)); } }
        public int NumberCards { get { return trial.NumberCards; } set { trial.NumberCards = value; OnPropertyChanged(nameof(NumberCards)); } }
        public bool Sound { get { return trial.Sound; } set { trial.Sound = value; OnPropertyChanged(nameof(Sound)); } }
        public bool Shuffle { get { return trial.Shuffle; } set { trial.Shuffle = value; OnPropertyChanged(nameof(Shuffle)); } }
        public int Move { get { return trial.Move; } set { trial.Move = value; OnPropertyChanged(nameof(Move)); } }
        public int Repeat { get { return trial.Repeat; } set { trial.Repeat = value; OnPropertyChanged(nameof(Repeat)); } }

        public ViewModelTrial(Trial _trial)
        {
            trial = _trial;
            ListCards = new List<ViewModelCard>();
            foreach(Card c in trial.ListCards)
            {
                ListCards.Add(new ViewModelCard(c));
            }
        }

        public void AddMove()
        {
            trial.AddMove();
        }

        public void AddRepeat()
        {
            trial.AddRepeat();
        }

        public bool TrialFinish()
        {
            return trial.TrialFinish();
        }
    }
}
