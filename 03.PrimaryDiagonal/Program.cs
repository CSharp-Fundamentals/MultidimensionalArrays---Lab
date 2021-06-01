using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
            int diagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = ParseArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int i = 0; i < n; i++)
            {
                diagonalSum += matrix[i, i];
            }
            Console.WriteLine(diagonalSum);
        }

        private static int[] ParseArray()
        => Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}
