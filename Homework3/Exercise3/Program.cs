using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    //Задание 2
    //Тюмянцева Ирина
    //С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    //Требуется подсчитать сумму всех нечетных положительных чисел. 
    //Сами числа и сумму вывести на экран, используя tryParse
    //Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    //При возникновении ошибки вывести сообщение. Напишите соответствующую функцию
    class Program
    {
        static void Main(string[] args)
        {
            WorkingMethod();
        }

        public static void WorkingMethod()
        {
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитывается сумма всех нечетных положительных чисел.");
            int sum = 0;
            while (true)
            {
                int a;
                Console.WriteLine("Введите число");
                string number = Console.ReadLine();
                bool result = int.TryParse(number, out a); //Проверка на то, является ли введенная величина целым числом
                if (result == true)
                {
                    if (a != 0)
                    {
                        //сумма нечетных положительных чисел
                        if (a > 0 && a % 2 == 1)
                        {
                            sum = sum + a;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Сумма нечетных положительных чисел равна " + sum);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Убедитесь в правильности введенных данных и попробуйте еще раз"); //Если пользователь ввел не целое число, то он увидит это сообщение
                }
            }
            Console.ReadLine();
        }
    }
}
