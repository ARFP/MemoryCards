using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestColor : Test
    {
        private List<object> listColor;

        public TestColor(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Couleurs", _nbrTrials, _timer)
        {
            listColor = new List<object>() {
                String.Format(@"pack://application:,,,/Resources/BgBlack.png"),
                String.Format(@"pack://application:,,,/Resources/BgBlue.png"),
                String.Format(@"pack://application:,,,/Resources/BgBrown.png"),
                String.Format(@"pack://application:,,,/Resources/BgGreen.png"),
                String.Format(@"pack://application:,,,/Resources/BgGrey.png"),
                String.Format(@"pack://application:,,,/Resources/BgOrange.png"),
                String.Format(@"pack://application:,,,/Resources/BgPink.png"),
                String.Format(@"pack://application:,,,/Resources/BgPurple.png"),
                String.Format(@"pack://application:,,,/Resources/BgRed.png"),
                String.Format(@"pack://application:,,,/Resources/BgTurquoise.png"),
                String.Format(@"pack://application:,,,/Resources/BgWhite.png"),
                String.Format(@"pack://application:,,,/Resources/BgYellow.png"),
        };
            AddTrial(listColor, _sound);
        }

    }
}
