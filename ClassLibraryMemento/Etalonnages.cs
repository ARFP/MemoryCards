using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Etalonnages
    {
        private string name;
        private List<Etalonnage> lEtalonnages;
        private IPersistancesEtalonnages iPersistance;

        public string Name { get => name; set => name = value; }
        public List<Etalonnage> LEtalonnages { get => lEtalonnages; set => lEtalonnages = value; }

        public Etalonnages()
        {
            name = "";
            lEtalonnages = new List<Etalonnage>();
            iPersistance = new Persistance();
        }

        private Etalonnages(string _name)
        {
            name = _name;
            lEtalonnages = new List<Etalonnage>();
            iPersistance = new Persistance();
        }

        public static implicit operator sEtalonnages(Etalonnages _etalonnages)
        {
            sEtalonnages sEs = new sEtalonnages
            {
                LEtalonnages = new List<sEtalonnage>(),
                Name = _etalonnages.Name
            };
            foreach (Etalonnage e in _etalonnages.LEtalonnages)
            {
                sEs.LEtalonnages.Add(e);
            }
            return sEs;
        }

        public void Save(string _pathSave)
        {
            iPersistance.Write(this, _pathSave);
        }

        public void Load(int _age)
        {
            sEtalonnages _sEtalonnages = iPersistance.Read(_age);
            Name = _sEtalonnages.Name;
            foreach (sEtalonnage e in _sEtalonnages.LEtalonnages)
            {
                LEtalonnages.Add(e);
            }
        }
    }
}
