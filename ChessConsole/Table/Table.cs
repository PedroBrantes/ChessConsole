namespace ChessConsole.Table
{
    internal class Table
    {
        public int lines { get; set; }
        public int columns { get; set; }

        private Piece[,] piece;

        public Table(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            piece = new Piece[lines,columns];
        }
    }
}
