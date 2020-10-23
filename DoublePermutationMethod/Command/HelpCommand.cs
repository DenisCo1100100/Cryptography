using System;

namespace DoublePermutationMethod.Command
{
    class HelpCommand : BaseCommand
    {
        public override string Name => "help";

        public override void Execute()
        {
            Console.WriteLine("<encode> - Command to encrypt a sentence with a custom key");
            Console.WriteLine("<encodeRND> - Command to encrypt a sentence with a random key");
            Console.WriteLine("<decode> - Command for decrypting a sentence with a custom key");
        }
    }
}
