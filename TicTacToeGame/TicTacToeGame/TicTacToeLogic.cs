namespace TicTacToeGame
{
    class TicTacToeLogic
    {
        private const int NUM_SQUARE = 9;
        private const char EMPTY = ' ';
        public char[] m_Square = new char[NUM_SQUARE];
        private const int NUM_COMBO = 8;
        private const int NUM_IN_COMBO = 3;

        private int[,] WINNING_COMBOS = new int[NUM_COMBO, NUM_IN_COMBO] {{0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}};

        public char[] PlayingBoard
        {
            get { return m_Square; }
        }

        public TicTacToeLogic()
        {
            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < NUM_SQUARE; ++i)
            {
                m_Square[i] = EMPTY;
            }
        }

        public bool IsFull()
        {
            bool full = true;
            int i = 0;
            while (full && i < NUM_SQUARE)
            {
                if (m_Square[i] == EMPTY)
                {
                    full = false;
                }

                ++i;
            }

            return full;
        }

        public bool IsLegalMove(int move)
        {
            return (move >= 0 && move < NUM_SQUARE && m_Square[move] == EMPTY);
        }

        public bool IsWinner(char piece)
        {
            bool winner = false;
            int i = 0;

            while (!winner && i < NUM_COMBO)
            {
                int piecesInCombo = 0;
                for (int j = 0; j < NUM_IN_COMBO; ++j)
                {
                    if (m_Square[WINNING_COMBOS[i, j]] == piece)
                    {
                        ++piecesInCombo;
                    }
                }

                if (piecesInCombo == NUM_IN_COMBO)
                {
                    winner = true;
                }

                ++i;
            }
            return winner;
        }

        public void ReceiveMove(char piece, int move)
        {
            m_Square[move] = piece;
        }
    }
}