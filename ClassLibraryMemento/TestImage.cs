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
                String.Format(@"pack://application:,,,/Resources/airship.png"),
                String.Format(@"pack://application:,,,/Resources/tree.png"),
                String.Format(@"pack://application:,,,/Resources/car.png"),
                String.Format(@"pack://application:,,,/Resources/clock.png"),
                String.Format(@"pack://application:,,,/Resources/computer.png"),
                String.Format(@"pack://application:,,,/Resources/grandbi.png"),
                String.Format(@"pack://application:,,,/Resources/flag.png"),
                String.Format(@"pack://application:,,,/Resources/flower.png"),
                String.Format(@"pack://application:,,,/Resources/girl.png"),
                String.Format(@"pack://application:,,,/Resources/house.png"),
                String.Format(@"pack://application:,,,/Resources/star.png"),
                String.Format(@"pack://application:,,,/Resources/scissors.png"),
                //"airship",
                //"tree",
                //"car",
                //"clock",
                //"computer",
                //"grandbi",
                //"flag",
                //"flower",
                //"girl",
                //"house",
                //"star",
                //"scissors",
            };
            AddTrial(listImage, _sound);
        }
       
    }
}
