using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibraryMemento
{
    public class TestNumber : Test
    {

        private List<object> listNumber;
        public TestNumber(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Chiffres", _nbrTrials, _timer)
        {
            listNumber = new List<object>() {
                String.Format(@"pack://application:,,,/Resources/1.png"),
                String.Format(@"pack://application:,,,/Resources/2.png"),
                String.Format(@"pack://application:,,,/Resources/3.png"),
                String.Format(@"pack://application:,,,/Resources/4.png"),
                String.Format(@"pack://application:,,,/Resources/5.png"),
                String.Format(@"pack://application:,,,/Resources/6.png"),
                String.Format(@"pack://application:,,,/Resources/7.png"),
                String.Format(@"pack://application:,,,/Resources/8.png"),
                String.Format(@"pack://application:,,,/Resources/9.png"),
                String.Format(@"pack://application:,,,/Resources/10.png"),
                String.Format(@"pack://application:,,,/Resources/11.png"),
                String.Format(@"pack://application:,,,/Resources/12.png"),
            };
            AddTrial(listNumber, _sound);
        }

    }
}
