using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sEtalonnages
    {
        private string name;
        private List<sEtalonnage> etalonnages;

        public string Name { get => name; set => name = value; }
        public List<sEtalonnage> Etalonnages { get => etalonnages; set => etalonnages = value; }
    }
}
