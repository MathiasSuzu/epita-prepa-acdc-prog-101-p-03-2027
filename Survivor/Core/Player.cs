using System;

namespace Survivor
{
    public class Player
    {
        protected readonly int MaxEnergy;
        protected int Energy;
        protected bool Thirst;
        protected double Luck;
        protected (int x, int y) Coordinates;

        public Player(int maxEnergy, int x, int y)
        {
            MaxEnergy = maxEnergy;
            Energy = maxEnergy;
            Thirst = true;
            Luck = 1.0;
            Coordinates = (x, y);
        }
        public Player()
        {
            throw new NotImplementedException("Delete This Constructor When Player Hard Is Implemented");
        }

        public double GetLuck()
        {
            return Luck;
        }

        public void SetLuck(double luck)
        {
            Luck = luck;
        }

        public (int x, int y) GetCoordinates()
        {
            return Coordinates;
        }

        public int GetEnergy()
        {
            return Energy;
        }

        public bool GetThirst()
        {
            return Thirst;
        }

        public virtual void Move(Game game, char key)
        {
            Cell[,] board = game.GetBoard();
            (int x, int y) = Coordinates;

            if (key == 'w')
            {
                if (y - 1 >= 0 && board[x, y - 1] is not Sea)
                {
                    Coordinates = (x, y - 1);
                }
            }
            else if (key == 'a')
            {
                if (x - 1 >= 0 && board[x-1, y] is not Sea)
                {
                    Coordinates = (x - 1, y);
                }
            }
            else if (key == 's')
            {
                int maxY = board.GetLength(1);
                if (y + 1 < maxY && board[x, y + 1] is not Sea)
                {
                    Coordinates = (x, y + 1);
                }
            }
            else if (key == 'd')
            {
                int maxX = board.GetLength(0);
                if (x + 1 < maxX && board[x + 1, y] is not Sea)
                {
                    Coordinates = (x + 1, y);
                }
            }
            (int x2, int y2) = Coordinates;
            if ((x2, y2) == (x, y))
            {
                Energy += board[x,y].GetMoveCost();
            }
            Energy -= board[x2,y2].GetMoveCost();
            
        }

        public bool SpendTheNight()
        {
            Console.WriteLine("You spend the night on the ground.");
            Energy -= 2;
            if (Thirst)
            {
                return false;
            }
            else if (Energy <= 0)
            {
                return false;
            }
            else
            {
                Thirst = true;
                return false;
            }
        }
        
        public bool Eat(Item food)
        {
            if (food == null!)
            {
                throw new ArgumentException("There is no food to eat.");
            }
            else if (food.GetEnergyAmount()+Energy > MaxEnergy)
            {
                return false;
            }
            else
            {
                Energy += food.GetEnergyAmount();
                return true;
            }
            
        }
        
        public void Drink()
        {
            Thirst = false;
        }

        public override string ToString()
        {
            return "^";
        }
    }
}
