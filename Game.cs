using System;
using System.Collections.Generic;
using System.Text;

namespace CsTicTac
{
    class Game
    {
        static string boardName = "Board 1";
        private Board board1 = new Board(boardName);
        Player[] players = new Player[2];
        private int turn;
        private char winner = 'N';
        Player player;
        private int plays = 0;
        public Game()
        {
            players[0] = new Player('X');
            players[1] = new Player('O');
            turn = 0;
            player = players[turn];
        }
        public void changeTurn()
        {
            turn = (turn + 1) % 2;
            player = players[turn];
        }
        public void GameLogic()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("It is {0}'s Turn", players[turn].Type);
                board1.render();
                int putPosition;
                try
                {
                    putPosition = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("That move is not Valid. Press any Key to Try again");
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    continue;
                }
                if (! board1.checkPosition(putPosition)){
                    board1.insert(putPosition, player.Type);
                    players[turn].insert(putPosition);
                    if (checkWinner() || plays >= 8)
                    {
                        declareWinner();
                        break;
                    }
                    changeTurn();
                    continue;
                }
                else
                {
                    Console.WriteLine("That position is occupied. Press any Key to Try again");
                    continue;
                }

            }

        }
        public bool checkWinner()
        {
            if (players[turn].checkWin())
            {
                winner = players[turn].Type;
                return true;
            }
            else
                return false;
        }
        private  void declareWinner()
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            board1.render();
            if (winner == 'N')
            {
                Console.WriteLine("It was a Draw");
                return;
            }
            Console.WriteLine("{0} wins the Game on {1}", winner, boardName);
            return;
        }
    }
}
