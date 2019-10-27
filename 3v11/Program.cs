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
            Console.WriteLine("Введите чему равна сторона a");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чему равна сторона б");
            var v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чему равна сторона с");
            var c = Convert.ToInt32(Console.ReadLine());           
            if ((x > 0) && (v > 0) && (c > 0) && (x + v > c) && (v + c > x) && (c + x > v))
            {

                Perimitr( x ,v, c);
                Ploshad(x, v, c );
                PloshadOkr(x, v, c );
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");

            }
            Console.ReadKey();
        }

        public static void Perimitr(int x, int v,int c)
        {                    
                double per = x + c + v;                                                           
                Console.WriteLine($"Перимитр равен"+ per);                                                                        
        }
        public static void Ploshad(int x, int v, int c)
        {
            double poluper = (v+c+x)/2;
            double plo = (poluper * (poluper - x) * (poluper - v) * (poluper - c));
            double ploshad = Math.Sqrt(plo);
            Console.WriteLine($"Площадь равна" + ploshad);
        }
        public static void PloshadOkr(int x, int v, int c)
        {
            double poluper = (v + c + x) / 2;
            double plo = (poluper * (poluper - x) * (poluper - v) * (poluper - c));
            double ploshad = Math.Sqrt(plo);
            double radius = 2 * ploshad / (v + x + c) ;
            double ploshadokr = x * v * c / 4 * radius;
            Console.WriteLine($"Площадь треугольника, вписанного в окружность равна " + ploshadokr);
            
        }

        



        }
    }

