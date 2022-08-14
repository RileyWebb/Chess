namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn()
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