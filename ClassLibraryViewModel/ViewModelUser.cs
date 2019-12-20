using ClassLibraryControl;
using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelUser : ObservableObject
    {
        private User user;
        private ValidateUser validateUser;

        public string FirstName { get { return user.FirstName; } set { user.FirstName = value; FirstNameValidation(FirstName); OnPropertyChanged(nameof(FirstName)); } }
        public string LastName { get {return user.LastName; } set { user.LastName = value; LastNameValidation(LastName); OnPropertyChanged(nameof(LastName)); } }
        public string Genre { get { return user.Genre; } set { user.Genre = value; GenreValidation(Genre); OnPropertyChanged(nameof(Genre)); } }
        public string Age { get {return user.Age.ToString(); } set { user.Age = int.Parse(value); AgeValidation(Age); OnPropertyChanged(Age); } }
        public DateTime CurrentDate { get { return user.CurrentDate; } set { user.CurrentDate = value; } }

        public ViewModelUser(DateTime _currentdate)
        {
            validateUser = new ValidateUser();
            user = new User(_currentdate);
            FirstName = "";
            LastName = "";
            Genre = "";
            Age = "0";
        }

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
            bool isValid = validateUser.NameValidation(_firstName, out validationErrors);
            if (!isValid)
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
            bool isValid = validateUser.NameValidation(_lastName, out validationErrors);
            if (!isValid)
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
            bool isValid = validateUser.GenreValidation(genre, out validationErrors);
            if (!isValid)
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

        private void AgeValidation(string _firstName)
        {
            ICollection<string> validationErrors = null;
            bool isValid = validateUser.AgeValidation(_firstName, out validationErrors);
            if (!isValid)
            {
                _validationErrors["Age"] = validationErrors;
                RaiseErrorsChanged("Age");
            }
            else if (_validationErrors.ContainsKey("Age"))
            {
                _validationErrors.Remove("Age");
                RaiseErrorsChanged("Age");
            }
        }
    }
}
