using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod.Command
{
    class DecoderCubeCommand : BaseCommand
    {
        public override string Name => "decod";

        public override void Execute()
        {
            int[,] key = new int[2, 4] {
             { 2, 3, 0, 1},
             { 3, 1, 2, 0} 
            };

            Cube cube = CubeStringConverter.StringToCube("КОЗИКДЕНИСВАСИЛЬ", key);

            CubeCrypto.Cube = cube;
            CubeCrypto.SetDecoded(key);
        }
    }
}
