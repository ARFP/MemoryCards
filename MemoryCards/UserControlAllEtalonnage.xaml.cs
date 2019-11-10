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
    /// Logique d'interaction pour UserControlAllEtalonnage.xaml
    /// </summary>
    public partial class UserControlAllEtalonnage : UserControl
    {
        public string AgeRange
        {
            get { return (string)GetValue(dependencyPropertyAgeRange); }
            set { SetValue(dependencyPropertyAgeRange, value); }
        }
        public static readonly DependencyProperty dependencyPropertyAgeRange =
            DependencyProperty.Register("AgeRange", typeof(string), typeof(UserControlAllEtalonnage));
        public string NumberPersoneTest
        {
            get { return (string)GetValue(dependencyPropertyNumberPersoneTest); }
            set { SetValue(dependencyPropertyNumberPersoneTest, value); }
        }
        public static readonly DependencyProperty dependencyPropertyNumberPersoneTest =
            DependencyProperty.Register("NumberPersoneTest", typeof(string), typeof(UserControlAllEtalonnage));
        public string AverageAge
        {
            get { return (string)GetValue(dependencyPropertyAverageAge); }
            set { SetValue(dependencyPropertyAverageAge, value); }
        }
        public static readonly DependencyProperty dependencyPropertyAverageAge =
            DependencyProperty.Register("AverageAge", typeof(string), typeof(UserControlAllEtalonnage));
        public string SDAge
        {
            get { return (string)GetValue(dependencyPropertySDAge); }
            set { SetValue(dependencyPropertySDAge, value); }
        }
        public static readonly DependencyProperty dependencyPropertySDAge =
            DependencyProperty.Register("SDAge", typeof(string), typeof(UserControlAllEtalonnage));
        public UserControlAllEtalonnage()
        {
            InitializeComponent();
            gridUserControl.DataContext = this;
        }
    }
}
