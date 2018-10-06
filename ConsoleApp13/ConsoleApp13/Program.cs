﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = GenerateMatrix(10, 10, 21);
            
            DrawMatrix(matrix);
            int Number = 0;
            int Minmum = -1;

            while (Number < 10)
            {

                Minmum = Minmum + 1;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (matrix[i, j] == Minmum)
                        {
                            Minmum = matrix[i, j];
                            Console.WriteLine($"index: [{i},{j}],value: {Minmum}");
                            Number = Number + 1;
                            
                        }
                        if (Number == 10)
                        {
                            break;
                        }
                    }
                    if (Number == 10)
                    {
                        break;
                    }
                }
                
            }

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



    }
}
