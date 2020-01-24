using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string genre;
        private DateTime dateOfBirth;
        private DateTime currentDate;
        private IPersistanceUser iPersistance;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Genre { get => genre; set => genre = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime CurrentDate { get => currentDate; set => currentDate = value; }

        public User()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            genre = string.Empty;
            dateOfBirth = new DateTime();
            currentDate = new DateTime();
            iPersistance = new Persistance();
        }

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

        public int GetAge()
        {
            if (currentDate.Month <= dateOfBirth.Month && currentDate.Day <= dateOfBirth.Day)
            {
                return (currentDate.Year - dateOfBirth.Year) - 1;
            }

            return currentDate.Year - dateOfBirth.Year;
        }

        public bool Save(string _pathSave)
        {
            return iPersistance.Write(this, _pathSave);
        }
    }
}
