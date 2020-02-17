using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Тюмянцева Ирина
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $
            firstExercise();

            //Задание 2
            //Тюмянцева Ирина
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            secondExercise();

            //Задание 3
            //Тюмянцева Ирина
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            thirdExercise();

            //Задание 4
            //Тюмянцева Ирина
            //Написать программу обмена значениями двух переменных.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            fourthExercise();

            //Задание 5
            //Тюмянцева Ирина
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организуйте в центре экрана
            fifthExercise();
        }

        public static void firstExercise()
        {
            Console.WriteLine("Программа анкета");
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите Ваш рост");
            string height = Console.ReadLine();
            Console.WriteLine("Введите Ваш вес");
            string weight = Console.ReadLine();
            Console.WriteLine("Вывод с использованием склеивания" + "Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: "
                + weight);
            Console.WriteLine("Вывод с форматированием Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name, surname, age, height, weight);
            Console.WriteLine("Вывод с использованием знака '$' -  " + $"Имя: {name}," + $"Фамилия: {surname}," + $"Возраст: {age}," + $"Рост: {height}," + $"Вес: {weight} ");
            Console.ReadLine();

        }

        public static void secondExercise()
        {
            Console.WriteLine("Рассчет индекса массы тела");
            Console.WriteLine("Введите Ваш рост (целое значение)");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес (целое значение)");
            int weight = int.Parse(Console.ReadLine());
            if (height != 0)
            {
                float a = height * height;
                float b = weight / a;
                Console.WriteLine("Индекс массы тела равен " + b);
            }
            else
            {
                Console.WriteLine("Убедитесь в правильности данных");
            }
            Console.ReadLine();
        }

        public static void thirdExercise()
        {
            Console.WriteLine("Программа для расчета расстояния между точками");
            Console.WriteLine("Введите координату х1 (целое значение)");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату у1 (целое значение)");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату х2 (целое значение)");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату у2 (целое значение)");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние равно: " + Math.Round(calculatingForThirdExercise(x1, y1, x2, y2), 2));
            Console.ReadLine();
        }

        static double calculatingForThirdExercise(int x1, int y1, int x2, int y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }

        public static void fourthExercise()
        {
            Console.WriteLine("Программа для обмена местами значений переменных");
            Console.WriteLine("Введите значение х (целое значение)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение у (целое значение)");
            int y = int.Parse(Console.ReadLine());
            //int c = x; С использованием третьей переменной
            //x = y;
            //y = c;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Значение x - " + x + " Значение y - " + y);
            Console.ReadLine();
        }

        public static void fifthExercise()
        {
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите Ваш город");
            string city = Console.ReadLine();
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Город: " + city);
            Console.WriteLine("{0,50}", "Имя: " + name + " Фамилия: " + surname + " Город: " + city);//вывод сообщения по центру
            Console.ReadLine();
        }

    }
}
1