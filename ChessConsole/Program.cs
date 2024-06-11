using System;
using ChessConsole.Table;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessTable table = new ChessTable(8, 8);

            Screen.PrintScreen(table);

            Console.ReadLine();
        }
    }
}