using System;

namespace DoublePermutationMethod.Command
{
    class DecoderCubeCommand : BaseCommand
    {
        public override string Name => "encode";

        public override void Execute()
        {

            int[,] key = EnterSizeAndKey();

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            while (message.Length > (key.Length * key.Length))
            {
                Console.WriteLine("Message has very big length. Try again!");
                message = Console.ReadLine();
            }

            Cube cube = CubeStringConverter.StringToCube(message, key);

            CubeCrypto.Cube = cube;
            CubeCrypto.SetDecoded(key);

            Console.Write("Decoded message: ");
            Console.WriteLine(CubeCrypto.GetDecoded());
            Console.ReadKey();
        }


    }
}
