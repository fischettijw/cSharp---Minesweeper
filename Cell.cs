using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMinesweeper
{
   public class Cell
    {
        public int Row { get; }
        public int Col { get; }
        public bool HasBeenVisited { get; set; }
        public bool IsBomb { get; set; }
        public int NumAdjacentBombs { get; set; }

        public Cell(int row, int col)
        {
            Row = row;
            Col = col;
            HasBeenVisited = false;
            IsBomb = false;
            NumAdjacentBombs = 0;
        }
    }
}
