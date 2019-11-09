using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExcel
{
    public class TrialEtalonnage
    {
        private string name;
        private List<OneTrialEtalonnage> trialEtalonnages;

        public string Name { get => name; set => name = value; }
        public List<OneTrialEtalonnage> TrialEtalonnages { get => trialEtalonnages; set => trialEtalonnages = value; }
    }
}
