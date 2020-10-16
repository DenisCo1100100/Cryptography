using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod
{
    class Key
    {
        public int[] RowHeader { get; set; }
        public int[] ColHeader { get; set; }
        
        public int Size => ColHeader.Length;

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
