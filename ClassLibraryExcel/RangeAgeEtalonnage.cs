using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExcel
{
    public struct RangeAgeEtalonnage
    {
        private string totalPersone;
        private List<OneRangeAgeEtalonnage> lOrae;

        public string TotalPersone { get => totalPersone; set => totalPersone = value; }
        public List<OneRangeAgeEtalonnage> LOrae { get => lOrae; set => lOrae = value; }
    }
}
