using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.NET
{
    /// <summary>
    /// Difficulty of game
    /// </summary>
    public enum Difficulty
    {
        Easy = 1,
        Medium = 2,
        Difficult = 3,
        Extreme = 4
    }

    class Game
    {
        /// <summary>
        /// 2 dimensional board array for this game
        /// </summary>
        private Board board { get; set; }

        /// <summary>
        /// Game difficulty
        /// </summary>
        private Difficulty difficulty { get; set; }

        /// <summary>
        /// Game timer
        /// </summary>
        private int timer { get; set; }
        
        /// <summary>
        /// Number of strikes player has recieved
        /// </summary>
        private int strikes { get; set; }

        /// <summary>
        /// Game constructor
        /// </summary>
        /// <param name="d"></param>
        public Game(int d)
        {
            this.board = new Board();
            this.difficulty = (Difficulty)d;
            this.timer = 0;
            this.strikes = 0;
        }

    }
}
