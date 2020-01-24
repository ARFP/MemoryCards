using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sUser
    {
        private string firstName;
        private string lastName;
        private string genre;
        private DateTime dateOfBirth;
        private string age;
        private DateTime dateOfTheDay;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Genre { get => genre; set => genre = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Age { get => age; set => age = value; }
        public DateTime DateOfTheDay { get => dateOfTheDay; set => dateOfTheDay = value; }
    }
}
