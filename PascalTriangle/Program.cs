using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height][];

            for (int row = 0; row < height; row++)
            {
                long[] currentRow = new long[row + 1];
                currentRow[0] = 1;
                currentRow[row] = 1;

                for (int col = 1; col < row; col++)
                {
                    currentRow[col] = triangle[row - 1][col] + triangle[row - 1][col - 1];
                }
                triangle[row] = currentRow;
            }

            for (int row = 0; row < height; row++)
            {
                Console.WriteLine(string.Join(' ',triangle[row]));
            }
        }
    }
}
