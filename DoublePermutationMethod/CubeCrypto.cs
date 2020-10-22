namespace DoublePermutationMethod
{
    class CubeCrypto
    {
        public Cube Cube { get; set; }
        public CubeCrypto(Cube cube) => Cube = cube;

        #region DECODER
        public void SetDecoded(Key key)
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

        public string GetDecoded()
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
        #endregion

        public void SetEncoder(string message, int[,] key)
        {
            //Декодирование
        }

        public void GetEncoder(string message, int[,] key)
        {
            //Декодирование
        }
    }
}