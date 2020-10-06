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

        public void SetDecoded(string message, int[,] key)
        {
            //Кодирование с вводом ключа пользователем
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
