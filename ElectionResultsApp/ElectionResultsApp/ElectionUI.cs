using System;

namespace ElectionResultsApp
{
    internal class ElectionUI
    {
        public void MainMethod()
        {
            Election theElection = new Election();

            for (int i = 0; i < 5; ++i)
            {
                PromptforString(theElection);
                PromptforInt(theElection);
            }
        }

        public void DisplayResults(Election theElection)
        {
            for (int i = 0; i < 5; ++i)
            {
            }
        }

        public void PromptforInt(Election theElection)
        {
            for (int i = 0; i < 5; ++i)
            {
                int votes;

                Console.WriteLine("Enter the number of votes for the candidate {0}:" + (i + 1));
                while (int.TryParse(Console.ReadLine(), out votes) == false)
                {
                    Console.WriteLine("\nYou entered an invalid response!  Please try again\n\n");
                    Console.WriteLine("Enter the number of votes for the candidate {0}:" + (i + 1));
                }
                theElection.Votes(votes);
            }
        }

        public void PromptforString(Election theElection)
        {
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("\n Please enter the name of the candidate {0}: " + (i + 1));
                theElection.Candidates = Console.ReadLine().Split(' ');
            }
        }
    }
}