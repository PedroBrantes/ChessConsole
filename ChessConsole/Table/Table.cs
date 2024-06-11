namespace ChessConsole.Table
{
    class ChessTable
    {
        public int lines { get; set; }
        public int columns { get; set; }

        private Piece[,] piece;

        public ChessTable(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            piece = new Piece[lines,columns];
        }

        public Piece GetPiece(int line, int column)
        {
            return piece[line, column];
        }
    }
}
