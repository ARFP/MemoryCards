using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string _text)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                handler(this, new PropertyChangedEventArgs(_text));
            }
        }
    }
}
