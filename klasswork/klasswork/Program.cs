using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько должен содержать чисел массив");
            var x = Convert.ToInt32(Console.ReadLine());
            metod(x);
            Console.ReadKey();
            
        }
        public static void metod(int x)
        {
            int[] nums = new int[x];
            Random rand = new Random();
            int max = int.MinValue;
            for (int i = 0; i <nums.Length; i++)
            {
                nums[i] = rand.Next(1, 60);
                Console.WriteLine(nums[i]);
                if (nums[i] > max)
                {
                    
                    max = nums[i];
                }
                    
            }
            Console.WriteLine($"наибольшее значение" + "  " +max);
        }
    }
}
