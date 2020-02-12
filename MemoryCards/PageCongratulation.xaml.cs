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
    /// Logique d'interaction pour PageCongratulation.xaml
    /// </summary>
    public partial class PageCongratulation : Page
    {
        private ViewModelTest test;

        public PageCongratulation(ViewModelTest _test)
        {
            InitializeComponent();
            DataContext = null;
            test = _test;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage(test.VMUser));
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageData(test));
        }

        private void BtnNewUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}