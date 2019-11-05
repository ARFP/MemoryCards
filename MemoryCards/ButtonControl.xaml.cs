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
    /// Logique d'interaction pour ButtonControl.xaml
    /// </summary>
    public partial class ButtonControl : UserControl
    {
        public ViewModelCard VMCard
        {
            get { return (ViewModelCard)GetValue(dependencyPropertyCard); }
            set { SetValue(dependencyPropertyCard, value); }
        }

        public static readonly DependencyProperty dependencyPropertyCard =
            DependencyProperty.Register("vMcard", typeof(ViewModelCard), typeof(ButtonControl));

        public ICommand CommandDisplay
        {
            get { return (ICommand)GetValue(dependencyPropertyCommandDisplay); }
            set { SetValue(dependencyPropertyCommandDisplay, value); }
        }

        public static readonly DependencyProperty dependencyPropertyCommandDisplay =
            DependencyProperty.Register("commandDisplay", typeof(ICommand), typeof(ButtonControl));

        public ButtonControl()
        {
            InitializeComponent();
            UserControlCard.DataContext = this;
        }
    }
}