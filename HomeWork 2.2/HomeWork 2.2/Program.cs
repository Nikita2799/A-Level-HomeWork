using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix(5, 5, 10);
            int[] matrix1 = Matrix(5, 5);

            int even = 0;
            int odd = 0;

            for (int i = 0; i < matrix1.Length; i++)
            {
                if (matrix1[i] % 2 != 0)
                {
                    odd = odd + matrix1[i];
                }
                else
                {
                    even = even + matrix1[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Even: {even} ");
            Console.WriteLine($"Odd : {odd}");
            Console.WriteLine();

            Console.ReadLine();

            int even2 = 0;
            int odd2 = 0;
            DrawMatrix(matrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        odd2 = odd2 + matrix[i, j];
                    else
                        even2 = even2 + matrix[i, j];
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Even 2: {even2} ");
            Console.WriteLine($"Odd 2 : {odd2}");
            Console.WriteLine();

            Console.ReadLine();
        }
        public static int[,] GenerateMatrix(int x, int y, int maxRandom)
        {
            int[,] matrix = new int[x, y];

            Random rnd = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(0, maxRandom);
                }
            }

            return matrix;
        }

        public static void DrawMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{(matrix[i, j].ToString().Length < 2 ? matrix[i, j].ToString() + "  |" : matrix[i, j].ToString() + " |")}");
                }
                Console.WriteLine();
            }
        }

        public static int[] Matrix(int x, int maxRandom)
        {
            int[] matrix1 = new int[x];

            Random rnd = new Random();

            for (int i = 0; i < x; i++)
            {
                matrix1[i] = rnd.Next(0, maxRandom);
                Console.Write(matrix1[i] + "|");
            }

            return matrix1;
        }
    
    }
}
