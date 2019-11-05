using ClassLibraryExcel;
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
            TrialEtalonnage t = Excel.ReadEtalonnage(20);//Excel tab etalonnage
            listViewTrialScore.ItemsSource = _test.TestScore.TrialsScore;
            listViewAverageScore.ItemsSource = _test.TestScore.TrialsScore;
            AverageMoveTB.DataContext = _test.TestScore.AverageMove;
            AverageRepeatTB.DataContext = _test.TestScore.AvergaeRepeat;
            AverageScoreTB.DataContext = _test.TestScore.AverageScore;
            ResumeAverageMoveTB.Text = _test.TestScore.AverageMove.ToString();
            ResumeAverageRepeatTB.Text = _test.TestScore.AvergaeRepeat.ToString();
            ResumeAverageScoreTB.Text = _test.TestScore.AverageScore.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
