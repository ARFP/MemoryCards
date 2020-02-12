using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sTrialScore
    {
        #region Propriétées
        /// <summary>
        /// <see cref="trialNumber">Numéro de la manche</see>
        /// <see cref="typeTest">Type de test de la manche</see>
        /// <see cref="numberCards">Nombre de carte de la manche</see>
        /// <see cref="sound">Si la manche a le mode son activé</see>
        /// <see cref="shuffle">Si la position des cartes est mélangé dans la manche</see>
        /// <see cref="move">Nombre de mouvement fait durant la manche</see>
        /// <see cref="repeat">Nombre de répétition fait durant la manche</see>
        /// <see cref="scoreTrial">Score de la manche</see>
        /// </summary>
        private int trialNumber;
        private string typeTest;
        private int numberCards;
        private bool sound;
        private bool shuffle;
        private int move;
        private int repeat;
        private double scoreTrial;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public int TrialNumber { get => trialNumber; set => trialNumber = value; }
        public string TypeTest { get => typeTest; set => typeTest = value; }
        public int NumberCards { get => numberCards; set => numberCards = value; }
        public bool Sound { get => sound; set => sound = value; }
        public bool Shuffle { get => shuffle; set => shuffle = value; }
        public int Move { get => move; set => move = value; }
        public int Repeat { get => repeat; set => repeat = value; }
        public double ScoreTrial { get => scoreTrial; set => scoreTrial = value; }
        #endregion
    }
}
