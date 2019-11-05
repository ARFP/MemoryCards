using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelCard : ObservableObject
    {
        private Card card;
        public string Name
        {
            get
            {
                return card.Name;
            }
            set
            {
                card.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string FaceImage
        {
            get
            {
                return card.FaceImage;
            }
            set
            {
                card.FaceImage = value;
                OnPropertyChanged(nameof(FaceImage));
            }
        }
        public string BackImage
        {
            get
            {
                return card.BackImage;
            }
            set
            {
                card.BackImage = value;
                OnPropertyChanged(nameof(BackImage));
            }

        }
        public string ValidateImage
        {
            get
            {
                return card.ValidateImage;
            }
            set
            {
                card.ValidateImage = value;
                OnPropertyChanged(nameof(ValidateImage));
            }
        }
        public bool Tested
        {
            get
            {
                return card.Tested;
            }
            set
            {
                card.Tested = value;
                OnPropertyChanged(nameof(Tested));
            }
        }
        public StatusCard CurrentStatus
        {
            get
            {
                return card.CurrentStatus;
            }
            set
            {
                card.CurrentStatus = value;
                OnPropertyChanged(nameof(CurrentStatus));
            }
        }
        public Card PairCard
        {
            get
            {
                return card.pairCard;
            }
            set
            {
                card.pairCard = value;
                OnPropertyChanged(nameof(PairCard));
            }
        }
        public string CardImage
        {
            get
            {
                return card.CardImage;
            }
            set
            {
                card.CardImage = value;
                OnPropertyChanged(nameof(CardImage));
            }
        }

        public ViewModelCard(Card _card)
        {
            card = _card;        
        }

        public bool Compare(ViewModelCard _vmc)
        {
            return PairCard == _vmc.card;
        } 
    }
}
