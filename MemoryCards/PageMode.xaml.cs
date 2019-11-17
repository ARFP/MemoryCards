using ClassLibraryMemento;
using ClassLibraryViewModel;
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

namespace MemoryCards
{
    /// <summary>
    /// Logique d'interaction pour PageMode.xaml
    /// </summary>
    public partial class PageMode : Page
    {
        ViewModelUser user;
        ViewModelTest test;
        public PageMode(ViewModelUser _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button b)
            {
                test = new ViewModelTest(user, b.Tag.ToString());
            }
            if(test != null )
            {
                this.NavigationService.Navigate(new PageRuleTrial(test));
            }
        }
    }
}
