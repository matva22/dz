using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieigorya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько  должен содержать чисел массив");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите порядковый номер,который хотите удалить");
            var a = Convert.ToInt32(Console.ReadLine(     ));
            metod(x,a);
            Console.ReadKey();

        }
        public static void metod(int x,int a)
        {
            int[] nums = new int[x];
            Random rand = new Random();          
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 60);
                
                if((a>i) | (a<i))
                  {
                    Console.WriteLine($"порядковй номер "+(i)+" равен "+nums[i]) ;
                }                                                              
            }
            Console.WriteLine($"удалённый:↓↓↓↓↓↓");
            Console.Write($"порядковй номер " + (a) + " равен " + nums[a]);

        }
    }
}
