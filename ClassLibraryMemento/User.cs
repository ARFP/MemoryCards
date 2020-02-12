using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class User
    {
        #region Propriétés
        /// <summary>
        /// <see cref="firstName">Prénom de l'ultilisateur</see>
        /// <see cref="lastName">Nom de l'utilisiteur</see>
        /// <see cref="genre">Sexe de l'utilisateur</see>
        /// <see cref="dateOfBirth">Date d'anniversaire</see>
        /// <see cref="currentDate">Date du jour</see>
        /// <see cref="iPersistance">persistance de l'utilisateur</see>
        /// </summary>
        private string firstName;
        private string lastName;
        private string genre;
        private DateTime dateOfBirth;
        private DateTime currentDate;
        private IPersistanceUser iPersistance;
        #endregion

        #region Accesseur
        /// <summary>
        /// <see cref="FirstName">Accesseur prénom</see>
        /// <see cref="LastName">Accesseur nom</see>
        /// <see cref="Genre">Accesseur sexe</see>
        /// <see cref="DateOfBirth">Accesseur date d'anniversaire</see>
        /// <see cref="CurrentDate">Accesseur date du jour</see>
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Genre { get => genre; set => genre = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime CurrentDate { get => currentDate; set => currentDate = value; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur de l'utilisateur
        /// </summary>
        public User()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            genre = string.Empty;
            dateOfBirth = new DateTime();
            currentDate = new DateTime();
            iPersistance = new Persistance();
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Methode implicit user en sUser
        /// </summary>
        /// <param name="_user">Utilisateur a transformer en sUser</param>
        public static implicit operator sUser(User _user)
        {
            return new sUser
            {
                FirstName = _user.FirstName,
                LastName = _user.LastName,
                Genre = _user.Genre,
                Age = _user.GetAge().ToString(),
                DateOfBirth = _user.DateOfBirth,
                DateOfTheDay = _user.CurrentDate
            };
        }

        /// <summary>
        /// Calcul l'age Selon la Date du jour et la date de naissance
        /// </summary>
        /// <returns>return l'age de l'utilisateur et 0 par default</returns>
        public int GetAge()
        {
            if (currentDate.Month <= dateOfBirth.Month && currentDate.Day <= dateOfBirth.Day)
            {
                return ((currentDate.Year - dateOfBirth.Year - 1) >= 0) ? currentDate.Year - dateOfBirth.Year - 1 : 0;
            }

            return ((currentDate.Year - dateOfBirth.Year) >= 0) ? currentDate.Year - dateOfBirth.Year : 0;
        }

        /// <summary>
        /// Sauvegarde l'utilisateur
        /// </summary>
        /// <param name="_pathSave">Nom de la sauvegarde</param>
        /// <returns></returns>
        public bool Save(string _pathSave)
        {
            return iPersistance.Write(this, _pathSave);
        }
        #endregion
    }
}
