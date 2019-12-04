using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibraryMemento
{
    public class TestAbstract : Test
    {
        private List<object> listAbstract;
        public TestAbstract(User _user,  int _nbrTrials, int _timer, bool _sound) : base(_user, "Abstrait", _nbrTrials, _timer)
        {
            listAbstract = new List<object>() {
                String.Format(@"pack://application:,,,/Resources/abstrait1.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait2.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait3.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait4.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait5.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait6.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait7.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait8.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait9.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait10.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait11.jpg"),
                String.Format(@"pack://application:,,,/Resources/abstrait12.jpg"),
            };
            AddTrial(listAbstract, _sound);
        }
    }
}
