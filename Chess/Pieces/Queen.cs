namespace Chess
{
    public class Queen : Piece
    {
        public Queen(Game game, Player player) : base(game, player)
        {
            Unicode = '♕';
        }

        public override bool CanMove(int x, int y)
        {
            if (!base.CanMove(x, y))
                return false;

            //Piece Logic
            
            return true;
        }
    }
}