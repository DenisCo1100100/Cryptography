using System;

namespace DoublePermutationMethod.Command
{
    class EncoderCubeCommand : BaseCommand
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

        private int[,] EnterSizeAndKey()
        {
            Console.Write("Enter the size of the square: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter key-col separated by space:");
            string[] col = Console.ReadLine().Split();

            Console.WriteLine("Enter key-row separated by space:");
            string[] row = Console.ReadLine().Split();

            if (col.Length == size && row.Length == size)
            {
                int[,] key = new int[2, size];
                for (int i = 0; i < size; i++)
                {
                    key[0, i] = Convert.ToInt32(col[i].ToString()) - 1;
                    key[1, i] = Convert.ToInt32(row[i].ToString()) - 1;
                }

                return key;
            }

            throw new Exception("Invalid key length");
        }
    }
}
