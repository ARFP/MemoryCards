using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Alea : Random
    {
        private static Alea myAlea = null;

        private Alea()
        {

        }

        public static Alea Instance()
        {
            if (myAlea == null)
            {
                myAlea = new Alea();
            }
            return myAlea;
        }

        public int NewAlea(int minValue, int maxValue)
        {
            return base.Next(minValue, maxValue + 1);
        }
    }
}
