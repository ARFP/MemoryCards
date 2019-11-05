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
        ViewModelTest test;
        public PageMode()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button b)
            {
                test = new ViewModelTest(b.Tag.ToString());
            }
            if(test != null )
            {
                this.NavigationService.Navigate(new PageRuleTrial(test));
            }
        }
    }
}
