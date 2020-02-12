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

        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Task t = Task.Run(() => test.TimerUpdate());
        //}

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Task t = Task.Run(() =>
                {
                    int seconds;
                    int minutes;
                    var watch = Stopwatch.StartNew();

                    if (test.TrialRun != test.NumberTrials - 1)
                    {
                        seconds = test.Timer;
                        test.TimeInProgress = "00 : " + seconds;
                        for (int i = 0; i < test.Timer; i++)
                        {
                            Thread.Sleep(1000);
                            seconds = test.Timer - watch.Elapsed.Seconds;
                            if (seconds < 10)
                            {
                                test.TimeInProgress = "00 : 0" + seconds;
                            }
                            else
                            {
                                test.TimeInProgress = "00 : " + seconds;
                            }
                        }
                    }
                    else
                    {
                        minutes = test.Timer - 1;
                        seconds = 59;
                        test.TimeInProgress = minutes + " : " + seconds;
                        while (minutes != 0 || seconds != 0)
                        {
                            Thread.Sleep(1000);
                            seconds = 59 - watch.Elapsed.Seconds;
                            minutes = (test.Timer - 1) - watch.Elapsed.Minutes;
                            if (minutes < 10 && seconds < 10)
                            {
                                test.TimeInProgress = "0" + minutes + " : " + "0" + seconds;
                            }
                            else if (minutes < 10)
                            {
                                test.TimeInProgress = "0" + minutes + " : " + seconds;
                            }
                            else if (seconds < 10)
                            {
                                test.TimeInProgress = minutes + " : " + "0" + seconds;
                            }
                            else
                            {
                                test.TimeInProgress = minutes + " : " + seconds;
                            }
                        }
                    }
                    watch.Stop();
                    test.EndTimer = true;
                }
            );
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

