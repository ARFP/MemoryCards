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
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\1.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\2.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\3.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\4.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\5.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\6.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\7.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\8.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\9.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\10.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\11.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Numbers\12.png"),
            };
            AddTrial(listNumber, _sound);
        }

    }
}
