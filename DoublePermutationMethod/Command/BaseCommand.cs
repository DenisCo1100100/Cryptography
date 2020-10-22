namespace DoublePermutationMethod.Command
{
    abstract class BaseCommand
    {
        abstract public string Name { get; }
        public CubeCrypto CubeCrypto { get; set; }
        public CubeToStringConverter CubeToStringConverter { get; set; }
        public KeyStringConverter KeyStringConverter { get; set; }
        public KeyGenerator KeyGenerator { get; set; }
        public Cube Cube { get; set; }
        public abstract void Execute();
    }
}
