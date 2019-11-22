using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class ResumeEtalonnagesAllAge
    {
        private string totalNumber;
        private List<ResumeEtalonnageAllAge> lResumeEtalonnageAllAges;
        private IPersistanceResumeEtalonnageAllAge iPersistance;

        public string TotalNumber { get => totalNumber; set => totalNumber = value; }
        public List<ResumeEtalonnageAllAge> LResumeEtalonnageAllAges { get => lResumeEtalonnageAllAges; set => lResumeEtalonnageAllAges = value; }

        public ResumeEtalonnagesAllAge()
        {
            totalNumber = "";
            lResumeEtalonnageAllAges = new List<ResumeEtalonnageAllAge>();
            iPersistance = new Persistance();
        }

        public void Load()
        {
            sResumeEtalonnagesAllAge reaa = iPersistance.Read();
            totalNumber = reaa.TotalNumber;
            foreach(sResumeEtalonnageAllAge rea in reaa.LEtalonnageAllAges)
            {
                lResumeEtalonnageAllAges.Add(rea);
            }
        }
    }
}
