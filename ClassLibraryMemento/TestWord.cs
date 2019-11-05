using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestWord : Test
    {
        private List<object> listWord;
        public TestWord(int _nbrTrials, int _timer, bool _sound) : base("Mots", _nbrTrials, _timer)
        {
            listWord = new List<object>() {
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\cuir.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\dindon.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\ecole.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\jardin.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\maison.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\moustache.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\parent.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\paysan.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\rideau.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\riviere.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\soleil.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Words\tambour.png"),
            };
            AddTrial(listWord, _sound);
        }

    }
}
