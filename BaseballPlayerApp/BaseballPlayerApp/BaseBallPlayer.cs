namespace BaseballPlayerApp
{
    internal class BaseBallPlayer
    {
        //varaiables only used by this class are created to hold each players data
        private string firstName;

        private string lastName;
        private string team;
        private int battingavg;

        //assigns the user input data to "like" variables, specific to this player
        public BaseBallPlayer(string firstName, string lastName, string team, int battingavg)
        {
            FirstName = firstName;
            LastName = lastName;
            Team = team;
            Battingavg = battingavg;
        }

        //player data setters and getters
        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }

        public string Team
        {
            set
            {
                team = value;
            }
            get
            {
                return team;
            }
        }

        public int Battingavg
        {
            set
            {
                battingavg = value;
            }
            get
            {
                return battingavg;
            }
        }
    }
}