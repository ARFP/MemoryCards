using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sTrialsScore
    {
        private List<sTrialScore> ltrials;
        public List<sTrialScore> Ltrials { get => ltrials; set => ltrials = value; }
    }
}
