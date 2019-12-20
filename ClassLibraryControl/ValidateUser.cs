using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryControl
{
    public class ValidateUser 
    {
        public bool NameValidation(string _name, out ICollection<string> _validationErrors)
        {
            _validationErrors = new List<string>();

            if (!Regex.IsMatch(_name, @"^[A-Z][a-z -]*$"))
            {
                _validationErrors.Add("Doit commencer par une majuscule et comporter des lettres, espace, ou tiret(-)");
            }
            if(string.IsNullOrEmpty(_name))
            {
                _validationErrors.Add("Veuillez renseigner le champ");
            }

            return _validationErrors.Count == 0;
        }

        public bool GenreValidation(string _genre, out ICollection<string> _validationErrors)
        {
            _validationErrors = new List<string>();
            if(_genre != "Homme" && _genre != "Femme")
            {
                _validationErrors.Add("La valeur spécifié est différent de ce mentionné");
            }

            return _validationErrors.Count == 0;
        }

        public bool AgeValidation(string age, out ICollection<string> _validationErrors)
        {
            _validationErrors = new List<string>();
            if(!int.TryParse(age, out int i))
            {
                _validationErrors.Add("Doit être un nombre a deux chiffres");
            }
            else
            {
                if(i < 18)
                {
                    _validationErrors.Add("La valuer doit être supérieur a 17");
                }
            }

            return _validationErrors.Count == 0;
        }
    }
}
