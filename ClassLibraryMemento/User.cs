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
        private DateTime dateOfTheDay;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Age { get => age; set => age = value; }
        public DateTime DateOfTheDay { get => dateOfTheDay; set => dateOfTheDay = value; }

        public User()
        {
            FirstName = "Ben";
            LastName = "Gabrant";
            genre = "COD";
            Age = 32;
            dateOfTheDay = DateTime.Now;
        }

        public User(string _FirstName, string _LastName, string _genre, int _Age)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            genre = _genre;
            Age = _Age;
            dateOfTheDay = DateTime.Now;
        }
    }
}
