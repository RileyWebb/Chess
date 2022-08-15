using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class Game
    {
        // Game Info
        public string? Event;
        public string? Location;
        public DateTime? Date;
        public Termination? Termination;
        public Mode? Mode;

        public string FEN => Chess.FEN.CreateFEN(this);
        public string PGN => Chess.PGN.CreatePGN(this);
        public string EPD => Chess.EPD.CreateEPD(this);
        
        // Game
        public int Round;
        public Player? Winner;
        public Player? Looser;
        public Result? Result;

        public List<Move> Moves;

        public Player White;
        public Player Black;
        public Player NextMove;
        public Board Board;

        public Game()
        {
        }

        // Tries To Move A Piece
        public bool Move(Move move)
        {
            if (move.Player != NextMove)
                return false;

            if (move.IsValid())
                return true;

            //move.Move(); DO MOVE
            return false;
        }
    }

    public enum Result
    {
        Checkmate, // Win By Chess Mate
        Resignation, // Win By Resignation
        WinOnTime, // Win By Time
        Forfeit, // Win By Forfeit
        Draw, // Draw
        Stalemate, // Draw By Stalemate
        Dead, // Draw By Dead Position
        Repetition, // Draw By Threefold Repetition
        FiftyMove, // Draw By Fifty Move Rule
        DrawOnTime, // Draw By Time
    }
    
    public enum Termination
    {
        Abandoned,
        Adjudication,
        Death, // How TF Does This Happen???
        Emergency,
        Normal,
        Infraction,
        TimeForfeit,
    }

    public enum Mode
    {
        OTB, // Over The Board
        ICS, // Internet Chess Server
    }
}