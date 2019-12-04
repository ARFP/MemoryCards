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
    /// Logique d'interaction pour UserControlScoreOneTrial.xaml
    /// </summary>
    public partial class UserControlScoreOneTrial : UserControl
    {
        public int TrialNumber
        {
            get { return (int)GetValue(dependencyPropertyTrialNumber); }
            set { SetValue(dependencyPropertyTrialNumber, value); }
        }
        public static readonly DependencyProperty dependencyPropertyTrialNumber =
            DependencyProperty.Register("TrialNumber", typeof(int), typeof(UserControlScoreOneTrial));

        public int TypeTest
        {
            get { return (int)GetValue(dependencyPropertyTypeTest); }
            set { SetValue(dependencyPropertyTypeTest, value); }
        }
        public static readonly DependencyProperty dependencyPropertyTypeTest =
            DependencyProperty.Register("TypeTest", typeof(string), typeof(UserControlScoreOneTrial));

        public int NumbersCards
        {
            get { return (int)GetValue(dependencyPropertyNumbersCards); }
            set { SetValue(dependencyPropertyNumbersCards, value); }
        }
        public static readonly DependencyProperty dependencyPropertyNumbersCards =
            DependencyProperty.Register("NumbersCards", typeof(int), typeof(UserControlScoreOneTrial));

        public int Sound
        {
            get { return (int)GetValue(dependencyPropertySound); }
            set { SetValue(dependencyPropertySound, value); }
        }
        public static readonly DependencyProperty dependencyPropertySound =
            DependencyProperty.Register("Sound", typeof(bool), typeof(UserControlScoreOneTrial));

        public int Shuffle
        {
            get { return (int)GetValue(dependencyPropertyShuffle); }
            set { SetValue(dependencyPropertyShuffle, value); }
        }
        public static readonly DependencyProperty dependencyPropertyShuffle =
            DependencyProperty.Register("Shuffle", typeof(bool), typeof(UserControlScoreOneTrial));


        public int Move
        {
            get { return (int)GetValue(dependencyPropertyMove); }
            set { SetValue(dependencyPropertyMove, value); }
        }
        public static readonly DependencyProperty dependencyPropertyMove =
            DependencyProperty.Register("Move", typeof(int), typeof(UserControlScoreOneTrial));

        public int Repeat
        {
            get { return (int)GetValue(dependencyPropertyRepeat); }
            set { SetValue(dependencyPropertyRepeat, value); }
        }
        public static readonly DependencyProperty dependencyPropertyRepeat =
            DependencyProperty.Register("Repeat", typeof(int), typeof(UserControlScoreOneTrial));

        public int ScoreTrial
        {
            get { return (int)GetValue(dependencyPropertyScoreTrial); }
            set { SetValue(dependencyPropertyScoreTrial, value); }
        }
        public static readonly DependencyProperty dependencyPropertyScoreTrial =
            DependencyProperty.Register("ScoreTrial", typeof(double), typeof(UserControlScoreOneTrial));

        public UserControlScoreOneTrial()
        {
            InitializeComponent();
            gridUserControl.DataContext = this;
        }
    }
}
