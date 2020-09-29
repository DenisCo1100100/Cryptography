using System;

namespace MagicSquareEncryption
{
    class Program
    {
        private static int[,] magicSquare;
        private static char[,] squareWithCipher;

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
                Encryption();
            else
                Decryption();
        }

        private static void Encryption()
        {
            // Шифровка
        }

        #region Decryption
        private static void Decryption()
        {

            Console.Write("Enter the code to decrypt: ");
            string cipher = Console.ReadLine();

            int size = RequiredDimensionSquare(cipher.Length);
            magicSquare = new int[size, size];

            FillingMagicSquare(size);
            WritingCipherInSquare(size, cipher);
            WritingOutWordFromSquare(size);

            Console.ReadKey();
        }

        private static int RequiredDimensionSquare(int cipher)
        {
            double size = 0;
            int powNumber = 3;

            while (size < cipher)
            {
                size = Math.Pow(powNumber, 2);
                powNumber++;
            }

            return powNumber - 1;
        }

        private static void FillingMagicSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("=>" + i + "<= line");

                for (int j = 0; j < size; j++)
                    magicSquare[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void WritingCipherInSquare(int size, string cipher)
        {
            squareWithCipher = new char[size, size];
            int indexSymbol = 0;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (indexSymbol <= cipher.Length)
                    {
                        squareWithCipher[i, j] = cipher[indexSymbol];
                        indexSymbol++;
                    }
                    else
                    {
                        squareWithCipher[i, j] = ' ';
                    }
                }
        }

        private static void WritingOutWordFromSquare(int size)
        {
            int charNumber = 1;

            Console.Write("Received word: ");
            while (charNumber <= magicSquare.Length)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (magicSquare[i, j] == charNumber)
                            Console.Write(squareWithCipher[i, j]);
                    }
                }

                charNumber++;
            }
        }
        #endregion
    }
}
