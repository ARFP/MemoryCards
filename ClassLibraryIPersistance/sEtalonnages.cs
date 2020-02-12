using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sEtalonnages
    {
        #region Propriétées
        /// <summary>
        /// <see cref="name">Tranche d'age de l'etalonnage</see>
        /// <see cref="lEtalonnages">Liste des étalonnages</see>
        /// </summary>
        private string name;
        private List<sEtalonnage> lEtalonnages;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string Name { get => name; set => name = value; }
        public List<sEtalonnage> LEtalonnages { get => lEtalonnages; set => lEtalonnages = value; }
        #endregion
    }
}
