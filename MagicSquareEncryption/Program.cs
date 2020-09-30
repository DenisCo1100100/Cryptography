using System;
using System.Collections.Generic;
using System.IO;

namespace MagicSquareEncryption
{
    class Program
    {
        private static int[,] magicSquare;
        private static char[,] squareWithCipher;

        static void Main(string[] args)
        {
            try
            {
                string selectedOperation = "";

                while (true)
                {
                    Console.Write("Choose encryption or decryption (E/D) or (End): ");
                    selectedOperation = Console.ReadLine();

                    if (selectedOperation == "End")
                        break;

                    VerificatOperations(selectedOperation);

                    Console.WriteLine("Press the key to continue...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private static void VerificatOperations(string operation)
        {
            bool isEncryption = operation == "E" ? true : operation == "D" ? false : throw new Exception("Wrong answer");

            if (isEncryption)
                Encryption();
            else
                Decryption();
        }

        #region Encryption
        private static void Encryption()
        {
            Console.Write("Enter the word to encrypt: ");
            string cipher = Console.ReadLine();

            string squareInLine = ReadingSquareFromFile(cipher.Length);
            int size = RequiredDimensionSquare(squareInLine.Split().Length);

            magicSquare = new int[size, size];
            squareWithCipher = new char[size, size];
            
            FillingMagicSquare(size, squareInLine);
            cipher = AddSpacesInCipher(cipher);
            WritingCipherInSquare(cipher);
            PrintCipherAndKey(size);
        }

        private static string AddSpacesInCipher(string cipher)
        {
            while (cipher.Length < magicSquare.Length)
            {
                cipher += '_';
            }

            return cipher;
        }

        private static void FillingMagicSquare(int size, string squareInLine)
        {
            string[] squareNumbers = squareInLine.Split();
            int indexSymbol = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    magicSquare[i, j] = Convert.ToInt32(squareNumbers[indexSymbol]);
                    indexSymbol++;
                }
            }
        }

        private static string ReadingSquareFromFile(int desiredLength)
        {
            Random random = new Random();
            string[] squareLines = File.ReadAllLines("MagicSquars.txt");
            List<string> selectedSquare = new List<string>();

            for (int i = 0; i < squareLines.Length; i++)
            {
                if (squareLines[i].Split().Length >= desiredLength)
                {
                    selectedSquare.Add(squareLines[i]);
                }
            }
            
            if (selectedSquare.Count == 0)
            {
                throw new Exception("The code is too long");
            }

            int randomIndex = random.Next(0, selectedSquare.Count);

            return selectedSquare[randomIndex];
        }

        private static void WritingCipherInSquare(string cipher)
        {
            int size = squareWithCipher.GetLength(0);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    int indexSymbol = magicSquare[i, j] - 1;
                    squareWithCipher[i, j] = cipher[indexSymbol]; //IndexOut
                }
        }

        private static void PrintCipherAndKey(int size)
        {
            Console.WriteLine("Cipher:");
            foreach (var symbol in squareWithCipher)
            {
                Console.Write(symbol);
            }

            Console.WriteLine("\n" + "Key:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(magicSquare[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
        #endregion

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
        }

        private static int RequiredDimensionSquare(int cipherLength)
        {
            double size = 0;
            int powNumber = 3;

            while (size < cipherLength)
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
                        squareWithCipher[i, j] = '_';
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

            Console.WriteLine();
        }
        #endregion
    }
}