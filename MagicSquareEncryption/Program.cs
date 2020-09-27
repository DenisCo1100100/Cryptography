using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquareEncryption
{
    class Program
    {
        private static int[,] magicSquare;

        static void Main(string[] args)
        {
            Console.Write("Choose encryption or decryption (E/D): ");
            string selectedOperation = Console.ReadLine();
            VerificatOperations(selectedOperation);
        }

        private static void VerificatOperations(string operation)
        {
            bool isEncryption = operation == "E" ? true : operation == "D" ? false : throw new Exception("Wrong answer");

            if (isEncryption)
            {
                Encryption();
            }
            else
            {
                Decryption();
            }
        }

        private static void Encryption()
        {
            // Шифровка
        }

        private static void Decryption()
        {

            Console.Write("Введите шифр для расшифрования: ");
            string cipher = Console.ReadLine();

            int size = RequiredDimensionSquare(cipher.Length);
            magicSquare = new int[size, size];

            FillingMagicSquare(size);
        }

        private static void FillingMagicSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(i + "-строка");
                for (int j = 0; j < size; j++)
                {
                    magicSquare[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        private static int RequiredDimensionSquare(int cipher)
        {
            double size = 0;
            int powNumber = 2;

            while (size < cipher)
            {
                powNumber++;
                size = Math.Pow(powNumber, 2);
            }

            return powNumber;
        }
    }
}
