namespace Chess
{
    public class Bishop : Piece
    {
        public Bishop(Game game, Player player) : base(game, player)
        {
            Unicode = '♗';
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