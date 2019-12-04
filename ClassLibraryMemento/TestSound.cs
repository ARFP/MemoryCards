using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestSound : Test
    {
        private List<object> listSounds = new List<object>() {
            //String.Format(@"pack://application:,,,/Resources/sound0.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound1.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound3.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound4.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound5.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound9.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound10.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound11.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound13.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound16.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound20.mp3"),
            //String.Format(@"pack://application:,,,/Resources/sound21.mp3"),
            "sound0",
            "sound1",
            "sound3",
            "sound4",
            "sound5",
            "sound9",
            "sound10",
            "sound11",
            "sound13",
            "sound16",
            "sound20",
            "sound21",
        };

        public TestSound(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Sons", _nbrTrials, _timer)
        {
            AddTrial(listSounds, _sound);
        }

    }
}
