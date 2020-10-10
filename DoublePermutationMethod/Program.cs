using DoublePermutationMethod.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCommand commands = new DecoderCubeCommand();
            var cubeCrypto = new CubeCrypto(new Cube(4));
            var cubeStringConverter = new CubeStringConverter();
            commands.CubeStringConverter = cubeStringConverter;
            commands.CubeCrypto = cubeCrypto;
            commands.Execute();
        }
    }
}
