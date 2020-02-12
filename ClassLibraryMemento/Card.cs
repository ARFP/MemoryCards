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
        #region Properties
        /// <summary>
        /// <see cref="name">Nom de la carte</see>
        /// <see cref="faceImage">Image de face de la carte</see>
        /// <see cref="backImage">Image de dos de la carte</see>
        /// <see cref="validateImage">Image de dos validé de la carte</see>
        /// <see cref="tested">Indique si la carte a été testé au moins une fois</see>
        /// <see cref="currentStatus">Statuts actuel de la carte</see>
        /// <see cref="cardImage">Image actuel de la carte</see>
        /// <see cref="pairCard">carte désigner comme paire pour la comparaison</see>
        /// </summary>
        private string name;
        private string faceImage;
        private string backImage;
        private string validateImage;
        private bool tested;
        private StatusCard currentStatus;
        private string cardImage;
        private Card pairCard;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string FaceImage { get => faceImage; set => faceImage = value; }
        public string BackImage { get => backImage; set => backImage = value; }
        public string ValidateImage { get => validateImage; set => validateImage = value; }
        public bool Tested { get => tested; set => tested = value; }
        public StatusCard CurrentStatus { get => currentStatus; set => currentStatus = value; }
        public string CardImage { get => cardImage; set => cardImage = value; }
        public Card Paircard { get => pairCard; set => pairCard = value; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur de la carte
        /// </summary>
        /// <param name="_name">Nom de la carte</param>
        /// <param name="_image">Image de face de la carte</param>
        public Card(string _name, string _image)
        {
            name = _name;
            faceImage = _image;
            backImage = String.Format(@"pack://application:,,,/Resources/wood.png");
            validateImage = String.Format(@"pack://application:,,,/Resources/woodCheckBtn.png");
            tested = false;
            currentStatus = StatusCard.back;
            pairCard = null;
            cardImage = backImage; 
            //debug 
            //cardImage = faceImage; 
            //faceImage = String.Format(@"pack://application:,,,/Resources/wood.png");
            //backImage = _image;
        }

        /// <summary>
        /// Constructeur clone de la carte
        /// </summary>
        /// <param name="_card">Carte a cloner</param>
        public Card(Card _card)
        {
            name = _card.name;
            faceImage = _card.faceImage;
            backImage = _card.BackImage;
            validateImage = _card.validateImage;
            tested = true;
            currentStatus = StatusCard.back;
            pairCard = null;
            cardImage = _card.cardImage;
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajout d'une carte paire a la carte actuelle
        /// </summary>
        /// <param name="_pairCard">Carte a ajouter en paire</param>
        public void AddPairCard(Card _pairCard)
        {
            pairCard = _pairCard;
        }

        /// <summary>
        /// Compare la carte passé en paramètre avec 
        /// la paire de la carte actuelle
        /// </summary>
        /// <param name="other">Carte a comparer</param>
        /// <returns>1 si il y a correspondance, sinon 0</returns>
        public int CompareTo(Card other)
        {
            return pairCard.Equals(other) ? 1 : 0;
        }           


        public override string ToString()
        {
            return "Card : " + this.GetHashCode() + "\t" + name + "\n";
        }
        #endregion
    }
}