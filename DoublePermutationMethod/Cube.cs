using DoublePermutationMethod.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod
{
    class Cube
    {
        public int Size { get; private set; }

        public List<Cell> ListCels { get; private set; } = new List<Cell>();

        public Cube(int size)
        {
            Size = size;

            for (int row = 0; row < Size; row++)
                for (int col = 0; col < Size; col++)
                    ListCels.Add(new Cell(row, col));
        }

        public Cell GetCellFromList(int row, int col) => ListCels.Find(cell => cell.Row == row && cell.Col == col);
    }
}