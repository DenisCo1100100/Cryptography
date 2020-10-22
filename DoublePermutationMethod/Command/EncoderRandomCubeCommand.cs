using System;

namespace DoublePermutationMethod.Command
{
    class EncoderRandomCubeCommand : BaseCommand
    {
        public override string Name => "decodrandom";

        public override void Execute()
        {
            Console.WriteLine("Enter the size of the square: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Key key = KeyGenerator.GenerateRandom(size);

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            while (message.Length > (key.Length * key.Length))
            {
                Console.WriteLine("Message has very big length. Try again!");
                message = Console.ReadLine();
            }

            Cube cube = CubeToStringConverter.StringToCube(message, size);

            CubeCrypto.Cube = cube;
            CubeCrypto.SetDecoded(key);

            Console.Write("Decoded message: ");
            Console.WriteLine(CubeCrypto.GetDecoded());
            Console.ReadKey();
        }
    }
}
