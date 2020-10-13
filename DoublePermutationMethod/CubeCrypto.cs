using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod
{
    class CubeCrypto
    {
        public Cube Cube { get; set; }
        public CubeCrypto(Cube cube) => Cube = cube;

        public void SetDecoded(int[,] key)
        {
            int size = key.Length / 2;
            int cellIndex = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cube.ListCels[cellIndex].Col = key[0, i];
                    Cube.ListCels[cellIndex].Row = key[1, j];
                    cellIndex++;
                }
            }

            foreach (var item in Cube.ListCels)
            {
                Console.WriteLine(item.Col + " " + item.Row);
            }

            Console.ReadLine();
        }

        public string GetDecoded(int[,] key)
        {
            string cipher = "";
            int size = key.Length / 2;
            int col;
            int row = 0;

            for (int i = 0; i < 2; i++)
            {
                col = key[0, row];
                for (int j = 0; j < size; j++)
                {
                    cipher += Cube.GetCellFromList(col, key[1, j]).Symbol;
                }

                row++;
            }

            Console.WriteLine(cipher);
            Console.ReadKey();

            return cipher;
        }

        public void GetDecoded(string message)
        {
            //Кодирование с рандомной генерацией ключа
        }

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