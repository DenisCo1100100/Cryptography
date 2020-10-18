using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublePermutationMethod.Command
{
    class HelpCommand : BaseCommand
    {
        public override string Name => "help";

        public override void Execute()
        {
            Console.WriteLine("<decod> - Command to encrypt a word with a custom key");
            Console.WriteLine("<decodrandom> - Command to encrypt a word with a random key");
            Console.WriteLine("<encode> - Command for decrypting a word");
        }
    }
}
