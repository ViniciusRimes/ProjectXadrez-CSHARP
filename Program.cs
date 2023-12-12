using System;
using System.Reflection.PortableExecutable;
using BoardService;
using ProjectXadrez.Entities;
using ProjectXadrez.Xadrez.Entities;

namespace ProjectXadrez
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();
            try{
                Board board = new(8, 8);
                board.InsertPart(new Tower(Color.Branca, board), new Position(0,0) );
                board.InsertPart(new Tower(Color.Branca, board), new Position(1,3) );
                board.InsertPart(new King(Color.Branca, board), new Position(0, 9) );
                Screen.PrintBoard(board);
            }catch(BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
