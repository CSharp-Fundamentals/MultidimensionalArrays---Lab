using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = ParseArray();
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string cmd = tokens[0];

                if (cmd == "END")
                {
                    break;
                }

                switch (cmd)
                {
                    case "Add":
                        int row = int.Parse(tokens[1]);
                        int col = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);

                        if (isValid(rows, jagged, row, col))
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        else
                        {
                            jagged[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        row = int.Parse(tokens[1]);
                        col = int.Parse(tokens[2]);
                        value = int.Parse(tokens[3]);

                        if (isValid(rows, jagged, row, col))
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        else
                        {
                            jagged[row][col] -= value;
                        }
                        break;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool isValid(int rows, int[][] jagged, int row, int col)
        {
            return row < 0 || row >= rows || col<0 || col >= jagged[row].Length;
        }

        private static int[] ParseArray()
                 => Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
    }
}
