using ClassLibraryControl;
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
using Xceed.Wpf.Toolkit;

namespace MemoryCards
{
    /// <summary>
    /// Logique d'interaction pour PageIdentification.xaml
    /// </summary>
    public partial class PageIdentification : Page
    {
        private ViewModelUser vmUser;

        public PageIdentification(ViewModelUser _vmUser)
        {
            InitializeComponent();
            vmUser = _vmUser;
            vmUser.CurrentDate = DateTime.Now;
            MTBCurrentDate.Text = vmUser.CurrentDate.ToString("dd/MM/yyyy HH:mm:ss");
            DataContext = vmUser;
            RBMan.IsChecked = true;      
        }

        public void BtnValidateClick(object sender, RoutedEventArgs e)
        {
            if(vmUser._validationErrors.Count == 0)
            {
                this.NavigationService.Navigate(new PageMode(vmUser));
            }
        }

        private void RBMan_Checked(object sender, RoutedEventArgs e)
        {
            vmUser.Genre = (sender as RadioButton).Content.ToString();
        }

        private void RBWoman_Checked(object sender, RoutedEventArgs e)
        {
            vmUser.Genre = (sender as RadioButton).Content.ToString();
        }

        private void TextBoxBirthDate_SelectText(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
