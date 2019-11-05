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
    /// Logique d'interaction pour PageRuleTrial.xaml
    /// </summary>
    public partial class PageRuleTrial : Page
    {
        private ViewModelTest test;

        public PageRuleTrial(ViewModelTest _test)
        {
            InitializeComponent();
            test = _test;
        }

        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageTrial(test));

        }
    }
}
