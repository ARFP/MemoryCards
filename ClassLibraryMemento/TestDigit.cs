using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibraryMemento
{
    public class TestDigit : Test
    {

        private List<object> listDigit;
        public TestDigit(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Nombres", _nbrTrials, _timer)
        {
            listDigit = new List<object>() {
                String.Format(@"pack://application:,,,/Resources/164.png"),
                String.Format(@"pack://application:,,,/Resources/195.png"),
                String.Format(@"pack://application:,,,/Resources/281.png"),
                String.Format(@"pack://application:,,,/Resources/295.png"),
                String.Format(@"pack://application:,,,/Resources/374.png"),
                String.Format(@"pack://application:,,,/Resources/386.png"),
                String.Format(@"pack://application:,,,/Resources/418.png"),
                String.Format(@"pack://application:,,,/Resources/527.png"),
                String.Format(@"pack://application:,,,/Resources/639.png"),
                String.Format(@"pack://application:,,,/Resources/753.png"),
                String.Format(@"pack://application:,,,/Resources/862.png"),
                String.Format(@"pack://application:,,,/Resources/946.png"),
            };
            AddTrial(listDigit, _sound);
        }
    }
}
