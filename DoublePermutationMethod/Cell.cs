using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod.Command
{
    class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Number { get; set; }
        public char Symbol { get; set; }
        public Cell(int row, int col, int number = 0, char symbol = '_')
        {
            Row = row;
            Col = col;
            Number = number;
            Symbol = symbol;
        }
    }
}
