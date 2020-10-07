using DoublePermutationMethod.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCommand command = new DecoderCubeCommand();
            command.Execute();
        }
    }
}
