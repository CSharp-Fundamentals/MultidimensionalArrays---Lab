using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ParseArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int [rows,cols];

            for (int row = 0;row < rows;row++)
            {
                int[] currentRow = ParseArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sum = 0;

            foreach (int number in matrix)
            {
                sum+=number;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }

        private static int[] ParseArray()
        => Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}
