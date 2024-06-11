using ChessConsole.Table;

namespace ChessConsole
{
    internal class Screen
    {

        public static void PrintScreen(ChessTable table)
        {
            for (int i = 0; i < table.lines; i++)
            {
                for (int j = 0; j < table.columns; j++)
                {
                    if (table.GetPiece == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(table.GetPiece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
