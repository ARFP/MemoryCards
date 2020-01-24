using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ObservableObject : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region NotifyPropertyChanged
        #region propriétées
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Méthodes
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_text"></param>
        protected void OnPropertyChanged(string _text)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                handler(this, new PropertyChangedEventArgs(_text));
            }
        }
        #endregion
        #endregion

        #region NotifyDataError
        #region Propriétées
        public readonly Dictionary<string, ICollection<string>> _validationErrors = new Dictionary<string, ICollection<string>>();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public bool HasErrors { get { return _validationErrors.Count > 0; } }
        #endregion

        #region Méthodes
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaiseErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
            {
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Retourne la liste des erreurs de la propriétée surveillé
        /// </summary>
        /// <param name="propertyName">nom de la propriété surveillé</param>
        /// <returns>La liste des erreurs enregistré</returns>
        public IEnumerable GetErrors(string propertyName)
        {
            return (string.IsNullOrEmpty(propertyName) || !_validationErrors.ContainsKey(propertyName)) ? null : _validationErrors[propertyName];
        }
        #endregion
        #endregion
    }
}
