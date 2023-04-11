using System;

namespace Task4
{
    public class Program
    {
        public static void Main()
        {
            /* input data of the field size */
            Console.WriteLine("Insert number of rows: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int rows = m + 1;
            Console.WriteLine("Insert number of columns: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int columns = n;

            /* field (table 2d) / next generation field / another field for comparison */
            int[,] field = new int[rows, columns];
            int[,] nextField = new int[rows, columns];
            int[,] isSameField = new int[rows, columns];

            /* variables to generate alive or dead cells */
            var random = new Random();
            int[] indexCell = { 0, 1 };

            /* variable to count living cells around one */
            int aliveNeighbours;

            /* flag and variables to end the game */
            bool gameOver = true;
            int itWasSame = 0;
            int counterDeadCells;
            int counter;

            Console.Clear();

            /* algorithm to generate the field and first random generation of cells */
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    if (k == 0)
                    {
                        Console.Write(field[j, k] = (rows - j - 1));
                        Console.Write(" ");
                    }
                    if (j == rows - 1)
                    {
                        Console.Write(field[j, k] = (k + 1));
                    }
                    else
                    {
                        int LiveOrDeadCell = random.Next(indexCell.Length);
                        if (LiveOrDeadCell == 1)
                        {
                            field[j, k] = 1;
                            Console.Write("+");
                        }
                        else
                        {
                            field[j, k] = 0;
                            Console.Write("-");
                        }
                    }
                    Console.Write(" ");
                }
                Console.Write(System.Environment.NewLine);
            }

            /* algorithm to create the next generations until end of game */
            while (gameOver)
            {
                Console.Write(System.Environment.NewLine);
                Console.Write("Press any key to continue with next generation...");
                Console.ReadKey();
                Console.Clear();

                /* the first 2 "for" are to analyze each cell of the table */
                for (int j = 1; j < rows - 1; j++)
                {
                    for (int k = 1; k < columns - 1; k++)
                    {
                        /* these "for" are for analyze the neighbour of each cell */
                        aliveNeighbours = 0;
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int o = -1; o <= 1; o++)
                            {
                                aliveNeighbours += field[j + i, k + o];
                            }
                        }
                        /* cell needs to be substracted because it was counted before */
                        aliveNeighbours -= field[j, k];

                        /* rules of game */
                        /* each cell with one or no neighbors dies, as if by solitude */
                        if ((field[j, k] == 1) && (aliveNeighbours < 2))
                        {
                            nextField[j, k] = 0;
                        }

                        /* each cell with four or more neighbors dies, as if by overpopulation */
                        else if ((field[j, k] == 1) && (aliveNeighbours > 3))
                        {
                            nextField[j, k] = 0;
                        }

                        /* each cell with three neighbors becomes populated */
                        else if ((field[j, k] == 0) && (aliveNeighbours == 3))
                        {
                            nextField[j, k] = 1;
                        }

                        /* each cell with two or three neighbors survives */ 
                        else
                        {
                            nextField[j, k] = field[j, k];
                        }
                    }
                }

                /* this algorithm create next generation field */
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (k == 0)
                        {
                            Console.Write(field[j, k] = (rows - j - 1));
                            Console.Write(" ");
                        }
                        if (j == rows - 1)
                        {
                            Console.Write(field[j, k] = (k + 1));
                        }
                        else
                        {
                            if (nextField[j, k] == 1)
                            {
                                field[j, k] = 1;
                                Console.Write("+");
                            }
                            else
                            {
                                field[j, k] = 0;
                                Console.Write("-");
                            }
                        }
                        Console.Write(" ");
                    }
                    Console.Write(System.Environment.NewLine);
                }

                /* this algorithm is to end the game if there are no living cells */ 
                counterDeadCells = 0;
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (field[j, k] == 0)
                        {
                            counterDeadCells++;
                        }
                    }
                }

                /* this algorithm is to end the game if sequence is repeated */
                if (itWasSame == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            isSameField[j, k] = field[j, k];
                        }
                    }
                }
               
                /* this 2 variables are necessary to check the next condition */
                counter = 0;
                itWasSame++;
                if (itWasSame > 1)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            if (isSameField[j, k] == field[j, k])
                            {
                                counter++;
                            }
                            else
                            {
                                itWasSame = 0;
                                counter = 0;
                            }
                        }
                    }
                }

                /* if any of this conditions is true, game ends */
                if (counterDeadCells == m * n || counter == rows * columns)
                {
                    gameOver = false;
                }
                Console.Write(" ");
            }
            Console.Write(System.Environment.NewLine);
            Console.WriteLine("Game Over");
        }
    }
}
