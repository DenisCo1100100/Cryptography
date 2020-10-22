using DoublePermutationMethod.Command;
using System.Collections.Generic;

namespace DoublePermutationMethod
{
    class Cube
    {
        public int Size { get; private set; }

        public List<Cell> ListCels { get; private set; } = new List<Cell>();

        public Cube(int size)
        {
            Size = size;
            int number = 0;

            for (int col = 0; col < Size; col++)
            {
                for (int row = 0; row < Size; row++)
                {
                    ListCels.Add(new Cell(col, row, number));
                    number++;
                }
            }
        }

        public Cell GetCellFromList(int col, int row) => ListCels.Find(cell => cell.Row == row && cell.Col == col);
    }
}