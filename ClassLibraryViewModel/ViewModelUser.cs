﻿using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelUser : ObservableObject
    {
        private User user = new User();
        public string FirstName { get { return user.FirstName; } set { user.FirstName = value; } }
        public string LastName { get {return user.LastName; } set { user.LastName = value; } }
        public string Genre { get { return user.Genre; } set { user.Genre = value; } }
        public int Age { get {return user.Age; } set { user.Age = value; } }
        public DateTime DateOfTheDay { get { return user.DateOfTheDay; } set { user.DateOfTheDay = value; } }

        public ViewModelUser(User _user)
        {
            user = _user;
        }

        public ViewModelUser()
        {
        }
    }
}
