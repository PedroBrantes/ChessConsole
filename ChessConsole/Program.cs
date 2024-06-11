using System;
using ChessConsole.Table;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Position P;

            P = new Position(2, 4);

            Console.WriteLine("Position: " + P);
            Console.ReadLine();
        }
    }
}