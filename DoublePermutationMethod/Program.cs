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
            BaseCommand command = new DecoderRandomCubeCommand();
            var cubeCrypto = new CubeCrypto(new Cube(4));
            var cubeStringConverter = new CubeStringConverter();
            command.CubeStringConverter = cubeStringConverter;
            command.CubeCrypto = cubeCrypto;
            command.Execute();
        }
    }
}
