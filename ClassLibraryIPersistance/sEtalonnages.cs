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
        private List<sEtalonnage> lEtalonnages;

        public string Name { get => name; set => name = value; }
        public List<sEtalonnage> LEtalonnages { get => lEtalonnages; set => lEtalonnages = value; }
    }
}
