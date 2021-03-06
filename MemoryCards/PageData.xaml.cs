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
        private ViewModelTest vmTest;

        public PageData(ViewModelTest _test)
        {
            InitializeComponent();
            vmTest = _test;
            DataContext = vmTest;
            headerTrainee.Text = "Stagiare (Age : " + vmTest.VMUser.DateOfBirth + ")";
            ResumeEtalonnagesAllAge rea = new ResumeEtalonnagesAllAge();
            rea.Load();
            allEtalonnage.DataContext = rea;

            TBTime.Text = _test.VMUser.CurrentDate.ToString("HH:mm:ss");
            TBDate.Text = _test.VMUser.CurrentDate.ToString("dd/MM/yyyy");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage(vmTest.VMUser));
        }

        private void ButtonNewUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
