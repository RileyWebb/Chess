using System;

namespace Chess
{
    public class Board
    {
        public const int Width = 8, Height = 8;
        public Piece[,] Pieces = new Piece[Width, Height];

        public void LoadFEN(string fen)
        {
            Player p;
            int x = 0, y = 0; 
                
            if (Char.IsUpper(c))
                p = PlayerWhite;
            else
                p = PlayerBlack;
            
            foreach (char c in fen.ToCharArray())
            {
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