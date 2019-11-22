using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sResumeEtalonnagesAllAge
    {
        private string totalNumber;
        private List<sResumeEtalonnageAllAge> lEtalonnageAllAges;

        public string TotalNumber { get => totalNumber; set => totalNumber = value; }
        public List<sResumeEtalonnageAllAge> LEtalonnageAllAges { get => lEtalonnageAllAges; set => lEtalonnageAllAges = value; }
    }
}
