namespace Chess
{
    public class Rook : Piece
    {
        public Rook()
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