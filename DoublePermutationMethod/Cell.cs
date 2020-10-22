namespace DoublePermutationMethod.Command
{
    class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Number { get; set; }
        public char Symbol { get; set; }
        public Cell(int col, int row, int number = 0, char symbol = '_')
        {
            Col = col;
            Row = row;
            Number = number;
            Symbol = symbol;
        }
    }
}
