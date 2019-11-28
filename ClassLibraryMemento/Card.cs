using LibraryCommands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace ClassLibraryMemento
{
    public class Card : IComparable<Card>
    {
        public Card pairCard;

        private string name;
        private string faceImage;
        private string backImage;
        private string validateImage;
        private bool tested;
        private StatusCard currentStatus;
        private string cardImage;

        public bool Tested { get => tested; set => tested = value; }
        public StatusCard CurrentStatus{ get => currentStatus; set => currentStatus = value; }
        public string Name { get => name; set => name = value; }
        public string FaceImage { get => faceImage; set => faceImage = value; }
        public string BackImage { get => backImage; set => backImage = value; }
        public string ValidateImage { get => validateImage; set => validateImage = value; }
        public string CardImage { get => cardImage; set => cardImage = value; }

        public Card(string _name,string _image)
        {
            name = _name;
            faceImage = _image;
            backImage = String.Concat(Directory.GetCurrentDirectory(), @"\Ressources\Card\wood.png");
            validateImage = String.Concat(Directory.GetCurrentDirectory(), @"\Ressources\Card\woodCheckBtn.png");
            tested = false;
            currentStatus = StatusCard.back;
            pairCard = null;
            cardImage = backImage; 
            //cardImage = faceImage; 
        }

        public Card(Card _card)
        {
            name = _card.name;
            faceImage = _card.faceImage;
            backImage = _card.BackImage;
            validateImage = _card.validateImage;
            tested = false;
            currentStatus = StatusCard.back;
            pairCard = null;
            cardImage = _card.cardImage;
        }

        public void AddPairCard(Card _pairCard)
        {
            pairCard = _pairCard;
        }

        public int CompareTo(Card other)
        {
            if (pairCard.Equals(other))
            {
                return 1;
            }
            return 0;
        }           

        public override string ToString()
        {
            return "Card : " + this.GetHashCode() + "\t" + name + "\n";
        }
    }
}