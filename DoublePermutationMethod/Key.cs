using System;

namespace DoublePermutationMethod
{
    class Key
    {
        public int[] RowHeader { get; set; }
        public int[] ColHeader { get; set; }
        public int Length { get => RowHeader.Length + ColHeader.Length; }
        public int LengthHeder { get => RowHeader.Length; }
        public int Size => ColHeader.Length;

        public Key(int size)
        {
            RowHeader = new int[size];
            ColHeader = new int[size];
        }

        public Key(int[] rowHeader, int[] colHeader)
        {
            if (rowHeader.Length != colHeader.Length)
            {
                throw new Exception("Key colHeder length not equals key rowHeder length");
            }

            RowHeader = rowHeader;
            ColHeader = colHeader;
        }
    }
}
