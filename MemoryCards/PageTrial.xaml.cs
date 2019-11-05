using ClassLibraryExcel;
using ClassLibraryMemento;
using ClassLibraryViewModel;
using LibraryCommands;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MemoryCards
{
    /// <summary>
    /// Logique d'interaction pour PageTrial.xaml
    /// </summary>
    public partial class PageTrial : Page
    {
        private ViewModelTest vMTest;
        private ViewModelCard firstCard;
        private int row = 1;
        private int column = 1;
        Task tsk;
        Task tsk2;
        bool interrup;

        public PageTrial(ViewModelTest _test)
        {
            InitializeComponent();
            this.DataContext = this;
            vMTest = _test;
            int i = 0;
            trialName.Text = "Manche n°" + (vMTest.TrialRun + 1);
            foreach (ViewModelCard c in vMTest.ListTrials[vMTest.TrialRun].ListCards)
            {
                ButtonControl ControlCard = new ButtonControl();
                Binding b = new Binding();
                b.Source = c;

                ControlCard.SetBinding(ButtonControl.dependencyPropertyCard, b);
                ControlCard.Tag = i;
                ControlCard.Padding = new Thickness(5);
                ControlCard.CommandDisplay = new CmdButtonCheck(p => c.CurrentStatus == StatusCard.back, p => CardEventVerrif(c));
                gridCards.Children.Add(ControlCard);
                Grid.SetRow(ControlCard, row);
                Grid.SetColumn(ControlCard, column);
                if (column < 6)
                {
                    column++;
                }
                else
                {
                    row++;
                    column = 1;
                }
                i++;
            }
        }

        private void Button_Click()
        {
            this.NavigationService.Navigate(new TimerPage(vMTest));
        }

        private void CardEventVerrif(object sender)
        {
            if (sender is ViewModelCard vmc)
            {
                if (!interrup)
                {
                    vmc.CurrentStatus = StatusCard.face;
                    if ((firstCard == null))
                    {
                        firstCard = vmc;
                        tsk = Task.Factory.StartNew(() => Verrify(firstCard));

                    }
                    else if (firstCard != vmc && firstCard != null)
                    {
                        interrup = true;
                        tsk2 = Task.Factory.StartNew(() => Verrify(vmc));
                        vMTest.ListTrials[vMTest.TrialRun].AddMove();
                        if (vmc.Tested || firstCard.Tested)
                        {
                            vMTest.ListTrials[vMTest.TrialRun].AddRepeat();
                        }
                        if (vmc.Compare(firstCard))
                        {
                            firstCard.CurrentStatus = StatusCard.found;
                            vmc.CurrentStatus = StatusCard.found;
                            if (vMTest.ListTrials[vMTest.TrialRun].TrialFinish())
                            {
                                if(vMTest.TestVerify())
                                {
                                    Excel.WriteInExecel(vMTest);
                                    NavigationService.Navigate(new PageCongratulation(vMTest));
                                }
                                else
                                {
                                    NavigationService.Navigate(new TimerPage(vMTest));
                                }
                            }
                        }
                        else
                        {
                            vmc.Tested = true;
                            firstCard.Tested = true;
                            firstCard.CurrentStatus = StatusCard.back;
                            vmc.CurrentStatus = StatusCard.back;
                        }                      
                        firstCard = null;
                    }
                }
            }
        }

        private void Verrify(ViewModelCard vmc)
        {
            //Voir méthode affection EtatImage (Back Found Face) => CardImage par rapport a son etat
            int i = 0;
            vmc.CardImage = vmc.FaceImage;
            if (vmc.CurrentStatus == StatusCard.face)
            {
                while (i != 100 && vmc.CurrentStatus == StatusCard.face) //100
                {
                    Thread.Sleep(100);
                    i++;
                }
                if (i == 100)
                {
                    vmc.CurrentStatus = StatusCard.back;
                    firstCard = null;
                }
            }
            if (vmc.CurrentStatus == StatusCard.back)
            {
                Thread.Sleep(1000);
                vmc.CardImage = vmc.BackImage;
            }
            if (vmc.CurrentStatus == StatusCard.found)
            {
                Thread.Sleep(500);//
                if (vMTest.TrialRun != (vMTest.NumberTrials - 1))
                {  
                    vmc.CardImage = vmc.ValidateImage;
                }   
            }
            interrup = false;
        }

        private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (vMTest.TrialRun < vMTest.NumberTrials - 1)
            {
                NavigationService.Navigate(new TimerPage(vMTest));
            }
            else
            {
                NavigationService.Navigate(new PageCongratulation(vMTest));
            }
        }
    }
}