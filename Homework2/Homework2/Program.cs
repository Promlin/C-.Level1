using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            //Тюмянцева Ирина
            //Написать метод, возвращающий минимальное из трех чисел.
            FirstExercise();

            //Задание 2
            //Тюмянцева Ирина
            //Написать метод подсчета количества цифр числа.
            SecondExercise();

            //Задание 3
            //Тюмянцева Ирина
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            ThirdExercise();

            //Задание 4
            //Тюмянцева Ирина
            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            ForthExercise();

            //Задание 5
            //Тюмянцева Ирина
            //а) Написать программу, которая запрашивает массу и рост человека, 
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            FifthExercise();

            //Задание 7
            //Тюмянцева Ирина
            //Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);
            SeventhExercise();
        }

        public static void FirstExercise()
        {
            Console.WriteLine("Метод возвращающий меньшее из трех чисел");
            Console.WriteLine("Вводите числа через Enter");
            int numberOne = Int32.Parse(Console.ReadLine());
            int numberTwo = Int32.Parse(Console.ReadLine());
            int numberThree = Int32.Parse(Console.ReadLine());
            int min;
            if (numberOne <= numberTwo)
            {
                if (numberOne < numberThree)
                {
                    min = numberOne;
                }
                else
                {
                    min = numberThree;
                }
            }
            else
            {
                if (numberTwo <= numberThree)
                {
                    min = numberTwo;
                }
                else
                {
                    min = numberThree;
                }
            }

            Console.WriteLine("Минимальное число - " + min);
            Console.ReadLine();

        }

        public static void SecondExercise()
        {
            Console.WriteLine("Метод находящий количество цифр в числе");
            Console.WriteLine("Введите число");
            String number = Console.ReadLine();
            int count = number.ToString().Length;
            Console.WriteLine("Количество цифр в числе равно " + count);
            Console.ReadLine();
        }

        public static void ThirdExercise()
        {
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитывается сумма всех нечетных положительных чисел.");
            int sum = 0;
            while (true)
            {
                int number = Int32.Parse(Console.ReadLine());
                if (number != 0)
                {
                    //сумма нечетных положительных чисел
                    if (number > 0 && number % 2 == 1)
                    {
                        sum = sum + number;
                    }
                }
                else
                {
                    Console.WriteLine("Сумма нечетных положительных чисел равна " + sum);
                    break;
                }
            }
            Console.ReadLine();
        }

        public static void ForthExercise()
        {
            Console.WriteLine("Метод проверяющий верность логина и пароля");
            int numberOfTry = 1;
            String trueLogin = "root";
            String truePassword = "GeekBrains";
            do
            {
                Console.WriteLine("Введите логин");
                String login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                String password = Console.ReadLine();
                if (login == trueLogin && password == truePassword)
                {
                    Console.WriteLine("Доступ разрешен");
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз. Вы использовали " + numberOfTry + " попыток из 3");
                    numberOfTry++;
                }

            } while (numberOfTry < 4);
            Console.ReadLine();
        }

        public static void FifthExercise()
        {
            Console.WriteLine("Рассчет индекса массы тела");
            Console.WriteLine("Введите Ваш рост (целое значение)");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес (целое значение)");
            int weight = int.Parse(Console.ReadLine());
            if (height != 0)
            {
                float a = (height) * (height);
                float index = weight / a;
                index = index * 10000;//ввод роста производился в см, поэтому для перевода в м^2 домножаю на 10000
                if (index < 18.5)
                {
                    Console.WriteLine("Вам следует набрать вес");
                }
                else if (index > 25)
                {
                    Console.WriteLine("Вам следует похудеть");
                }
                else
                {
                    Console.WriteLine("Ваш вес в норме");
                }
            }
            else
            {
                Console.WriteLine("Убедитесь в правильности данных");
            }
            Console.ReadLine();
        }

        public static void SeventhExercise()
        {
            Console.WriteLine("Метод выводящий числа от а до b");
            Console.WriteLine("Введите меньшее из двух чисел");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее из двух чисел");
            int b = Int32.Parse(Console.ReadLine());
            if (a < b)
            {
                MethodForExercise(a, b);
            }
            Console.ReadLine();
        }
        public static void MethodForExercise(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                MethodForExercise(a+1, b);
            }
        }

    }
}
