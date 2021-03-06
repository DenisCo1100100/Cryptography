﻿using System;

namespace DoublePermutationMethod.Command
{
    class EncoderCubeCommand : BaseCommand
    {
        public override string Name => "encode";

        public override void Execute()
        {
            Console.Write("Enter the size of the square: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter key-col separated by space:");
            string col = Console.ReadLine();

            Console.WriteLine("Enter key-row separated by space:");
            string row = Console.ReadLine();

            Key key = new Key(size);
            KeyStringConverter.Key = key;
            key = KeyStringConverter.ConvertStringsToKey(row, col);

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            while (message.Length > (key.Length * key.Length))
            {
                Console.WriteLine("Message has very big length. Try again!");
                message = Console.ReadLine();
            }

            Cube cube = CubeToStringConverter.StringToCube(message, size);

            CubeCrypto.Cube = cube;
            CubeCrypto.SetEncode(key);

            Console.Write("Decoded message: ");
            Console.WriteLine(CubeCrypto.GetEncode());
            Console.ReadKey();
        }
    }
}
