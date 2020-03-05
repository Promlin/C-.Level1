using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise2
{
    //Задание 2
    //Тюмянцева Ирина
    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделайте меню с различными функциями и предоставьте пользователю выбор,
    //для какой функции и на каком отрезке находить минимум.
    //б) Используйте массив (или список) делегатов, в котором хранятся различные функции.

    class Program
    {
        delegate void Function(int firstValue, int secondValue);
        static void Main(string[] args)
        {
            Function choosenFunction;

            Console.WriteLine("Введите 1 чтобы найти минимум для функции y=x^2 и 2 для функции у=x");
            string putNumber = Console.ReadLine();
            int a;
            bool result = int.TryParse(putNumber, out a);
            if (a == 1)
            {
                choosenFunction = MultyX;
            }
            else
            {
                choosenFunction = xEqualY;
            }

            choosenFunction(2,8);

        Console.ReadLine();
        }

        private static void MultyX(int firstValue, int secondValue)
        {
            Console.WriteLine("Функция y=x^2");
            int[] array = new int[secondValue-firstValue];
            for (int k = 0; k < secondValue-firstValue; k++)
            {
                int multiplicity = firstValue*firstValue;
                array[k] = multiplicity;
                Console.WriteLine("y = " + firstValue + " |  x = " + multiplicity);
                firstValue++;
            }

            int minValue = 10000;
            for (int i = 0; i <= secondValue-firstValue; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine("Минимальное значение функции " + minValue);
        }

        private static void xEqualY(int firstValue, int secondValue)
        {
            Console.WriteLine("Функция y=x^2");
            int[] array = new int[secondValue-firstValue];
            int value = firstValue;
            for (int k = 0; k < secondValue-firstValue; k++)
            {
                array[k] = value;
                Console.WriteLine("y = " + firstValue + " |  x = " + value); //firstValue для работы с осью Y, value - x
                firstValue++;
                value++;
            }
            int min = 10000;
            for (int k = 0; k <= secondValue; k++)
            {
                if (array[k] < min)
                {
                    min = array[k];
                }
            }
            Console.WriteLine("Минимальное значение функции " + min);
        }


    }

    
}

