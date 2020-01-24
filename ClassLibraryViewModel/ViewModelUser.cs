using ClassLibraryControl;
using ClassLibraryMemento;
using System;
using System.Collections.Generic;

namespace ClassLibraryViewModel
{
    public class ViewModelUser : ObservableObject
    {
        #region Propriétées
        private User user;
        private ValidateUser validateUser;
        private string age;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Chaque accesseur font référence a une propriété de la Carte
        /// Leur état est survéillé par NotifyPropertyChanged
        /// </summary>
        public string FirstName { get { return user.FirstName; } set { user.FirstName = value; FirstNameValidation(FirstName); OnPropertyChanged(nameof(FirstName)); } }
        public string LastName { get {return user.LastName; } set { user.LastName = value; LastNameValidation(LastName); OnPropertyChanged(nameof(LastName)); } }
        public string Genre { get { return user.Genre; } set { user.Genre = value; GenreValidation(Genre); OnPropertyChanged(nameof(Genre)); } }
        public string DateOfBirth { get { return user.DateOfBirth.ToString("dd/MM/yyyy"); } set { user.DateOfBirth = (DateTime.TryParse(value, out DateTime a)) ? DateTime.Parse(value) : new DateTime(); DateOfBirthValidation(DateOfBirth); OnPropertyChanged(nameof(DateOfBirth)); } }
        public DateTime CurrentDate { get { return user.CurrentDate; } set { user.CurrentDate = value; } }
        public string Age { get { return age ; } set { age = value; OnPropertyChanged(nameof(Age)); } }
        #endregion

        #region Constructeur
        public ViewModelUser()
        {
            validateUser = new ValidateUser();
            user = new User();
            FirstName = string.Empty;
            LastName = string.Empty;
            Genre = string.Empty;
            DateOfBirth = string.Empty;
        }
        #endregion

        #region Méthodes
        public static implicit operator User(ViewModelUser _user)
        {
            return _user.user;
        }

        public bool Save(string _pathSave)
        {
            return user.Save(_pathSave);
        }

        private void FirstNameValidation(string _firstName)
        {
            ICollection<string> validationErrors = null;
            if (!validateUser.NameValidation(_firstName, out validationErrors))
            {
                _validationErrors["FirstName"] = validationErrors;
                RaiseErrorsChanged("FirstName");
            }
            else if (_validationErrors.ContainsKey("FirstName"))
            {
                _validationErrors.Remove("FirstName");
                RaiseErrorsChanged("FirstName");
            }
        }

        private void LastNameValidation(string _lastName)
        {
            ICollection<string> validationErrors = null;
            if (!validateUser.NameValidation(_lastName, out validationErrors))
            {
                _validationErrors["LastName"] = validationErrors;
                RaiseErrorsChanged("LastName");
            }
            else if (_validationErrors.ContainsKey("LastName"))
            {
                _validationErrors.Remove("LastName");
                RaiseErrorsChanged("LastName");
            }
        }

        private void GenreValidation(string genre)
        {
            ICollection<string> validationErrors = null;
            if (!validateUser.GenreValidation(genre, out validationErrors))
            {
                _validationErrors["Genre"] = validationErrors;
                RaiseErrorsChanged("Genre");
            }
            else if (_validationErrors.ContainsKey("Genre"))
            {
                _validationErrors.Remove("Genre");
                RaiseErrorsChanged("Genre");
            }
        }

        private void DateOfBirthValidation(string _dateOfBirth)
        {
            ICollection<string> validationErrors = null;
            if (!validateUser.DateOfBirthValidation(_dateOfBirth, out validationErrors))
            {
                _validationErrors["DateOfBirth"] = validationErrors;
                RaiseErrorsChanged("DateOfBirth");
            }
            else if (_validationErrors.ContainsKey("DateOfBirth"))
            {
                _validationErrors.Remove("DateOfBirth");
                RaiseErrorsChanged("DateOfBirth");
            }
            Age = user.GetAge().ToString();
        }
        #endregion
    }
}
