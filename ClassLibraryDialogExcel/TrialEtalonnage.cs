using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDialogExcel
{
    public class TrialEtalonnage
    {
        private string name;
        private List<OneTrialEtalonnage> trialEtalonnages;

        public string Name { get => name; set => name = value; }
        public List<OneTrialEtalonnage> TrialEtalonnages { get => trialEtalonnages; set => trialEtalonnages = value; }
    }
}
