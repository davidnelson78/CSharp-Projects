using System;

namespace TriviaGameApp
{
    internal class Controller
    {
        public void DisplayWelcome()
        {
            Console.WriteLine("\n\tWelcome to the Trivia Game!");
            Console.WriteLine("\n\tYou will be given questions to test your knowledge.");
            Console.WriteLine("\n\tUse A-D to select your answer. Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void Play()
        {
            FileIO fileIO = new FileIO();
            fileIO.DisplayFile();
            QuestionBank Questions = new QuestionBank();
            string guess;
            int correct = 0;
            int incorrect = 0;
            string line;
            string[] fields = new string[4];
            int curQuestion = 0;

            Questions.ReadQuestionFile("Questions.txt");

            while (curQuestion < 5)
            {
                Console.WriteLine("\n" + Questions.GETQuestion(curQuestion));
                line = Questions.GETAnswer(curQuestion);

                fileIO.ParseAnswers(line, ref fields);

                Console.WriteLine("\nA.) " + fields[0]);
                Console.WriteLine("B.) " + fields[1]);
                Console.WriteLine("C.) " + fields[2]);
                Console.WriteLine("D.) " + fields[3]);

                guess = PromptforGuess();

                if (guess == Questions.GETCorrectAnswer(curQuestion))
                {
                    correct += 1;
                    Console.WriteLine("\nCorrect!");
                }
                else
                {
                    incorrect += 1;
                    Console.WriteLine("\nIncorrect! The correct answer was {0}", Questions.GETCorrectAnswer(curQuestion));
                }
                Console.WriteLine(Questions.GETExplanation(curQuestion));
                curQuestion = curQuestion + 1;
                Console.WriteLine("\n\nPress enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            GameResults(correct, incorrect);
            Console.ReadLine();
        }

        private string PromptforGuess()
        {
            string guess;
            Console.WriteLine("\nSelect A - D");
            guess = Console.ReadLine();
            if (guess != null)
                guess = guess.Substring(0).ToUpper();
            return guess;
        }

        public void GameResults(int correct, int incorrect)
        {
            string play;

            Console.WriteLine("The results of your game are in!");
            Console.WriteLine("\nYou got {0} correct, and {1} incorrect.", correct, incorrect);
            Console.WriteLine("\nWould you like to play again? Y or N");
            play = Console.ReadLine();
            play = play.Substring(0).ToUpper();

            if (play == "Y")
            {
                Console.Clear();
                Play();
            }
            Console.WriteLine("\nThanks for playing the trivia game!");
        }
    }
}