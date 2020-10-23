using System;

namespace DoublePermutationMethod
{
    class CubeCrypto
    {
        public Cube Cube { get; set; }
        public CubeCrypto(Cube cube) => Cube = cube;

        public void SetEncode(Key key)
        {
            int size = key.Length / 2;
            int cellIndex = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cube.ListCels[cellIndex].Col = key.ColHeader[i];
                    Cube.ListCels[cellIndex].Row = key.RowHeader[j];
                    cellIndex++;
                }
            }
        }

        public string GetEncode()
        {
            string cipher = "";
            int size = Cube.Size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    cipher += Cube.GetCellFromList(i, j).Symbol;
                }
            }

            return cipher;
        }

        public void GetDecode(Key key)
        {
            foreach (var row in key.RowHeader)
            {
                foreach (var col in key.ColHeader)
                {
                    Console.Write(Cube.GetCellFromList(row, col).Symbol);
                }
            }
        }
    }
}