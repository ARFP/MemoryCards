using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestWord : Test
    {
        private List<object> listWord;
        public TestWord(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Mots", _nbrTrials, _timer)
        {
            listWord = new List<object>() {
                 String.Format(@"pack://application:,,,/Resources/cuir.png"),
                 String.Format(@"pack://application:,,,/Resources/dindon.png"),
                 String.Format(@"pack://application:,,,/Resources/ecole.png"),
                 String.Format(@"pack://application:,,,/Resources/jardin.png"),
                 String.Format(@"pack://application:,,,/Resources/maison.png"),
                 String.Format(@"pack://application:,,,/Resources/moustache.png"),
                 String.Format(@"pack://application:,,,/Resources/parent.png"),
                 String.Format(@"pack://application:,,,/Resources/paysan.png"),
                 String.Format(@"pack://application:,,,/Resources/rideau.png"),
                 String.Format(@"pack://application:,,,/Resources/riviere.png"),
                 String.Format(@"pack://application:,,,/Resources/soleil.png"),
                 String.Format(@"pack://application:,,,/Resources/tambour.png"),
            };
            AddTrial(listWord, _sound);
        }

    }
}
