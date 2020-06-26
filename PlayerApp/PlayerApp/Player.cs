namespace PlayerApp
{
    internal class Player
    {
        private string lname;
        private string fname;
        private string id;
        private int[] pointsScored;  //The array is declared by not created
        private int numberOfGames;

        public Player()
        {
        }

        public Player(string ln, string fn, string iden, int noOfGames)
        {
            lname = ln;
            fname = fn;
            id = iden;
            numberOfGames = noOfGames;
            pointsScored = new int[noOfGames];  //The array is created when the number of games for the player is known
        }

        public string FName
        {
            get
            {
                return fname;
            }
        }

        public string LName
        {
            get
            {
                return lname;
            }
        }

        public string ID
        {
            get
            {
                return id;
            }
        }

        public int NumberOfGames
        {
            get
            {
                return numberOfGames;
            }
        }

        public int[] PointsScored
        {
            get
            {
                return pointsScored;
            }
        }

        public void FillPointsScoredArray(int index, int gamePoints)  //The array s containing the points scored in each game is a parameter
        {
            pointsScored[index] = gamePoints;  //The array is created with length being numberOfGames
        }

        public double ComputeAverage()
        {
            double total = 0;
            double avg;

            foreach (int s in pointsScored)  //The foreach instruction is used
                total += s;

            if (pointsScored.Length > 0)
                avg = total / pointsScored.Length;
            else
                avg = 0;

            return avg;
        }

        public override string ToString()
        {
            return "Player Name: " + fname + " " + lname + "\nPlayer ID: " + id + "\nNumber of Games: " + numberOfGames + "\nAverage Points Scored per Game: " + ComputeAverage().ToString("F2");
        }
    }
}