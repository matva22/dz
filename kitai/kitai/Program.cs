using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitai
{
   
    class Program
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Введите число вашего рождения");
            var day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц вашего рождения");
            var mounth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год вашего рождения");
            var year = Convert.ToInt32(Console.ReadLine());
            ZnakZodiaka( day, mounth);
            PerevodGoda( year);
            Visokosgod( year);
            Console.ReadKey();
        }
        public static void PerevodGoda( int year)
        {
            int x = year + 2697;
            int t = (x / 60) + 1;
            int k = x % 60;
            Console.WriteLine(t + " цикл" + "  " + k + "год");


        }
        public static void Visokosgod( int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Вы родились в високосный год");
            }
            else
            {
                Console.WriteLine("Вы родились не в високосный год");
            }
        }
           public static void ZnakZodiaka(int day, int mounth)
        {           
           if (((day>=23)&&(mounth==11))||(((day <= 22) && (mounth == 12))))
                   {
                Console.WriteLine("ваш знак зодиака крыса");
               }
            if (((day >= 23) && (mounth == 12)) || (((day <= 20) && (mounth == 01))))
            {
                Console.WriteLine("ваш знак зодиака бык");
            }
            if (((day >= 21) && (mounth == 01)) || (((day <= 19) && (mounth == 02))))
            {
                Console.WriteLine("ваш знак зодиака тигр");
            }
            if (((day >= 20) && (mounth == 02)) || (((day <= 20) && (mounth == 03))))
            {
                Console.WriteLine("ваш знак зодиака кролик");
            }
            if (((day >= 21) && (mounth == 03)) || (((day <= 20) && (mounth == 04))))
            {
                Console.WriteLine("ваш знак зодиака дракон");
            }
            if (((day >= 21) && (mounth == 04)) || (((day <=20) && (mounth == 05))))
            {
                Console.WriteLine("ваш знак зодиака змея");
            }
            if (((day >= 21) && (mounth == 05)) || (((day <= 20) && (mounth == 06))))
            {
                Console.WriteLine("ваш знак зодиака лошадь");
            }
            if (((day >= 21) && (mounth == 06)) || (((day <= 22) && (mounth == 07))))
            {
                Console.WriteLine("ваш знак зодиака козы");
            }
            if (((day >= 23) && (mounth == 07)) || (((day <= 22) && (mounth == 08))))
            {
                Console.WriteLine("ваш знак зодиака обезьяны");
            }
            if (((day >= 23) && (mounth == 08)) || (((day <= 23) && (mounth == 09))))
            {
                Console.WriteLine("ваш знак зодиака петуха");
                if (((day >= 24) && (mounth == 09)) || (((day <= 23) && (mounth == 10))))
                {
                    Console.WriteLine("ваш знак зодиака собаки");
                }
                if (((day >= 24) && (mounth == 10)) || (((day <= 22) && (mounth == 11))))
                {
                    Console.WriteLine("ваш знак зодиака кабана");
                }
            }
            

        }
    }
}
