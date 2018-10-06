using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorke1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before sorting");

            int[] arr = new int[10] { -5, 6, 8, -3, 4, 1, -2, -4, 9, -7 };

            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");

            }
            Console.ReadLine();

            Console.WriteLine("After sorting");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;

                    }


                }


                Console.Write(arr[i] + " ");
            }




            Console.ReadLine();





        }


    }
}
