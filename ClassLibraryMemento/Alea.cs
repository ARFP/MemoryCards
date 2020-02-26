using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Alea : Random
    {
        #region Propriétées
        private static Alea myAlea = null;
        #endregion
        
        #region Constructeur
        /// <summary>
        /// <code>vide</code>
        /// </summary>
        private Alea(){}
        #endregion

        #region Methodes
        /// <summary>
        /// Methode pour le singleton
        /// </summary>
        /// <returns>nouvelle instance ou la meme</returns>
        public static Alea Instance()
        {
            if (myAlea == null)
            {
                myAlea = new Alea();
            }
            return myAlea;
        }
        /// <summary>
        /// Methode pour avoir une valeur aléatoire 
        /// </summary>
        /// <param name="minValue">valeur minimal</param>
        /// <param name="maxValue">valeur maximal</param>
        /// <returns>retourne une valeur aléatoire entre les deux parametres</returns>
        public int NewAlea(int minValue, int maxValue)
        {
            return base.Next(minValue, maxValue + 1);
        }
        #endregion

    }
}
