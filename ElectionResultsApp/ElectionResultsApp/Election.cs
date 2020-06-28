namespace ElectionResultsApp
{
    internal class Election
    {
        public Election(int[] votes)
        {
            this.votes = votes;
        }

        public Election()
        {
        }

        private string[] candidates = new string[5];
        private int[] votes = new int[5];

        public const int NUM_OF_CANDIDATES = 5;

        public string[] Candidates { get => candidates; set => candidates = value; }
        public int[] Votes { get => votes; set => votes = value; }

        public void FindWinner()
        {
        }

        public void TotalVotes()
        {
        }
    }
}