using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 
{

    //Задание 1-а 
    //Тюмянцева Ирина
    //Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры
    struct ComplexNumber //создание структуры для комплексного числа
    {
        public double realPart;
        public double imPart;

        public ComplexNumber Plus(ComplexNumber x)
        {
            ComplexNumber y;
            y.realPart = realPart + x.realPart;
            y.imPart = imPart + x.imPart;
            return y;
        }

        public ComplexNumber Minus(ComplexNumber x)
        {
            ComplexNumber y;
            y.realPart = realPart - x.realPart;
            y.imPart = imPart - x.imPart;
            return y;
        }

        public string ToString()
        {
            return realPart + "+" + imPart + "i";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complex1;
            Console.WriteLine("Введите действительную часть первого числа");
            complex1.realPart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого числа");
            complex1.imPart = Int32.Parse(Console.ReadLine());

            ComplexNumber complex2;
            Console.WriteLine("Введите действительную часть второго числа");
            complex2.realPart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго числа");
            complex2.imPart = Int32.Parse(Console.ReadLine());


            ComplexNumber resultPlus = complex1.Plus(complex2);
            Console.WriteLine("Результат сложения " + resultPlus.ToString());
            ComplexNumber resultMinus = complex1.Minus(complex2);
            Console.WriteLine("Результат вычитания " + resultMinus.ToString());
            Console.ReadLine();
        }
    }
}
