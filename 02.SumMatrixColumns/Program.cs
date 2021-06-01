using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = ParseArrayFromConsole(new[] { ' ', ',' });

            int rows = tokens[0];
            int cols = tokens[1];
            int[,] matrix = new int[rows, cols];
            List<int> colSums = new List<int>();

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = ParseArrayFromConsole(new[] { ' ' });
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCurrentColumn = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCurrentColumn += matrix[row, col];
                }
                colSums.Add(sumOfCurrentColumn);
            }
            Console.WriteLine(string.Join("\n",colSums));
        }

        static int[] ParseArrayFromConsole(char[] splitSymbols)
        => Console.ReadLine()
                .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}