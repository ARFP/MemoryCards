using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sResumeEtalonnagesAllAge
    {
        private int totalNumber;
        private List<sResumeEtalonnageAllAge> etalonnageAllAges;

        public int TotalNumber { get => totalNumber; set => totalNumber = value; }
        public List<sResumeEtalonnageAllAge> EtalonnageAllAges { get => etalonnageAllAges; set => etalonnageAllAges = value; }
    }
}
