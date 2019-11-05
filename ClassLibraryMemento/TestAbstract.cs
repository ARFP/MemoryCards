using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibraryMemento
{
    public class TestAbstract : Test
    {

        private List<object> listAbstract;
        public TestAbstract(int _nbrTrials, int _timer, bool _sound) : base("Abstrait", _nbrTrials, _timer)
        {
            listAbstract = new List<object>() {
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait1.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait2.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait3.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait4.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait5.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait6.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait7.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait8.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait9.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait10.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait11.jpg"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Abstracts\abstrait12.jpg"),
            };
            AddTrial(listAbstract, _sound);
        }
    }
}
