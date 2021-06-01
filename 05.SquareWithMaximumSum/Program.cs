using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ParseArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            int[,] maxMatrix = new int[2,2];
            int maxSum = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = ParseArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col+1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        maxMatrix = maxMatrix = new int[2, 2]
                            {
                                { matrix[row, col],matrix[row, col+1]},
                                { matrix[row + 1, col],matrix[row + 1, col + 1]}
                            };
                    }
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(maxMatrix[row,col]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }

        private static int[] ParseArray()
        => Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
