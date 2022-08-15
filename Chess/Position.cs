namespace Chess
{
    public class Position
    {
        public int X, Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public static Position operator +(Position a, Position b) => new (a.X + b.X, a.Y + b.Y);
        public static Position operator -(Position a, Position b) => new (a.X - b.X, a.Y - b.Y);
        public static Position operator *(Position a, Position b) => new (a.X * b.X, a.Y * b.Y);
        public static Position operator /(Position a, Position b) => new (a.X / b.X, a.Y / b.Y);
    }
}