using System;
using System.Drawing;
using System.Windows.Forms;
using Chess;

namespace Client
{
    public sealed class Window : Form
    {
        public Client Client;
        public Input Input;
        public Renderer Renderer;

        public bool Running;
        public DateTime last = DateTime.Now;
        public int Ticks = 0;

        //public Window(Game game) : this(game,)
        //{
        //}

        public Window(Client client)
        {
            Client = client;
            Input = new Input(this);
            Renderer = new Renderer(this);

            Text = "Chess";

            ClientSize = new Size(80*8, 80*8);

            Closing += (sender, e) =>
            {
                e.Cancel = true;
                Quit();
            };
        }

        public void Start()
        {
            Show();

            Running = true;
            while (Running)
                Update();
        }

        public void Update()
        {
            Renderer.Render();

            Application.DoEvents();

            if ((DateTime.Now - last).TotalMilliseconds > 1000)
            {
                Console.WriteLine(Ticks);
                Ticks = 0;
                last = DateTime.Now;
            }

            Ticks++;
        }

        public void Quit()
        {
            Running = false;
        }
    }
}