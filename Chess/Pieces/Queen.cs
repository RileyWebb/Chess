namespace Chess
{
    public class Queen : Piece
    {
        public Queen(Game game, Player owner) : base(game, owner)
        {
            Type = PieceType.Queen;
        }

        public override bool ValidMove(Position src, Position dest) => ValidateMove(Game, src, dest);
        
        private new static bool ValidateMove(Game game, Position src, Position dest)
        {
            if (!Board.WithinBounds(dest))
                return false;

            if (game.Board.Occupied(dest))
                return false;

            //Piece Logic
            
            return false;
        }
    }
}