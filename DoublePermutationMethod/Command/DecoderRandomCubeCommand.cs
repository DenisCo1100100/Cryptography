using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod.Command
{
    class DecoderRandomCubeCommand : BaseCommand
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
            int[,] key = new int[2, size];
            int[] genNumber = new int[size];
            int randNumb;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int f = 0; f < genNumber.Length; f++)
                    {
                        randNumb = random.Next(0, size);
                        if (randNumb == genNumber[f])
                        {
                            break; // Дописатьб
                        }

                        genNumber[f] = randNumb;
                        key[i, j] = randNumb;
                    }
                    Console.Write(key[i, j] + " ");
                }

                Console.WriteLine("-");
            }

            return key;
        }
    }
}
