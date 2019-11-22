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
    /// Logique d'interaction pour PageData.xaml
    /// </summary>
    public partial class PageData : Page
    {
        public PageData(ViewModelTest _test)
        {
            InitializeComponent();
            DataContext = _test;
            headerTrainee.Text = "Stagiare (Age : " + _test.VMUser.Age + ")";
            ResumeEtalonnagesAllAge rea = new ResumeEtalonnagesAllAge();
            rea.Load();
            allEtalonnage.DataContext = rea;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
