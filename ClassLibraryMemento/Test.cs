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
        private string testName;
        private List<Trial> listTrials;
        private int numberTrials;
        private int timer;
        private string timeInProgress;
        private int trialRun;
        private bool endTimer;
        private TestScore testScore;

        public string TestName { get => testName; set => testName = value; }
        public List<Trial> ListTrials { get => listTrials; set => listTrials = value; }
        public int NumberTrials { get => numberTrials; set => numberTrials = value; }
        public int Timer { get => timer; set => timer = value; }
        public string TimeInProgress { get => timeInProgress; set => timeInProgress = value; }
        public int TrialRun { get => trialRun; set => trialRun = value; }
        public bool EndTimer { get => endTimer; set => endTimer = value; }
        public TestScore TestScore { get => testScore; set => testScore = value; }

        #region Constructor
        public Test(string _testName, int _numberTrials, int _timer)
        {
            testName = _testName;
            listTrials = new List<Trial>();
            numberTrials = _numberTrials;
            timer = _timer;
            timeInProgress = "";
            trialRun = 0;
            endTimer = false;
            testScore.TrialsScore = new List<TrialScore>();
        }
        #endregion

        #region Trial
        public void AddTrial(List<object> _card, bool _sound)
        {
            //if (!(this is TestSound))
            for (int i = 0; i < numberTrials; i++)
            {
                if (i == 0)
                {
                    listTrials.Add(new Trial(testName ,_card, i + 1, _sound, true));
                }
                else
                {
                    listTrials.Add(new Trial(listTrials[0], i + 1));
                }
            }
        }

        public Trial TrialInProgress()
        {
            return listTrials[trialRun];
        }
        #endregion

        public bool EndTestVerify()
        {
            testScore.TrialsScore.Add(listTrials[trialRun].Score);
            if(trialRun == (numberTrials - 1))
            {
                AverageMove();
                AverageRepeat();
                AverageScore();
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
                foreach (Trial t in listTrials)
                {
                    averageRepeat += (double)t.Score.Repeat;
                }
                testScore.AvergaeRepeat = Math.Round(averageRepeat / (double)listTrials.Count, 2);
                return averageRepeat = Math.Round(averageRepeat / (double)listTrials.Count, 2);
            }

            public double AverageMove()
            {
                double averageMove = 0;

                foreach (Trial t in listTrials)
                {
                    averageMove += (double)t.Score.Move;
                }
                testScore.AverageMove = Math.Round(averageMove / (double)listTrials.Count, 2);
                return averageMove = Math.Round(averageMove / (double)listTrials.Count, 2);
            }

            public double AverageScore()
            {
                double averageScore = 0;
                foreach (Trial t in listTrials)
                {
                    averageScore += t.Score.ScoreTrial;
                }
                //Chemin sauvegarde des donées--------------------------------------------------------------------
               // System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
               testScore.AverageScore = Math.Round(averageScore / (double)listTrials.Count, 2);
                return averageScore = Math.Round(averageScore / (double)listTrials.Count, 2);
            }
            #endregion
        #endregion

        public override string ToString()
        {
            string a = "Test : " + this.GetHashCode() + "\n";
            foreach (Trial t in listTrials)
            {
                a += t.ToString() + "\n";
            }
            return a + "\n";
        }
    }
}
