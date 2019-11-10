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
    /// Logique d'interaction pour UserControlRangeEtalonnage.xaml
    /// </summary>
    public partial class UserControlRangeEtalonnage : UserControl
    {
        public string Trial
        {
            get { return (string)GetValue(dependencyPropertyTrial); }
            set { SetValue(dependencyPropertyTrial, value); }
        }
        public static readonly DependencyProperty dependencyPropertyTrial =
            DependencyProperty.Register("Trial", typeof(string), typeof(UserControlRangeEtalonnage));
        public string AverageMove
        {
            get { return (string)GetValue(dependencyPropertyAverageMove); }
            set { SetValue(dependencyPropertyAverageMove, value); }
        }
        public static readonly DependencyProperty dependencyPropertyAverageMove =
            DependencyProperty.Register("AverageMove", typeof(string), typeof(UserControlRangeEtalonnage));
        public string SDMove
        {
            get { return (string)GetValue(dependencyPropertySDMove); }
            set { SetValue(dependencyPropertySDMove, value); }
        }
        public static readonly DependencyProperty dependencyPropertySDMove =
            DependencyProperty.Register("SDMove", typeof(string), typeof(UserControlRangeEtalonnage));
        public string AverageRepeat
        {
            get { return (string)GetValue(dependencyPropertyAverageRepeat); }
            set { SetValue(dependencyPropertyAverageRepeat, value); }
        }
        public static readonly DependencyProperty dependencyPropertyAverageRepeat =
            DependencyProperty.Register("AverageRepeat", typeof(string), typeof(UserControlRangeEtalonnage));
        public string SDRepeat
        {
            get { return (string)GetValue(dependencyPropertySDRepeat); }
            set { SetValue(dependencyPropertySDRepeat, value); }
        }
        public static readonly DependencyProperty dependencyPropertySDRepeat =
            DependencyProperty.Register("SDRepeat", typeof(string), typeof(UserControlRangeEtalonnage));
        public string AverageScore
        {
            get { return (string)GetValue(dependencyPropertyAverageScore); }
            set { SetValue(dependencyPropertyAverageScore, value); }
        }
        public static readonly DependencyProperty dependencyPropertyAverageScore =
            DependencyProperty.Register("AverageScore", typeof(string), typeof(UserControlRangeEtalonnage));
        public string SDScore
        {
            get { return (string)GetValue(dependencyPropertySDScore); }
            set { SetValue(dependencyPropertySDScore, value); }
        }
        public static readonly DependencyProperty dependencyPropertySDScore =
            DependencyProperty.Register("SDScore", typeof(string), typeof(UserControlRangeEtalonnage));
        public UserControlRangeEtalonnage()
        {
            InitializeComponent();
            gridUserControl.DataContext = this;
        }
    }
}
