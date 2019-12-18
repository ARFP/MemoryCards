using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace MemoryCards
{
    /// <summary>
    /// Logique d'interaction pour PageIdentification.xaml
    /// </summary>
    public partial class PageIdentification : Page
    {
        public PageIdentification()
        {
            InitializeComponent();
        }

        public void BtnValidateClick(object sender, RoutedEventArgs e)
        {
            bool error = false;
            string genre = string.Empty;
            if (RBMan.IsChecked == true)
            {
                genre = "Homme";
            }
            else if (RBWoman.IsChecked == true)
            {
                genre = "Femme";
            }
            else
            {
                error = true;
            }

            var a = TBFirstName.Text;
            //string b = TBLastName.Text;
            //int c = int.Parse(TBAge.Text);

            if (!error)
            {
                User u = new User(TBFirstName.Text, TBLastName.Text, genre, int.Parse(TBAge.Text));
                this.NavigationService.Navigate(new PageMode(new ClassLibraryViewModel.ViewModelUser(u)));
            }
        }
    }
}
