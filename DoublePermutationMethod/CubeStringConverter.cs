using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod
{
    class CubeStringConverter
    {
        public Cube StringToCube(string message, int[,] key)
        {
            int size = key.Length / 2;
            var cube = new Cube(size);

            for (int i = 0; i < message.Length; i++)
            {
                cube.ListCels[i].Symbol = message[i];
            }

            return cube;
        }
    }
}
