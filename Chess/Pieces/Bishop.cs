namespace Chess
{
    public class Bishop : Piece
    {
        public Bishop() : base()
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