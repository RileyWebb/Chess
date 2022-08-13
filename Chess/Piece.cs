using System.Drawing;
using System.Reflection;
using System.Resources;
using Svg;

namespace Chess
{
    public abstract class Piece
    {
        public PieceType Type;
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