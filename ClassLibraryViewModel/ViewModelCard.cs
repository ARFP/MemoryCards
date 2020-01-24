using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelCard : ObservableObject
    {
        #region Propriétées
        private Card card;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Chaque accesseur font référence a une propriété de la Carte
        /// Leur état est survéillé par NotifyPropertyChanged
        /// <see cref="Name">Nom de la carte</see>
        /// <see cref="FaceImage">L'image de face de l'image</see>
        /// <see cref="BackImage">L'image de dos de la carte</see>
        /// <see cref="ValidateImage">L'image de la carte une fois sa paire trouvé</see>
        /// <see cref="Tested">Si la carte a déja été retourné une fois au court de la manche</see>
        /// <see cref="CurrentStatus">L'état actuelle de la carte</see>
        /// <see cref="PairCard">La carte paire de la l'instance de la carte</see>
        /// <see cref="CardImage">Image actuelle que va afficher la carte</see>
        /// </summary>
        public string Name { get { return card.Name; } set { card.Name = value; OnPropertyChanged(nameof(Name)); } }
        public string FaceImage { get { return card.FaceImage; } set { card.FaceImage = value; OnPropertyChanged(nameof(FaceImage)); } }
        public string BackImage { get { return card.BackImage; } set { card.BackImage = value; OnPropertyChanged(nameof(BackImage)); } }
        public string ValidateImage { get { return card.ValidateImage; } set { card.ValidateImage = value; OnPropertyChanged(nameof(ValidateImage)); } }
        public bool Tested { get { return card.Tested; } set { card.Tested = value; OnPropertyChanged(nameof(Tested)); } }
        public StatusCard CurrentStatus { get { return card.CurrentStatus; } set { card.CurrentStatus = value; OnPropertyChanged(nameof(CurrentStatus)); } }
        public Card PairCard { get { return card.pairCard; } set { card.pairCard = value; OnPropertyChanged(nameof(PairCard)); } }
        public string CardImage { get { return card.CardImage; } set { card.CardImage = value; OnPropertyChanged(nameof(CardImage)); } }
        #endregion

        #region Constructeur
        public ViewModelCard(Card _card)
        {
            card = _card;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Compare si la carte du ViewModelCard mis en paramètre 
        /// correspond a la carte paire de l'instance de carte 
        /// courante de ce ViewModelCard
        /// </summary>
        /// <param name="_vmc">ViewModelCard qui doit comparé ca carte</param>
        /// <returns>le résultat de la comparaison des cartes</returns>
        public bool Compare(ViewModelCard _vmc)
        {
            return PairCard == _vmc.card;
        }
        #endregion
    }
}
