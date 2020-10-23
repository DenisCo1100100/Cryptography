using System;

namespace DoublePermutationMethod
{
    class KeyStringConverter
    {
        public Key Key { get; set; }

        public Key ConvertStringsToKey(string rowHeder, string colHeder)
        {
            string[] row = rowHeder.Split();
            string[] col = colHeder.Split();

            for (int i = 0; i < rowHeder.Length; i++)
            {
                Key.RowHeader[i] = Convert.ToInt32(row[i].ToString());
                Key.ColHeader[i] = Convert.ToInt32(col[i].ToString());
            }

            return Key;
        }

        public void PrintKey(Key key)
        {
            Console.WriteLine("Key: ");

            for (int i = 0; i < key.LengthHeder; i++)
                Console.Write(key.RowHeader[i] + " ");

            Console.WriteLine();

            for (int i = 0; i < key.LengthHeder; i++)
                Console.Write(key.ColHeader[i] + " ");
        }
    }
}
