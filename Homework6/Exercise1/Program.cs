using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //Задание 1
    //Тюмянцева Ирина
    //Изменить программу вывода функции так, чтобы можно было передавать
    //функции типа double (double,double). Продемонстрировать работу на функции
    //с функцией a*x^2 и функцией a*sin(x).

    public delegate double Fun(double x);

    class Program
    {
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, a*F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции a*Sin при а = 5: ");
            Table(Math.Sin, -2, 2, 5);     
            Console.WriteLine("Таблица функции a*x^2 при а = 5:");
            Table(delegate (double x) { return x * x; }, 0, 3, 5);

            Console.ReadLine();
        }
    }

}

