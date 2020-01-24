using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClassLibraryControl
{
    /// <summary>
    /// Contient la validation des données entrées par l'utilisateur
    /// </summary>
    public class ValidateUser 
    {
        #region Propriétées
        /// <summary>
        /// Age minimun admis
        /// </summary>
        private const int ageMinimal = 17;
        /// <summary>
        /// Age maximum admis
        /// </summary>
        private const int ageMaximal = 120;
        #endregion

        #region Méthodes
        /// <summary>
        /// Vérification des champs textes nom, prénom de l'utilisateur
        /// </summary>
        /// <param name="_name">contient nom ou prénom entrée par l'utilisateur</param>
        /// <param name="_validationErrors"></param>
        /// <returns>Si il y a une erreur ou non</returns>
        public bool NameValidation(string _name, out ICollection<string> _validationErrors)
        {
            _validationErrors = new List<string>();

            if (!Regex.IsMatch(_name, @"^[A-Za-z][A-Za-z -]*$"))
            {
                _validationErrors.Add("Doit comporter des lettres, espace, ou tiret (-)");
            }
            if(string.IsNullOrEmpty(_name))
            {
                _validationErrors.Add("Veuillez renseigner le champ");
            }

            return _validationErrors.Count == 0;
        }

        /// <summary>
        /// Vérification que le champ genre correspond bien a "homme" ou "femme"
        /// </summary>
        /// <param name="_genre">contient le genre sélectionné par l'utilisateur</param>
        /// <param name="_validationErrors"></param>
        /// <returns>Si il y a une erreur ou non</returns>
        public bool GenreValidation(string _genre, out ICollection<string> _validationErrors)
        {
            _validationErrors = new List<string>();
            if(_genre != "Homme" && _genre != "Femme")
            {
                _validationErrors.Add("La valeur spécifié est différent de ce mentionné");
            }

            return _validationErrors.Count == 0;
        }

        /// <summary>
        /// Verification de l'age de l'utilisateur
        /// </summary>
        /// <param name="_age">contient l'age entrée par l'utilisateur</param>
        /// <param name="_validationErrors"></param>
        /// <returns>Si il y a une erreur ou non</returns>
        public bool DateOfBirthValidation(string _age, out ICollection<string> _validationErrors)
        {
            _validationErrors = new List<string>();
            if(!DateTime.TryParse(_age, out DateTime i))
            {
                _validationErrors.Add("Date invalide");
            }
            else
            {
                if(i.Year > (DateTime.Now.Year - ageMinimal))
                {
                    _validationErrors.Add($"La date doit être antérieure à {DateTime.Now.Year - ageMinimal}");
                }
                else if(i.Year < (DateTime.Now.Year - ageMaximal))
                {
                    _validationErrors.Add($"La date doit être supérieur a {DateTime.Now.Year - ageMaximal}");
                }
            }

            return _validationErrors.Count == 0;
        }
        #endregion
    }
}
