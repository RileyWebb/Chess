using System;

namespace Chess
{
    public class Board
    {
        public static int Width = 8, Height = 8;
        public Piece[,] Pieces = new Piece[Width, Height];

        private Player White;
        private Player Black;

        public Board(Game game)
        {
            White = game.White;
            Black = game.Black;
        }

        //public Piece GetPiece(int x, int y) => Pieces[(y << 3) + x];

        public static bool WithinBounds(Position dest)
        {
            throw new NotImplementedException();
        }

        public bool Occupied(Position dest) => Pieces[dest.X, dest.Y] != null;
    }
}