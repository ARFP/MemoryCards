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
    /// Logique d'interaction pour UserControlResumeScoreOneTrial.xaml
    /// </summary>
    public partial class UserControlResumeScoreOneTrial : UserControl
    {
        public int Move
        {
            get
            {
                return (int)GetValue(dependencyPropertyMove);
            }
            set
            {
                SetValue(dependencyPropertyMove, value);
            }
        }
        public static readonly DependencyProperty dependencyPropertyMove =
            DependencyProperty.Register("Move", typeof(int), typeof(UserControlResumeScoreOneTrial));

        public int Repeat
        {
            get
            {
                return (int)GetValue(dependencyPropertyRepeat);
            }
            set
            {
                SetValue(dependencyPropertyRepeat, value);
            }
        }
        public static readonly DependencyProperty dependencyPropertyRepeat =
            DependencyProperty.Register("Repeat", typeof(int), typeof(UserControlResumeScoreOneTrial));

        public double Score
        {
            get
            {
                return (double)GetValue(dependencyPropertyScore);
            }
            set
            {
                SetValue(dependencyPropertyScore, value);
            }
        }
        public static readonly DependencyProperty dependencyPropertyScore =
            DependencyProperty.Register("Score", typeof(double), typeof(UserControlResumeScoreOneTrial));

        public UserControlResumeScoreOneTrial()
        {
            InitializeComponent();
            GridUserCtrl.DataContext = this;
        }
    }
}
