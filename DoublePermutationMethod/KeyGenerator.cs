using System;

namespace DoublePermutationMethod
{
    class KeyGenerator
    {
        public Key Key { get; set; }

        private Random rnd = new Random();

        public Key GenerateRandom(int size)
        {
            return new Key(
                GetRandomSequence(size),
                GetRandomSequence(size)
                );
        }

        private int[] GetRandomSequence(int size)
        {
            int[] part = new int[size];
            bool flag;
            int keyIndex = 1;

            while (size != keyIndex)
            {
                flag = true;
                int rndNumb = rnd.Next(1, size);

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