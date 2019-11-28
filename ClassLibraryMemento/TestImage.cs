using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestImage : Test
    {
        private List<object> listImage;

        public TestImage(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Images", _nbrTrials, _timer)
        {
            listImage = new List<object>() {
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\airship.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\tree.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\car.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\clock.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\computer.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\grandbi.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\flag.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\flower.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\girl.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\house.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\star.png"),
                String.Concat(Directory.GetCurrentDirectory(),@"\Ressources\Images\scissors.png"),
            };
            AddTrial(listImage, _sound);
        }
       
    }
}
