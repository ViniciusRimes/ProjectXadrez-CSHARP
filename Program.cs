using System;
using BoardService;
using ProjectXadrez.Entities;

namespace ProjectXadrez
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();
            Board board = new(8, 8);
            Screen.PrintBoard(board);
            
            
        }
    }
}
