namespace TicTacToeGame
{
    internal abstract class Player
    {
        private const int NUM_PIECES = 2;
        private char[] PIECES = new char[NUM_PIECES] { 'X', 'O' };
        private static int current;
        protected char m_piece;

        public Player()
        {
            m_piece = PIECES[current];
            current = (current + 1) % NUM_PIECES;
        }

        public char GetPiece()
        {
            return m_piece;
        }

        public abstract void MakeMove(ref TicTacToeLogic aBoard);
    }
}