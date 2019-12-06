using ClassLibraryMemento;
using ClassLibraryViewModel;
using LibraryCommands;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
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
        private System.Media.SoundPlayer player;

        public PageTrial(ViewModelTest _test)
        {
            InitializeComponent();
            this.DataContext = this;
            vMTest = _test;
            int i = 0;
            trialName.Text = "Manche n°" + (vMTest.TrialRun + 1);
            foreach (ViewModelCard c in vMTest.VMTrials.LVMTrial[vMTest.TrialRun].ListCards)
            {
                ButtonControl ControlCard = new ButtonControl();
                Binding b = new Binding
                {
                    Source = c,                   
                };
                ControlCard.SetBinding(ButtonControl.dependencyPropertyCard, b);

                Binding b3 = new Binding
                {                   
                    Source = c.CurrentStatus,
                };
                ControlCard.SetBinding(ButtonControl.dependencyPropertyStatuCard, b3);

                //Binding b2 = new Binding
                //{
                //    Source = new ImageBrush
                //        (
                //            Imaging.CreateBitmapSourceFromHBitmap
                //                (
                //                    SearchResources.ImageValueOf(c.CardImage).GetHbitmap(),
                //                    IntPtr.Zero,
                //                    Int32Rect.Empty,
                //                    BitmapSizeOptions.FromEmptyOptions()
                //                )
                //        )
                //};
                //ControlCard.SetBinding(ButtonControl.dependencyPropertyCardImage, b2);

                ControlCard.Tag = i;
                ControlCard.Padding = new Thickness(5);
                ControlCard.CommandDisplay = new CmdButtonCheck(p => c.CurrentStatus == StatusCard.back, p => CardEventVerrif(ControlCard));
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
            player = new System.Media.SoundPlayer();
        }

        private void Button_Click()
        {
            this.NavigationService.Navigate(new TimerPage(vMTest));
        }

        private void CardEventVerrif(object sender)
        {
            if (sender is ButtonControl se)
            {
                if (se.VMCard is ViewModelCard vmc)
                {
                    if (!interrup)
                    {
                        vmc.CurrentStatus = StatusCard.face;
                        se.StatuCard = vmc.CurrentStatus;
                        if (vMTest.TestName == "Sons")
                        {
                            player.Stream = SearchResources.SoundValueOf(vmc.FaceImage);
                            player.Play();
                        }
                        if ((firstCard == null))
                        {
                            firstCard = vmc;
                            tsk = Task.Factory.StartNew(() => Verrify(firstCard));

                        }
                        else if (firstCard != vmc && firstCard != null)
                        {
                            interrup = true;
                            tsk2 = Task.Factory.StartNew(() => Verrify(vmc));
                            vMTest.VMTrials.LVMTrial[vMTest.TrialRun].AddMove();
                            if (vmc.Compare(firstCard))
                            {
                                firstCard.CurrentStatus = StatusCard.found;
                                vmc.CurrentStatus = StatusCard.found;
                                if (vMTest.VMTrials.LVMTrial[vMTest.TrialRun].TrialFinish())
                                {
                                    if (vMTest.TestVerify())
                                    {
                                        //Classe AllEtalonnage Crécation après validation ref user création page user champ
                                        vMTest.VMEtalonnages.Load(vMTest.VMUser.Age);
                                        vMTest.VMEtalonnages.Save(vMTest.VMUser.FirstName + vMTest.VMUser.LastName);
                                        vMTest.Save();
                                        vMTest.VMTrials.Save();
                                        vMTest.VMUser.Save();
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
                                if (vMTest.TrialRun == 0)
                                {
                                    if (vmc.Tested && firstCard.Tested)
                                    {
                                        vMTest.VMTrials.LVMTrial[vMTest.TrialRun].AddRepeat();
                                    }
                                }
                                else
                                {
                                    if (vmc.Tested || firstCard.Tested)
                                    {
                                        vMTest.VMTrials.LVMTrial[vMTest.TrialRun].AddRepeat();
                                    }
                                }
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
        }

        private void Verrify(ViewModelCard vmc)
        {
            //Voir méthode affection EtatImage (Back Found Face) => CardImage par rapport a son etat?
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