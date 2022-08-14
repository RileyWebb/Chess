using System.Drawing;
using System.Reflection;
using System.Resources;

namespace Chess
{
    public abstract class Piece
    {
        public PieceType Type;

        public virtual bool CanMove(int x, int y)
        {
            return true;
        }
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