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
        private static List<BaseCommand> commands = new List<BaseCommand>()
        {
            new DecoderCubeCommand(),
            new DecoderRandomCubeCommand()
        };

        static void Main(string[] args)
        {
            var cubeCrypto = new CubeCrypto(new Cube(4));
            var cubeStringConverter = new CubeStringConverter();
            commands.ForEach(cmd =>
            {
                cmd.CubeCrypto = cubeCrypto;
                cmd.CubeStringConverter = cubeStringConverter;
            });

            Console.WriteLine("#################################");
            Console.WriteLine("# DoublePermutation by DenKodec #");
            Console.WriteLine("#################################");
            Console.WriteLine();

            while (true)
            {
                Console.Write("=> ");
                string strCommand = Console.ReadLine();
                BaseCommand command = commands.Find(cmd => cmd.Name == strCommand);
                if (command != null)
                    command.Execute();
                else
                    Console.WriteLine("This command not found");
            }
        }
    }
}
