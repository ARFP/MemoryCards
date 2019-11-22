using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelEtalonnages : ObservableObject
    {
        private Etalonnages etalonnages;
        private List<ViewModelEtalonnage> lEtalonnages;

        public string Name { get { return etalonnages.Name; } set { etalonnages.Name = value; OnPropertyChanged(nameof(Name)); } }
        public List<ViewModelEtalonnage> LEtalonnages { get { return lEtalonnages; } set { lEtalonnages = value; OnPropertyChanged(nameof(lEtalonnages)); } }

        public ViewModelEtalonnages(Etalonnages _etalonnages)
        {
            lEtalonnages = new List<ViewModelEtalonnage>();
            etalonnages = _etalonnages;
            foreach(Etalonnage e in _etalonnages.LEtalonnages)
            {
                lEtalonnages.Add(new ViewModelEtalonnage(e));
            }
        }

        public void Save(string _pathSave)
        {
            etalonnages.Save(_pathSave);
        }

        public void Load(int _age)
        {
            etalonnages.Load(_age);
            foreach(Etalonnage e in etalonnages.LEtalonnages)
            {
                LEtalonnages.Add(new ViewModelEtalonnage(e));
            }
        }
    }
}
