using ClassLibraryMemento;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*TestImage test = Fabrique.FabriqueTestImage(6, 20, false);
            Console.WriteLine(test+"\n");          
            int j;
            do
            {
                Trial trialInProgress = test.TrialInProgress();
                j = 1;
                foreach (Card c in trialInProgress.ListCards)
                {
                    if (c.CurrentStatus != StatusCard.found)
                    {
                        Console.WriteLine("Première carte sélectionner : " + c.ToString() + "\n");
                        int i = j;
                        //while (i < trialInProgress.ListCards.Count && !trialInProgress.TestCard(c, trialInProgress.ListCards[i]))
                        //{
                        //    Console.WriteLine("\t-Deuxième carte sélectionner : " + trialInProgress.ListCards[i] + "Resultat = " + trialInProgress.TestCard(c, trialInProgress.ListCards[i]) + "\n");
                        //    i++;
                        //}
                        //Console.WriteLine("Carte trouvé !" + c.ToString() + "=>" + trialInProgress.ListCards[i] + "Resultat = " + trialInProgress.TestCard(c, trialInProgress.ListCards[i]) + "\n");
                        j++;
                    }
                }
            } while(!test.TestVerify());

            foreach (TrialScore s in test.GetScoresTrials())
            {
                Console.WriteLine("Essai : " + s.TrialNumber+"\nType de test : " + s.TypeTest + "\nCartes : " + s.NumberCards + "\nSon : " + s.Sound + "\nMélangé : " + s.Shuffle + "\nMouvement : " + s.Move + "\nRépétition : " + s.Repeat + "\nScore : " + s.ScoreTrial+"\n");
            }
            Console.WriteLine("Moyenne de Mouvement : " + test.AverageMove()+ "\nMoyenne Répétition : "+test.AverageRepeat()+"\nMoyenne de Score : "+test.AverageScore());
            Console.ReadKey();*/
        }
    }
}
