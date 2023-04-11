using System;

namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            /* input data of matrix size */
            Console.WriteLine("### MATRIX MUST BE SQUARE ###");
            Console.Write(System.Environment.NewLine);
            Console.WriteLine("Insert number of rows: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert number of columns: ");
            int n = Convert.ToInt32(Console.ReadLine()); ;

            /* original and modified table */
            int[,] originalTable = new int[m, n];
            int[,] modifiedTable = new int[m, n];

            /* is matrix square? */
            if (m == n)
            {
                /* algorithm to fill the matrix */
                for (int j = 1; j <= m; j++)
                {
                    for (int k = 1; k <= n; k++)
                    {
                        Console.WriteLine("Insert value of the " + j + " row and " + k + " column:");
                        originalTable[j - 1, k - 1] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write(System.Environment.NewLine);

                /* algorithm to write and save the modified table comparing their value to 3 different cases */
                for (int j = 1; j <= m; j++)
                {
                    for (int k = 1; k <= n; k++)
                    {
                        if (k < j)
                        {
                            modifiedTable[j - 1, k - 1] = 0;
                            Console.Write(modifiedTable[j - 1, k - 1] + " ");
                        }
                        if (k > j)
                        {
                            modifiedTable[j - 1, k - 1] = 1;
                            Console.Write(modifiedTable[j - 1, k - 1] + " ");
                        }
                        if (k == j)
                        {
                            modifiedTable[j - 1, k - 1] = originalTable[j - 1, k - 1];
                            Console.Write(modifiedTable[j - 1, k - 1] + " ");
                        }
                    }
                    Console.Write(System.Environment.NewLine);
                }
            }

            /* else if matrix is not square */
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
