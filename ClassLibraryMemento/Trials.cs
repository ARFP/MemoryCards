using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Trials
    {
        private List<Trial> lTrials;
        private IPersistanceTrialsScore iPersistance;

        public List<Trial> LTrial { get => lTrials; set => lTrials = value; }

        public Trials()
        {
            lTrials = new List<Trial>();
            iPersistance = new Persistance();
        }

        public static implicit operator sTrialsScore(Trials _trials)
        {
            sTrialsScore ts = new sTrialsScore();
            ts.Ltrials = new List<sTrialScore>();
            foreach(Trial t in _trials.LTrial)
            {
                ts.Ltrials.Add(t);
            }
            return ts;
        }

        public bool Save(string _pathSave)
        {
            return iPersistance.Write(this, _pathSave);
        }
    }
}
