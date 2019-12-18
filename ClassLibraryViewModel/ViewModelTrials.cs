using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelTrials : ObservableObject
    {
        private Trials trials;
        private List<ViewModelTrial> lVMTrial;
        public List<ViewModelTrial> LVMTrial { get { return lVMTrial; } set { lVMTrial = value; OnPropertyChanged(nameof(LVMTrial)); } }

        public ViewModelTrials(Trials _trials)
        {
            trials = _trials;
            lVMTrial = new List<ViewModelTrial>();
            foreach(Trial t in _trials.LTrial)
            {
                lVMTrial.Add(new ViewModelTrial(t));
            }
        }

        public bool Save(string _pathSave)
        {
            return trials.Save(_pathSave);
        }
    }
}
