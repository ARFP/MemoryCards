using ClassLibraryIPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Trial
    {
        private List<Card> listCards;
        private int trialNumber;
        private string typeTest;
        private int numberCards;
        private bool sound;
        private bool shuffle;
        private int move;
        private int repeat;

        public List<Card> ListCards { get => listCards; set => listCards = value; }
        public int TrialNumber { get => trialNumber; set => trialNumber = value; }
        public string TypeTest { get => typeTest; set => typeTest = value; }
        public int NumberCards { get => numberCards; set => numberCards = value; }
        public bool Sound { get => sound; set => sound = value; }
        public bool Shuffle { get => shuffle; set => shuffle = value; }
        public int Move { get => move; set => move = value; }
        public int Repeat { get => repeat; set => repeat = value; }

        public Trial(string _typeTest, List<object> _card, int _trialNumber, bool _sound, bool _shuffle)
        {
            listCards = new List<Card>();
            AddCard(_card);
            trialNumber = _trialNumber;
            typeTest = _typeTest;
            numberCards = listCards.Count;
            sound = _sound;
            shuffle = _shuffle;
            move = 0;
            repeat = 0;
            ShuffleCards();
        }

        public Trial(Trial _trial, int _trailNumber)
        {
            listCards = new List<Card>();
            Clonecardlist(_trial.listCards);
            trialNumber = _trailNumber;
            typeTest = _trial.TypeTest;
            numberCards = _trial.NumberCards;
            sound = _trial.Sound;
            shuffle = false;
            move = 0;
            repeat = 0;
        }

        public static implicit operator sTrialScore(Trial _trial)
        {
            return new sTrialScore
            {
                TrialNumber = _trial.TrialNumber,
                TypeTest = _trial.TypeTest,
                NumberCards = _trial.NumberCards,
                Sound = _trial.Sound,
                Shuffle = _trial.Shuffle,
                Move = _trial.Move,
                Repeat = _trial.Repeat,
                ScoreTrial = _trial.ScoreTrial()
            };
        }

        public void AddCard(List<object> _image)
        {
            for (int i = 0; i < _image.Count; i++)
            {
                Card c = new Card(i.ToString(), (string)_image[i]);
                Card c1 = new Card(i.ToString(), (string)_image[i]);
                c.AddPairCard(c1);
                c1.AddPairCard(c);
                listCards.Add(c);
                listCards.Add(c1);
            }
        }

        private void Clonecardlist(List<Card> _cards)
        {
            foreach (Card c in _cards)
            {
                listCards.Add(new Card(c));
            }
            foreach (Card c in listCards)
            {
                for (int i = 0; i < listCards.Count; i++)
                {
                    if ((c.FaceImage == listCards[i].FaceImage) && (c.GetHashCode() != listCards[i].GetHashCode()))
                    {
                        c.AddPairCard(listCards[i]);
                    }
                }
            }
        }

        private void ShuffleCards()
        {
            if (shuffle && listCards.Count > 0)
            {
                Card temp;
                for (int i = 0; i < listCards.Count; i++)
                {
                    temp = listCards[i];
                    int value = Alea.Instance().NewAlea(i, listCards.Count - 1);
                    listCards[i] = listCards[value];
                    listCards[value] = temp;
                }
            }
        }
        
        public void AddMove()
        {
            move++;
        }

        public void AddRepeat()
        {
            repeat++;
        }

        public double ScoreTrial()
        {
            return Math.Round((double)100 - (((double)repeat / (double)move) * (double)100), 2);
        }

        public bool TrialFinish()
        {
            foreach (Card c in listCards)
            {
                if (c.CurrentStatus != StatusCard.found)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string a = "Trial : " + this.GetHashCode() + "\n\t";
            foreach (Card item in listCards)
            {
                a += item.ToString() + " \t";
            }
            return a + "\n";
        }
    }
}