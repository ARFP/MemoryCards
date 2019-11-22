using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryMemento
{
    public abstract class Test
    {
        private IPersistanceTestScore iPersistance;
        private string testName;
        private Trials trials;
        private int numberTrials;
        private int timer;
        private string timeInProgress;
        private int trialRun;
        private bool endTimer;
        private User user;

        public User User { get => user; set => user = value; }
        public string TestName { get => testName; set => testName = value; }
        
        public int NumberTrials { get => numberTrials; set => numberTrials = value; }
        public int Timer { get => timer; set => timer = value; }
        public string TimeInProgress { get => timeInProgress; set => timeInProgress = value; }
        public int TrialRun { get => trialRun; set => trialRun = value; }
        public bool EndTimer { get => endTimer; set => endTimer = value; }
        public Trials Trials { get => trials; set => trials = value; }

        #region Constructor
        public Test(User _user, string _testName, int _numberTrials, int _timer)
        {
            user = _user;
            iPersistance = new Persistance();
            testName = _testName;
            trials = new Trials(_user.FirstName + _user.LastName);
            numberTrials = _numberTrials;
            timer = _timer;
            timeInProgress = "";
            trialRun = 0;
            endTimer = false;
        }

        public static implicit operator sTestScore(Test _test)
        {
            return new sTestScore
            {
                AverageMove = _test.AverageMove(),
                AverageRepeat = _test.AverageRepeat(),
                AverageScore = _test.AverageScore(),
            };
        }
        #endregion

        #region Trial
        public void AddTrial(List<object> _card, bool _sound)
        {
            for (int i = 0; i < numberTrials; i++)
            {
                if (i == 0)
                {
                    trials.LTrial.Add(new Trial(testName, _card, i + 1, _sound, true));
                }
                else
                {
                    trials.LTrial.Add(new Trial(trials.LTrial[0], i + 1));
                }
            }
        }

        public Trial TrialInProgress()
        {
            return trials.LTrial[trialRun];
        }
        #endregion

        public bool EndTestVerify()
        {
            if(trialRun == (numberTrials - 1))
            {
                return true;
            }
            trialRun++;
            return false;
        }

        #region Score
        #region Average
        public double AverageRepeat()
        {
            double averageRepeat = 0;
            foreach (Trial t in trials.LTrial)
            {
                averageRepeat += (double)t.Repeat;
            }
            return Math.Round(averageRepeat / (double)trials.LTrial.Count, 2);
        }

        public double AverageMove()
        {
            double averageMove = 0;

            foreach (Trial t in trials.LTrial)
            {
                averageMove += (double)t.Move;
            }
            return Math.Round(averageMove / (double)trials.LTrial.Count, 2);
        }

        public double AverageScore()
        {
            double averageScore = 0;
            foreach (Trial t in trials.LTrial)
            {
                averageScore += t.ScoreTrial();
            }
            return Math.Round(averageScore / (double)trials.LTrial.Count, 2);
        }

        public bool Save()
        {
            return iPersistance.Write(this, user.FirstName + user.LastName);
        }
        #endregion
        #endregion

        public override string ToString()
        {
            string a = "Test : " + this.GetHashCode() + "\n";
            foreach (Trial t in trials.LTrial)
            {
                a += t.ToString() + "\n";
            }
            return a + "\n";
        }
    }
}
