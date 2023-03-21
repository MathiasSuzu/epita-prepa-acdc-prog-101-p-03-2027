using System;
namespace Survivor
{
    public class Game
    {
        public Random Random;
        protected int SpawnRate;
        protected int DaysLeft;
        protected Cell[,] Board;
        protected Player Player;
        public Game(Random random, int spawnRate, int daysLeft, int boardWidth, int boardHeight)
        {
            Random = random;
            SpawnRate = spawnRate;
            DaysLeft = daysLeft;
            if (boardWidth < 5 || boardHeight < 5)
            {
                throw new ArgumentException("Board must be at least 5x5");
            }
            
            Board = CreateBoard(boardWidth, boardHeight);
            Player = new Player(30, (boardWidth - 1) / 2, (boardHeight - 1) / 2);
        }
        
        public Game()
        {
            throw new NotImplementedException("Delete This Constructor When Game Hard Is Implemented");
        }
        
        public Cell[,] GetBoard()
        {
            return Board;
        }

        protected virtual void SpawnItem(int x, int y)
        {
            int maxX = Board.GetLength(0);
            int maxY = Board.GetLength(1);
            int range = Random.Next(1, Board[x, y].GetSpawnRange() + 1);
            int x2 = maxX;
            int y2 = maxY;
            
            while (x + x2 < 0 || x + x2 >= maxX || y + y2 < 0 || y + y2 >= maxY)
            {
                range = Random.Next(1, Board[x, y].GetSpawnRange() + 1);
                x2 = Random.Next(0, range);
                y2 = x2-range;
                
                if (Random.Next(0, 2) == 1)
                {
                    x2 = -x2;
                }

                if (Random.Next(0, 2) == 1)
                {
                    y2 = -y2;
                }
            }
            
            
            
            Cell current = Board[x+x2, y+y2];
            switch (current)
            {
                case Forest:
                    current.SetContent(new Banana(3, 7));
                    break;
                case River:
                    current.SetContent(new Plum(2, 9));
                    break;
                case Sea:
                    current.SetContent(new Coconut(4,5));
                    break;
            }
            
        }

        protected void Spawn()
        {
            int maxX = Board.GetLength(0);
            int maxY = Board.GetLength(1);
            double luck = Player.GetLuck();

            for (int i = 0; i < maxX; i++ )
            {
                for (int j = 0; j < maxY; j++)
                {
                    if (Random.Next(1, 100) <= SpawnRate * luck )
                    {
                        SpawnItem(i,j);
                    }
                }
            }
        }

        protected virtual void PrintBoard()
        {
            ConsoleColor bg = Console.BackgroundColor;
            ConsoleColor fg = Console.ForegroundColor;
            for (int y = 0; y < Board.GetLength(1); y++)
            {
                Console.Write("|");
                for (int x = 0; x < Board.GetLength(0); x++)
                {
                    switch (Board[x, y])
                    {
                        case Forest:
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;
                        case River:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case Sea:
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;
                        default:
                            Console.BackgroundColor = bg;
                            break;
                    }

                    if (Player.GetCoordinates().x == x && Player.GetCoordinates().y == y)
                        Console.Write("X");
                    else
                        Console.Write(Board[x, y]);
                }
                Console.BackgroundColor = bg;
                Console.ForegroundColor = fg;
                Console.WriteLine("|");
            }
        }
        
        protected void PrintStats()
        {
            Console.Write("Days left: ");
            Console.WriteLine(DaysLeft);
            
            Console.Write("Energy: ");
            Console.WriteLine(Player.GetEnergy());
            
            Console.Write("Thirst: ");
            Console.WriteLine(Player.GetThirst());
        }
        
        protected virtual void PrintAll()
        {
            PrintBoard();
            PrintStats();
        }

        protected void PrintEnd(bool win)
        {
            if (win)
            {
                Console.WriteLine("You survived the journey!");
                
            }
            else
            {
                Console.WriteLine("You died.");
            }
        }
        protected virtual void UpdateBoard()
        {
            int maxX = Board.GetLength(0);
            int maxY = Board.GetLength(1);
            Cell current;
            for (int i = 0; i < maxX; i++ )
            {
                for (int j = 0; j < maxY; j++)
                {
                    current = Board[i, j];
                    if (current != null)
                        current.Update();
                }
            }
        }
        
        protected virtual bool NextDay()
        {
            if (Player.SpendTheNight())
            {
                PrintEnd(false);
                return false;
            }

            DaysLeft -= 1;
            UpdateBoard();
            Spawn();
            return true;
        }

        
        
        protected virtual bool GetAction()
        {
            static int Input()
            {
                int i = Console.Read();
                if (i < 33 || i == 127)
                {
                    return Console.Read();
                }
                
                else
                {
                    return i;
                }

            }
            int input = Input();
            while (input >= 0)
            {
                if (input > 33)
                {
                    if ((char)input == 'w' || (char)input == 'a' || (char)input == 's' || (char)input == 'd')
                    {
                        (int, int) old = Player.GetCoordinates();
                        Player.Move(this, (char)input);
                        if (old != Player.GetCoordinates())
                        {
                            input = -1;
                        }
                        else
                        {
                            input = Input();
                        }

                    }
                    else
                    {
                        switch ((char)input)
                        {
                            case 'i':
                                (int x, int y) = Player.GetCoordinates();
                                Cell current = Board[x, y];
                                if (current.GetType() == typeof(River) && Player.GetThirst())
                                {
                                    Player.Drink();
                                    input = -1;
                                }
                                else if (current.GetContent() != null)
                                {
                                    if (!Player.Eat(current.GetContent()))
                                    {
                                        input = Input();
                                    }
                                    
                                    /*else
                                    {
                                        Board[x, y].SetContent(null);
                                        input = -1;
                                    }*/
                                    
                                    Board[x, y].SetContent(null);
                                    input = -1;
                                }
                                else
                                {
                                    input = Input();
                                }
                                
                                break;

                            case 'n':
                                Console.WriteLine("If you are still thirsty, you will die during the night. Do you still want to end the day? (y/n)");

                                input = Input();
                                if (input > 32)
                                {
                                    while (input > 32)
                                    {
                                        if (input == 121 || input == 89)
                                        {
                                            input = -1;
                                            return NextDay();
                                        }

                                        else if (input == 110 || input == 78)
                                        {
                                            input = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("If you are still thirsty, you will die during the night. Do you still want to end the day? (y/n)");
                                            input = Input();
                                        }
                                    }
                                }

                                break;

                            case 'q':
                                return false;

                            default:
                                input = Input();
                                break;
                        }
                    }
                }
                else
                {
                    input = Input();
                }
            }

            return true;
        }

        public void Play()
        {
            Spawn();
            PrintAll();
            while (Player.GetEnergy() > 0 && GetAction() && DaysLeft > 0)
            {
                PrintAll();
            }
            PrintAll();
            bool win = true;
            if (Player.GetEnergy() <= 0)
                win = false;
            
            PrintEnd(win);
        }

        

        protected virtual Cell[,] CreateBoard(int width, int height)
        {
            Cell[,] board = new Cell[width, height];
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (x == 0 || x == board.GetLength(0) - 1 || y == 0 || y == board.GetLength(1) - 1)
                        board[x, y] = new Sea(1, 2);
                    else if (x == 2 * y)
                        board[x, y] = new River(2, 2); 
                    else
                        board[x, y] = new Forest(1, 2);
                }
            }

            return board;
        }
    }
}
