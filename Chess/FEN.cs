using System.IO;

namespace Chess
{
    public static class FEN
    {
        public static Game Load(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            return Load(reader.ReadToEnd());
        }

        public static Game Load(string fen)
        {
            Game game = new Game();

            return game;
        }
    }
}