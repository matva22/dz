using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3v11
{
    class Program
    {
        static void Main(string[] args)
        {
            PerimitrPloshadPloshadOkr();
            
        }
        
        public static void PerimitrPloshadPloshadOkr()
        {
            
            Console.WriteLine("Введите чему равна сторона a");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите чему равна сторона б");
            var v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите чему равна сторона с");
            var c = Convert.ToDouble(Console.ReadLine());
            if ((x > 0) && (v > 0) && (c > 0) && (x + v > c) && (v + c > x) && (c + x > v))
            { 
                double per = x + c + v;                
                double plo;
                double p = ((v + c + x) / 2);
                double ploshad1 = (p * (p - x) * (p - v) * (p - c));               
                plo = Math.Sqrt(ploshad1);                
                double radius = ((p - x) * (p - v) * (p - c) / p);
                double PloshadTreugSOkrug =per/4*radius;





                Console.WriteLine($"Перимитр равен"+ per);
                Console.WriteLine($"Площадь равна" + plo);
                Console.WriteLine($"Площадь треугольника, вписанного в окружность равна "+ PloshadTreugSOkrug);


               
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            Console.ReadKey();
        }
        
                  
            
        }
    }

