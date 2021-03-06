using System;
using System.Collections.Generic;
using System.Text;

namespace CsTicTac
{
    // Board Class consist of board rendering and Board state
    class Board
    {
        private char[,] state = new char[3, 3];
        public string name;

        public Board(string presentName)
        {
            name = presentName;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    state[i, j] = ' ';
                }
            }
        }
        public Board(string presentName, char[,] presentState)
        {
            name = presentName;
            state = presentState;
        }

        public void render()
        {
            Console.WriteLine(name);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(' '); 
                for (int j=0; j<3 ; j++)
                {
                    Console.Write(state[i, j]);
                    if (j%3 != 2)
                    {
                        Console.Write(" | ");
                    }
                    else
                    {
                        Console.WriteLine(' ');
                    }
                }
                if (i % 3 != 2)
                {
                    Console.WriteLine("------------");
                }
            }
        }
        
        public void insert(int position, char value)
        {
            if (position <= 9 && position > 0)
            {
                position = position + 2;
                int x = 2- (Convert.ToInt32(Math.Floor(Convert.ToDecimal(position / 3))) -1);
                int y = position % 3;
                Console.WriteLine("Player {0} is inserting in [{1},{2}]", value, x, y);
                state[x, y] = value;
            }
        }

        public bool checkPosition(int position)
        {
            if (position <= 9 && position > 0)
            {
                position = position + 2;
                int x = 2 - (Convert.ToInt32(Math.Floor(Convert.ToDecimal(position / 3))) - 1);
                int y = position % 3;
                char X = state[x, y];
                Console.WriteLine(X);
                if (X == ' ') return false;
            }
            return true;
        }
    }
}
