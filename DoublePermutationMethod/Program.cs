using DoublePermutationMethod.Command;
using System;
using System.Collections.Generic;

namespace DoublePermutationMethod
{
    class Program
    {
        private static List<BaseCommand> commands = new List<BaseCommand>()
        {
            new DecoderCubeCommand(),
            new EncoderCubeCommand(),
            new EncoderRandomCubeCommand(),
            new HelpCommand()
        };

        static void Main(string[] args)
        {
            var cubeCrypto = new CubeCrypto(new Cube(4));
            var cubeToStringConverter = new CubeToStringConverter();
            var keyStringConverter = new KeyStringConverter();
            var keyGenerator = new KeyGenerator();
            commands.ForEach(cmd =>
            {
                cmd.CubeCrypto = cubeCrypto;
                cmd.CubeToStringConverter = cubeToStringConverter;
                cmd.KeyGenerator = keyGenerator;
                cmd.KeyStringConverter = keyStringConverter;
            });

            Console.WriteLine("###################################");
            Console.WriteLine("## DoublePermutation by DenKodec ##");
            Console.WriteLine("###################################");
            Console.WriteLine();

            while (true)
            {
                Console.Write("=> ");
                string strCommand = Console.ReadLine();
                BaseCommand command = commands.Find(cmd => cmd.Name == strCommand);
                if (command != null)
                {
                    command.Execute();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This command not found");
                    Console.WriteLine("Enter <help> to get information about commands");
                }
            }
        }
    }
}
