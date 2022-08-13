namespace Chess
{
    public class King : Piece
    {
        public King(Game game, Player player) : base(game, player)
        {
            Unicode = '♔';
        }

        public override bool CanMove(int x, int y)
        {
            if (!base.CanMove(x, y))
                return false;

            if ((x - X <= 1 && x - X >= -1) && (y - Y <= 1 && y - Y >= -1))
                return true;
            //Piece Logic
            
            return false;
        }
    }
}