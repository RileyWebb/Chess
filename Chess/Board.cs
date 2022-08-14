using System;

namespace Chess
{
    public class Board
    {
        public static int Width = 8, Height = 8;
        public Piece[,] Pieces = new Piece[Width, Height];

        private Player PlayerWhite;
        private Player PlayerBlack;

        public Board(Player white, Player black)
        {
            
        }

        public void LoadFEN(string fen)
        {
            Player p;
            int x = 0, y = 0;

            foreach (char c in fen.ToCharArray())
            {
                if (Char.IsUpper(c))
                    p = PlayerWhite;
                else
                    p = PlayerBlack;
                
                switch (Char.ToLower(c))
                {
                    case 'r': break;
                    case '/': y++; break;
                    default:
                        if (char.IsNumber(c))
                            x += (int)c;
                        break;
                }
            }
        }
    }
}