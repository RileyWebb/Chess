namespace Chess
{
    public class Knight : Piece
    {
        public Knight() : base()
        {
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