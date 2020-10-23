using System;

namespace DoublePermutationMethod.Command
{
    class DecoderCubeCommand : BaseCommand
    {
        public override string Name => "decode";

        public override void Execute()
        {
            Console.Write("Enter the cipher to be decrypted: ");
            string message = Console.ReadLine();

            Console.WriteLine("Enter key-col separated by space:");
            string col = Console.ReadLine();

            Console.WriteLine("Enter key-row separated by space:");
            string row = Console.ReadLine();

            int size = col.Split().Length;
            while ((size * size) < message.Length)
            {
                Console.WriteLine("Too short key, try again!");

                Console.WriteLine("Enter key-col separated by space:");
                col = Console.ReadLine();

                Console.WriteLine("Enter key-row separated by space:");
                row = Console.ReadLine();
            }

            Key key = new Key(size);
            KeyStringConverter.Key = key;
            key = KeyStringConverter.ConvertStringsToKey(row, col);

            Cube cube = CubeToStringConverter.StringToCube(message, size);
            CubeCrypto.Cube = cube;
            CubeCrypto.GetDecode(key);
        }
    }
}
