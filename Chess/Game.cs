using System;

namespace Chess
{
    public class Game
    {
        public string Event;
        public string Location;
        public DateTime Date;
        public int Round;

        public Player PlayerWhite;
        public Player PlayerBlack;
        public Board Board;

        public Game()
        {
            
        }
    }
}