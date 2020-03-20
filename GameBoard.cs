using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMinesweeper
{
    public class GameBoard
    {
        public enum BoardSize { Small, Medium, Large }

        public struct GameGrid { int width; int height; }

        public enum Difficulty { Easy, Normal, Hard }

    }
}
