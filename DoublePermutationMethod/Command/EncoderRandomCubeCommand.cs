using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod.Command
{
    class EncoderRandomCubeCommand : BaseCommand
    {
        public override string Name => "decodrandom";

        public override void Execute()
        {
            Console.WriteLine("Enter the size of the square: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] key = GenerateRandomKey(size);

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

        private int[,] GenerateRandomKey(int size)
        {
            Random random = new Random();
            int[] col = KeyPartGeneration(size, random);
            int[] row = KeyPartGeneration(size, random);

            int[,] key = new int[2, size];
            for (int i = 0; i < size; i++)
            {
                key[0, i] = col[i];
                key[1, i] = row[i];
            }
            
            return key;
        }

        private int[] KeyPartGeneration(int size, Random random)
        {
            int[] part = new int[size];
            bool flag;
            int keyIndex = 1;

            while (size != keyIndex)
            {
                flag = true;
                int rndNumb = random.Next(1, size);

                for (int i = 0; i < part.Length; i++)
                {
                    if (part[i] == rndNumb)
                        flag = false;
                }

                if (flag)
                {
                    part[keyIndex] = rndNumb;
                    keyIndex++;
                }
            }

            return part;
        }
    }
}
