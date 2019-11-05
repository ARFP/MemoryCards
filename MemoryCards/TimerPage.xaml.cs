using ClassLibraryViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace MemoryCards
{
    /// <summary>
    /// Logique d'interaction pour TimerPage.xaml
    /// </summary>
    public partial class TimerPage : Page
    {
        private ViewModelTest test;

        public TimerPage(ViewModelTest _test)
        {        
            InitializeComponent();
            test = _test;
            test.EndTimer = false;
            DataContext = test;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Task t = Task.Run(() => test.TimerUpdate());
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //test.TrialRun++;
            NavigationService.Navigate(new PageTrial(test));
        }

        private void ContentControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Btn_Click(sender, e);
        }
    }

}

