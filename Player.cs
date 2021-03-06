using System;
using System.Linq;

namespace CsTicTac
{
    class Player
    {
        private char type;
        public char Type {
            get { return type; }
            set
            {
                if (value == 'X')
                {
                    type = value;
                }
                else
                {
                    type = 'O';
                }
            }
            
        }

        public int[] positionsOccupied;
        static int[] positionValues = { 4,9,2,3,5,7,8,1,6};
        private int noOfPositions = 0;
        public Player(char type)
        {
            this.Type = type;
            if (Type == 'X')
            {
                positionsOccupied = new int[5];
            }
            else
            {
                positionsOccupied = new int[4];
            }
        }

        public bool insert(int position)
        {
            if (position <= 9 && position > 0)
            {
                int positionValue = positionValues[position-1];
                if (positionsOccupied.Contains(positionValue)) return false;
                this.positionsOccupied[this.noOfPositions] = positionValue;
                noOfPositions++;
                return true;
            }
            else return false;
        }

        public bool checkWin()
        {
            if (this.noOfPositions < 3) return false;
            else
            {
                for(int i = 0; i < (this.noOfPositions - 2); i++)
                {
                    for( int j = i + 1; j < (this.noOfPositions - 1); j++)
                    {
                        int sumij = this.positionsOccupied[i] + this.positionsOccupied[j];
                        for (int k = j+1; k < this.noOfPositions; k++)
                        {
                            if (sumij + this.positionsOccupied[k] == 15)
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", this.positionsOccupied));
            Console.WriteLine(this.checkWin());
        }
    }
}
