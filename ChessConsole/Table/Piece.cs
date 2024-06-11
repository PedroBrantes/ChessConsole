namespace ChessConsole.Table
{
    internal class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }

        public int quantityMoves { get; protected set; }

        public Table table { get; protected set; }

        public Piece(Position position, Table table, Color color)
        {
            this.position = position;
            this.table = table;
            this.color = color;
            this.quantityMoves = 0;
        }

    }
}
