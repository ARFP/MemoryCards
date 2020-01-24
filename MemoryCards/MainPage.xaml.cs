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
    /// Logique d'interaction pour MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private ViewModelUser vmUser;

        public MainPage()
        {
            InitializeComponent();
            vmUser = new ViewModelUser();
        }

        public MainPage(ViewModelUser _vmUser)
        {
            InitializeComponent();
            vmUser = _vmUser;      
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(new PageIdentification(vmUser));
        }
    }
}
