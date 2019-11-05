using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestColor : Test
    {
        private List<object> listColor;

        public TestColor(int _nbrTrials, int _timer, bool _sound) : base("Couleurs", _nbrTrials, _timer)
        {
            listColor = new List<object>() {
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgBlack.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgBlue.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgBrown.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgGreen.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgGrey.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgOrange.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgPink.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgPurple.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgRed.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgTurquoise.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgWhite.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Colors\BgYellow.png"),
        };
            AddTrial(listColor, _sound);
        }

    }
}
