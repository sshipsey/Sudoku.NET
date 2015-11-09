using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.NET
{
    class Board
    {
        /// <summary>
        /// Board state
        /// </summary>
        private int[,] state { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Board()
        {
         
        }

        private void GenerateRandomBoard()
        {
            Random r = new Random();
            int c = 0;
            foreach (int i in this.state)
            {
                this.state[c / 9, c % 9] = GenerateRandomSquare(c);
                c++;
            }
        }

        private int GenerateRandomSquare(int i)
        {
            int square = 0;
            
            // Create collection of occupied numbers for this space
            List<int> unavailable = new List<int>();

            unavailable.AddRange(GetRow(i));
            // Get sector
            int sector = (((i % 9) / 3) + 1) + (3 * ((i / 9) / 3));

            return square;
        }
        private List<int> GetRow(int i)
        {
            List<int> retList = new List<int>();

            int row = i % 9;


            return retList;

        }

        private List<int> IndexToCoods(int i)
        {
            return new List<int> { i % 9, i / 9 };
        }

        private int CoordsToIndex(List<int> c)
        {
            return c[0] + (c[1] * 9);
        }

        public override string ToString()
        {
            string boardString = "";

            return boardString;
        }
    }
}
