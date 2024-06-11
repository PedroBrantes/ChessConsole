namespace ChessConsole.Table
{
    internal class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }

        public int quantityMoves { get; protected set; }

        public ChessTable table { get; protected set; }

        public Piece(Position position, ChessTable table, Color color)
        {
            this.position = position;
            this.table = table;
            this.color = color;
            this.quantityMoves = 0;
        }

    }
}
