using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibraryMemento
{
    public class TestDigit : Test
    {

        private List<object> listDigit;
        public TestDigit(int _nbrTrials, int _timer, bool _sound) : base("Nombres", _nbrTrials, _timer)
        {
            listDigit = new List<object>() {
                String.Concat(System.IO.Directory.GetCurrentDirectory(),@"\Digits\164.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\195.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\281.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\295.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\374.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\386.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\418.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\527.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\639.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\753.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\862.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Digits\946.png"),
            };
            AddTrial(listDigit, _sound);
        }
    }
}
