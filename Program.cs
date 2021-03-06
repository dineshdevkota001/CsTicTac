using System;

namespace CsTicTac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //char player = 'X';
            //int move = 5;
            //board1.insert(move, player);
            //Player[] players = new Player[2];
            //players[0] = new Player('X');
            //players[1] = new Player('O');
            //players[0].Print();
            //players[1].Print();
            try
            {
                Game tictactoe = new Game();
                tictactoe.GameLogic();
            }
            catch
            {
                Console.WriteLine("Problem Here");
            }
        }
    }
}
