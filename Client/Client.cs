using Chess;

namespace Client
{
    public class Client
    {
        public int ID;

        public Game? Current;
        public Window Window;

        public Client()
        {
            Current = new Game();
            Window = new Window(this);
        }

        public void Start()
        {
            Window.Start();
        }
    }
}