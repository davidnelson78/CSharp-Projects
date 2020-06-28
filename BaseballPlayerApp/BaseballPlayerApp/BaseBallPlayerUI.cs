using System;

namespace BaseballPlayerApp
{
    internal class BaseBallPlayerUI
    {
        //MainMethod starts
        public void MainMethod()
        {
            //variable for player counter
            int counter = 1;

            //variables are created to hold the individual player data
            string firstName;
            string lastName;
            string team;
            int battingavg;

            //the user is prompted to provide the first players data
            Console.Write("\n");
            Console.WriteLine("Please enter the following data for Player 1:");
            Console.Write("\n");
            Console.Write("First Name -----> ");
            firstName = Console.ReadLine();
            Console.Write("Last Name-------> ");
            lastName = Console.ReadLine();
            Console.Write("Team Name-------> ");
            team = Console.ReadLine();
            Console.Write("Batting Average-> ");
            battingavg = int.Parse(Console.ReadLine());

            //a new instance of the BaseBallPlayer class called firstPlayer is created, called and all the user input variable data is passed into it
            BaseBallPlayer firstPlayer = new BaseBallPlayer(firstName, lastName, team, battingavg);

            //the user is prompted to provide the second players data
            Console.Write("\n");
            Console.WriteLine("Please enter the following data for Player 2:");
            Console.Write("\n");
            Console.Write("First Name -----> ");
            firstName = Console.ReadLine();
            Console.Write("Last Name-------> ");
            lastName = Console.ReadLine();
            Console.Write("Team Name-------> ");
            team = Console.ReadLine();
            Console.Write("Batting Average-> ");
            battingavg = int.Parse(Console.ReadLine());

            //a new instance of the BaseBallPlayer class called secondPlayer is created, called and all the user input variable data is passed into it
            BaseBallPlayer secondPlayer = new BaseBallPlayer(firstName, lastName, team, battingavg);

            //screen is cleared
            Console.Clear();

            //the firstPlayer instance of the PlayerInfo class is called and BaseBallPlayer data is passed into it
            Console.WriteLine("Player " + counter++ + " Info:");
            PlayerInfo(firstPlayer);
            Console.WriteLine("\n");
            Console.WriteLine("Player " + counter++ + " Info:");
            //the secondPlayer instance of the PlayerInfo class is called and BaseBallPlayer data is passed into it
            PlayerInfo(secondPlayer);
            Console.WriteLine("\n\n");
            Console.WriteLine("Press any key to exit");
        }

        public void PlayerInfo(BaseBallPlayer aPlayer)
        {
            //displays the players data stored in the BaseBallPlayer class
            Console.WriteLine();
            Console.WriteLine("First Name -------> " + aPlayer.FirstName);
            Console.WriteLine("Last Name --------> " + aPlayer.LastName);
            Console.WriteLine("Team -------------> " + aPlayer.Team);
            Console.WriteLine("Batting Average --> " + aPlayer.Battingavg);
        }
    }
}