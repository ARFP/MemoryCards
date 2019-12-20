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
        private int age;
        private DateTime currentDate;
        private IPersistanceUser iPersistance;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Age { get => age; set => age = value; }
        public DateTime CurrentDate { get => currentDate; set => currentDate = value; }

        public User(DateTime _currentDate)
        {
            currentDate = _currentDate;
            iPersistance = new Persistance();
        }

        public static implicit operator sUser(User _user)
        {
            return new sUser
            {
                FirstName = _user.FirstName,
                LastName = _user.LastName,
                Genre = _user.Genre,
                Age = _user.Age,
                DateOfTheDay = _user.CurrentDate
            };
        }

        public bool Save(string _pathSave)
        {
            return iPersistance.Write(this, _pathSave); //-----
        }
    }
}
