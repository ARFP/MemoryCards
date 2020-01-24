using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelEtalonnages : ObservableObject
    {
        #region Propriétées
        private Etalonnages etalonnages;
        private List<ViewModelEtalonnage> lEtalonnages;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Chaque accesseur font référence a une propriété de l'etalonnage
        /// Leur état est survéillé par NotifyPropertyChanged
        /// <see cref="Name">Tranche d'age de l'étalonnage</see>
        /// <see cref="LEtalonnages">List de chaque ViewModel des manches de l'étalonnage</see>
        /// </summary>
        public string Name { get { return etalonnages.Name; } set { etalonnages.Name = value; OnPropertyChanged(nameof(Name)); } }
        public List<ViewModelEtalonnage> LEtalonnages { get { return lEtalonnages; } set { lEtalonnages = value; OnPropertyChanged(nameof(lEtalonnages)); } }
        #endregion

        #region Constructeur
        public ViewModelEtalonnages(Etalonnages _etalonnages)
        {
            lEtalonnages = new List<ViewModelEtalonnage>();
            etalonnages = _etalonnages;
            foreach (Etalonnage e in _etalonnages.LEtalonnages)
            {
                lEtalonnages.Add(new ViewModelEtalonnage(e));
            }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Sauvegarde la liste des manches du test
        /// </summary>
        /// <param name="_nameSave">Nom pour la sauvegarde du fichier</param>
        public void Save(string _nameSave)
        {
            etalonnages.Save(_nameSave);
        }

        /// <summary>
        /// Charge les données d'étalonnages d'une tranche d'age, des manches
        /// selon l'age de l'utilissateur
        /// </summary>
        /// <param name="_age">Age de l'utilisateur</param>
        public void Load(int _age)
        {
            etalonnages.Load(_age);
            foreach (Etalonnage e in etalonnages.LEtalonnages)
            {
                LEtalonnages.Add(new ViewModelEtalonnage(e));
            }
        }
        #endregion
    }
}
