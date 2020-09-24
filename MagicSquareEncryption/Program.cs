using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquareEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose encryption or decryption (E/D): ");
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

        }

        private static void Decryption()
        {

        }
    }
}
