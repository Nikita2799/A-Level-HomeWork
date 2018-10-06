using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            string mess = "18fdas99dsfadf88sfsdg9gffd11dfsgsd11fda6";
            string st = "";

            Console.WriteLine("Your Strin: "+mess);
            Console.ReadLine();

            Console.Write("Numbers in the string:  ");
            Console.ReadLine();

            for (int i = 0; i < mess.Length; i++)
            {

                if (Convert.ToInt32(mess[i]) > 48 && Convert.ToInt32(mess[i]) <= 57)
                {

                    st += mess[i];
                    Console.Write(st + " ");
                    st = "";

                }
            }

           
            for (int i = 0; i < mess.Length; i++)
            {
                
                if (Convert.ToInt32(mess[i]) > 48 && Convert.ToInt32(mess[i]) <= 57)
                {

                    st += mess[i];
                    
                }
                else if (st != "")
                {

                    sum += Convert.ToInt32(st);
                    st = "";

                }

                 if (st != ""&&i==mess.Length-1)
                {

                    sum += Convert.ToInt32(st);
                    st = "";
                   
                }
            }


            Console.ReadLine();
            Console.WriteLine();

            Console.Write("Your Sum: "+sum);
            

            Console.ReadLine();
           
        }
    }
}
