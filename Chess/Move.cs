using System;

namespace Chess
{
    public struct Move
    {
        public Player Player;
        public Piece Piece;
        public Position To;
        public Position From;


        public Move(Player player, Piece piece, Position to, Position @from)
        {
            Player = player;
            Piece = piece;
            To = to;
            From = @from;
        }

        public bool IsValid() => Piece.ValidMove(To, From);
    }
}