using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Trial
    {
        private List<Card> listCards;
        private TrialScore score;

        public TrialScore Score { get => score; set => score = value; }
        public List<Card> ListCards { get => listCards; set => listCards = value; }

        public Trial(string _typeTest, List<object> _card, int _trialNumber, bool _sound, bool _shuffle)
        {
            listCards = new List<Card>();
            AddCard(_card);
            score = new TrialScore();
            score.TrialNumber = _trialNumber;
            score.TypeTest = _typeTest;
            score.NumberCards = listCards.Count;
            score.Sound = _sound;
            score.Shuffle = _shuffle;
            score.Move = 0;
            score.Repeat = 0;
            score.ScoreTrial = 0;
            if (score.Shuffle)
            {
                ShuffleCards();
            }
        }

        public Trial(Trial _trial, int _trailNumber)
        {
            listCards = new List<Card>();
            Clonecardlist(_trial.listCards);
            score.TrialNumber = _trailNumber;
            score.TypeTest = _trial.score.TypeTest;
            score.NumberCards = _trial.score.NumberCards;
            score.Sound = _trial.score.Sound;
            score.Shuffle = false;
            score.Move = 0;
            score.Repeat = 0;
            score.ScoreTrial = 0;
        }

        public void AddCard(List<object> _image)
        {
            for (int i = 0; i < _image.Count; i++)
            {
                Card c = new Card(i.ToString(), (string)_image[i]);
                Card c1 = new Card(i.ToString(), (string)_image[i]);
                c.addPairCard(c1);
                c1.addPairCard(c);
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
                        c.addPairCard(listCards[i]);
                    }
                }
            }
        }

        private void ShuffleCards()
        {
            if (score.Shuffle && listCards.Count > 0)
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
            score.Move++;
        }

        public void AddRepeat()
        {
            score.Repeat++;
        }

        //public void ScoreTrial()
        //{
        //    score.ScoreTrial = Math.Round((double)100 - (((double)score.Repeat / (double)score.Move) * (double)100), 2);
        //}

        public bool TrialFinish()
        {
            foreach (Card c in listCards)
            {
                if (c.CurrentStatus != StatusCard.found)
                {
                    return false;
                }
            }
            score.ScoreTrial = Math.Round((double)100 - (((double)score.Repeat / (double)score.Move) * (double)100), 2);
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