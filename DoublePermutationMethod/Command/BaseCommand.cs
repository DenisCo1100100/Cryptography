using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod.Command
{
    abstract class BaseCommand
    {
        abstract public string Name { get; }
        public CubeCrypto CubeCrypto { get; set; }
        public Cube Cube { get; set; }
        public abstract void Execute();
    }
}
