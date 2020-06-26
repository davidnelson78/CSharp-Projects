using System;

namespace PlayerApp
{
    internal class PlayerUI
    {
        public void MainMethod()
        {
            string ln;
            string fn;
            string iden;

            int playerCnt;
            int loopCnt = 0;
            int gameCnt;

            Console.Write("\n\nHow many players?      ");  //Ask how many players are on the team
            while (int.TryParse(Console.ReadLine(), out playerCnt) == false)  //Verify that a whole number was entered
            {
                Console.WriteLine("ERROR IN INPUT\nPlease enter a whole number");
                Console.Write("\n\nHow many players?      ");
            }

            Player[] teamMember = new Player[playerCnt];  //Defining the Player Array

            while (loopCnt < playerCnt)  //Get each player's information
            {
                gameCnt = GetInfo(out ln, out fn, out iden, loopCnt);  //Need to use reference variables as GetIDInfo() can only return one variable

                teamMember[loopCnt] = new Player(ln, fn, iden, gameCnt);  //Set each element in array teamMember with the object Player - each element is a new object, the array points is also passed
                GetScores(gameCnt, teamMember[loopCnt]);        // Points is an array of 100
                loopCnt++;                                                        // The Player Constructor takes the 5 arguments
            }
            DisplayStats(teamMember);
        }

        public void GetScores(int gameCnt, Player indPlayer)
        {                                                 // This fuction reads in all of the scores for a single Player object
                                                          // and passes the values to the Player class
            int inValue;
            Console.WriteLine("");
            for (int index = 0; index < gameCnt; index++)
            {
                Console.Write("\tGame {0}:        ", index + 1);  //Enter the scores have for the player
                while (int.TryParse(Console.ReadLine(), out inValue) == false)
                {
                    Console.WriteLine("\tERROR IN INPUT\n\tPlease enter a whole number");
                    Console.Write("\tGame {0}:        ", index + 1);
                }
                indPlayer.FillPointsScoredArray(index, inValue);
            }
            Console.WriteLine("\n");
        }

        public int GetInfo(out string ln, out string fn, out string iden, int cnt)  //All parameters of GetIdInfo are set as reference parameters
        {
            int gameCount = 0;                                              //Except for gameCount, It is returned by the method
                                                                            //For a reference variable the address is received and not the value.  So if it is changed here,
            Console.WriteLine();
            cnt++;                                                           // it is changed in the calling routine
            Console.Write("Player " + cnt + "'s First Name  ");
            fn = Console.ReadLine();
            Console.Write("Player " + cnt + "'s Last Name:  ");
            ln = Console.ReadLine();
            Console.Write("Player " + cnt + "'s ID Number:  ");
            iden = Console.ReadLine();
            Console.Write("No. of Games Played:   ");
            while (int.TryParse(Console.ReadLine(), out gameCount) == false)
            {
                Console.WriteLine("ERROR IN INPUT\nPlease enter a whole number");
                Console.Write("No. of Games Played: ");
            }

            return gameCount;
        }

        public static void DisplayStats(Player[] teamMember)  //The array teamMember is passed as a paramter
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("{0,12} {1, 25}", "Player", "Avg Points");  //Ptints the heading (Right aligned 12 spaces and then another 25 spaces)
            Console.WriteLine("--------------------------------------------");
            foreach (Player pl in teamMember)                                     //Uses the foreach instruction, goingthrough every element in teamMember
                Console.WriteLine("{0, -25} {1, 7}", (pl.FName + " " + pl.LName), pl.ComputeAverage().ToString("F2"));  //The -25(left aligned since it is negative) and 7 position the output
        }
    }
}