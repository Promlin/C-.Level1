using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    //Задание 1-б 
    //Тюмянцева Ирина
    //Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            Console.WriteLine("Введите действительную часть первого числа");
            complex1.re = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого числа");
            complex1.im = Int32.Parse(Console.ReadLine());

            Complex complex2 = new Complex();
            Console.WriteLine("Введите действительную часть второго числа");
            complex2.re = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго числа");
            complex2.im = Int32.Parse(Console.ReadLine());

            Complex resultPlus = complex1.Plus(complex2);
            Console.WriteLine("Результат сложения равен: " + resultPlus.ToString());

            Complex resultMinus = complex1.Minus(complex2);
            Console.WriteLine("Результат вычитания равен: " + resultMinus.ToString());

            Complex resultMultiply = complex1.Multiply(complex2);
            Console.WriteLine("Результат умножения равен: " + resultMultiply.ToString());

            Console.ReadLine();

        }
    }

    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = - x2.im + this.im;
            x3.re = - x2.re + this.re;
            return x3;
        }

        public Complex Multiply(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = x2.re * this.re + x2.im*this.re;
            x3.re = x2.im*this.re + this.im * x2.re;
            return x3;
        }

        public string ToString()
        {
            return re + " + (" + im + ")i";
        }
    }
}
