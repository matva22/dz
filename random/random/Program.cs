using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадай число от 1 до 100");
            int n = 0;
            Random rn = new Random();
            int a = rn.Next(0, 100);
            while (n < 11)
            {
                n++;                                              
                int b = Convert.ToInt32(Console.ReadLine());

                if (a == b)
                {
                    Console.WriteLine("Вы угадали:" + b);
                    n = 11;
                }
                else if (a > b)
                    Console.WriteLine(" Ваше число больше");
                else if (a < b)
                    Console.WriteLine(" Ваше число меньше");             

            }
            Console.ReadKey();
        }
    }
}
