using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryViewModel
{
    public class ViewModelTest : ObservableObject
    {
        private Test test;
        private ViewModelUser user;
        private ViewModelTrials trials;

        public string TestName { get { return test.TestName; } set { test.TestName = value; OnPropertyChanged(nameof(TestName)); } }
        public int NumberTrials { get { return test.NumberTrials; } set { test.NumberTrials = value; OnPropertyChanged(nameof(NumberTrials)); } }
        public int Timer { get { return test.Timer; } set { test.Timer = value; OnPropertyChanged(nameof(Timer)); } }
        public string TimeInProgress { get { return test.TimeInProgress; } set { test.TimeInProgress = value; OnPropertyChanged(nameof(TimeInProgress)); } }
        public int TrialRun { get { return test.TrialRun; } set { test.TrialRun = value; OnPropertyChanged(nameof(TrialRun)); } }
        public bool EndTimer { get { return test.EndTimer; } set { test.EndTimer = value; OnPropertyChanged(nameof(EndTimer)); } }
        //public TestScore TestScore { get { return test.TestScore; } set { test.TestScore = value; OnPropertyChanged(nameof(TestScore)); } }
        public ViewModelUser User { get { return user; } set { user = value; OnPropertyChanged(nameof(User)); } }
        public ViewModelTrials Trials { get { return trials; } set { trials = value; OnPropertyChanged(nameof(Trials)); } }

        public ViewModelTest(ViewModelUser _user, string _mode)
        {
            switch (_mode)
            {
                case "images":
                    test = Fabrique.FabriqueTestImage(_user, 6, 20, false);
                    break;
                case "colors":
                    test = Fabrique.FabriqueTestColor(_user, 1, 20, false);
                    break;
                case "words":
                    test = Fabrique.FabriqueTestWord(_user, 6, 20, false);
                    break;
                case "abstract":
                    test = Fabrique.FabriqueTestAbstract(_user, 6, 20, false);
                    break;
                case "sounds":
                    test = Fabrique.FabriqueTestSound(_user, 6, 20, false);
                    break;
                case "numbers":
                    test = Fabrique.FabriqueTestNumber(_user, 6, 20, false);
                    break;
                case "digits":
                    test = Fabrique.FabriqueTestDigit(_user, 6, 20, false);
                    break;
                default:
                    break;
            }
            user = new ViewModelUser(test.User);
            trials = new ViewModelTrials(test.Trials);
        }

        //public double AverageRepeat()
        //{
        //    return test.AverageRepeat();
        //}

        //public double AverageMove()
        //{
        //    return test.AverageMove();
        //}

        //public double AverageScore()
        //{
        //    return test.AverageScore();
        //}

        public bool TestVerify()
        {
            return test.EndTestVerify();
        }

        public bool Save()
        {
            return test.Save();
        }

        public void TimerUpdate()
        {
            int seconds;
            int minutes;
            var watch = Stopwatch.StartNew();

            if (TrialRun != NumberTrials - 2)
            {
                seconds = Timer;
                TimeInProgress = "00 : " + seconds;
                for (int i = 0; i < Timer; i++)
                {
                    Thread.Sleep(1000);
                    seconds = Timer - watch.Elapsed.Seconds;
                    if (seconds < 10)
                    {
                        TimeInProgress = "00 : 0" + seconds;
                    }
                    else
                    {
                        TimeInProgress = "00 : " + seconds;
                    }
                }
            }
            else
            {
                minutes = Timer - 1;
                seconds = 59;
                TimeInProgress = minutes + " : " + seconds;
                while (minutes != 0 || seconds != 0)
                {
                    Thread.Sleep(1000);
                    seconds = 59 - watch.Elapsed.Seconds;
                    minutes = (Timer - 1) - watch.Elapsed.Minutes;
                    if (minutes < 10 && seconds < 10)
                    {
                        TimeInProgress = "0" + minutes + " : " + "0" + seconds;
                    }
                    else if (minutes < 10)
                    {
                        TimeInProgress = "0" + minutes + " : " + seconds;
                    }
                    else if (seconds < 10)
                    {
                        TimeInProgress = minutes + " : " + "0" + seconds;
                    }
                    else
                    {
                        TimeInProgress = minutes + " : " + seconds;
                    }
                }
            }
            watch.Stop();
            EndTimer = true;
        }
    }
}
