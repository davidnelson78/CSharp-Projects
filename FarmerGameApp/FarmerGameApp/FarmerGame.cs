using System;
using System.Collections.Generic;

namespace FarmerGame
{
    internal class FarmerGame
    {
        public enum Direction
        {
            north,
            south
        }

        private List<string> northbank;
        private List<string> southbank;
        private Direction farmer;

        public Direction Farmer
        {
            get { return farmer; }
        }

        public bool AnimalAteFood()
        {
            bool foodEaten = false;
            bool animalEaten = false;

            if (farmer == Direction.south)
            {
                if (northbank.Contains("chicken") == true && northbank.Contains("fox") == true)
                    animalEaten = true;
                if (northbank.Contains("chicken") == true && northbank.Contains("grain") == true)
                    foodEaten = true;
            }
            else
            {
                if (southbank.Contains("chicken") == true && southbank.Contains("fox") == true)
                    animalEaten = true;
                if (southbank.Contains("chicken") == true && southbank.Contains("grain") == true)
                    foodEaten = true;
            }
            return foodEaten || animalEaten;
        }

        public bool DetermineWin()
        {
            bool winStatus = false;

            if (farmer == Direction.south)
            {
                if (southbank.Contains("chicken") == true && southbank.Contains("fox") == true && southbank.Contains("grain") == true)
                {
                    winStatus = true;
                }
            }
            return winStatus;
        }

        public FarmerGame()
        {
            northbank = new List<string>();
            southbank = new List<string>();
            farmer = Direction.north;
            northbank.Add("chicken");
            northbank.Add("grain");
            northbank.Add("fox");
        }

        public void GameOver()
        {
            Console.WriteLine("Game is over!");
        }

        public void Move(string choice)
        {
            bool check;
            if (farmer == Direction.north)
            {
                check = northbank.Remove(choice);
                if (check == true)
                    southbank.Add(choice);
                farmer = Direction.south;
            }
            else
            {
                check = southbank.Remove(choice);
                if (check == true)
                    northbank.Add(choice);
                farmer = Direction.north;
            }
        }

        public string NorthBank()
        {
            string output = "";
            foreach (string value in northbank)
            {
                output = output + " " + value;
            }
            return output;
        }

        public string SouthBank()
        {
            string output = "";
            foreach (string value in southbank)
            {
                output = output + " " + value;
            }
            return output;
        }
    }
}