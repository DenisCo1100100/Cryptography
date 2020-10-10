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
                    Cube.ListCels[cellIndex].Col = i;
                    Cube.ListCels[cellIndex].Row = j;
                    cellIndex++;
                }
            }

            foreach (var item in Cube.ListCels)
            {
                Console.WriteLine(item.Col + " " + item.Row + " " + item.Symbol);
            }
            Console.ReadKey();
        }

        public void GetDecoded(string message, int[,] key)
        {

        }

        public void SetDecoded(string message)
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