using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sUser
    {
        #region Properiétées
        /// <summary>
        /// <see cref="firstName">Prénom de l'utilisateur</see>
        /// <see cref="lastName">Nom de l'utilisateur</see>
        /// <see cref="genre">Sexe de l'utilisateur</see>
        /// <see cref="dateOfBirth">Date de naissance de l'utilisateur</see>
        /// <see cref="age">Age de l'utilisateur</see>
        /// <see cref="dateOfTheDay">Date du jour</see>
        /// </summary>
        private string firstName;
        private string lastName;
        private string genre;
        private DateTime dateOfBirth;
        private string age;
        private DateTime dateOfTheDay;
        #endregion

        #region Méthodes
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Genre { get => genre; set => genre = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Age { get => age; set => age = value; }
        public DateTime DateOfTheDay { get => dateOfTheDay; set => dateOfTheDay = value; }
        #endregion
    }
}
