namespace DoublePermutationMethod
{
    class CubeToStringConverter
    {
        public Cube StringToCube(string message, int cubeSize)
        {
            var cube = new Cube(cubeSize);

            for (int i = 0; i < message.Length; i++)
            {
                cube.ListCels[i].Symbol = message[i];
            }

            return cube;
        }
    }
}
