using System.Drawing;
using System.Reflection;
using System.Resources;

namespace Chess
{
    public abstract class Piece
    {
        public PieceType? Type;
        public Player Owner;
        public Game Game;
        
        public Piece(Game game, Player owner)
        {
            Game = game;
            Owner = owner;
        }
        
        public virtual bool ValidMove(Position src, Position dest) => Board.WithinBounds(dest);
        public static bool ValidateMove(Position src, Position dest) => Board.WithinBounds(dest);
    }

    public enum PieceType
    {
        King,
        Queen,
        Knight,
        Bishop,
        Rook,
        Pawn,
    }
}