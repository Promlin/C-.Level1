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
    //а) Дописать класс для работы с одномерным массивом. Реализовать конструктор,
    //создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
    //Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
    //метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
    //В Main продемонстрировать работу класса.
    //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("forText.txt");
            StreamReader sr = new StreamReader("toRead.txt");

            //Console.WriteLine("Введите количество элементов массива");
            //string number = Console.ReadLine();
            //int numberOfElements;
            //bool result = int.TryParse(number, out numberOfElements);
            int numberOfElements;
            string number = sr.ReadLine();
            bool result = int.TryParse(number, out numberOfElements);

            //Console.WriteLine("Введите значение минимального элемента");
            //String min = Console.ReadLine();
            //int minValue;
            //bool result2 = int.TryParse(min, out minValue);
            int minValue;
            string min = sr.ReadLine();
            bool result1 = int.TryParse(min, out minValue);

            //Console.WriteLine("Введите значение шага между значениями");
            //String step = Console.ReadLine();
            //int stepForArray;
            //bool result3 = int.TryParse(step, out stepForArray);
            int stepForArray;
            string step = sr.ReadLine();
            bool result3 = int.TryParse(step, out stepForArray);

            MyArray array = new MyArray(numberOfElements, minValue, stepForArray);

            Console.WriteLine("Mассив: " + string.Join(" ", array.PrintArray));
            sw.WriteLine("Mассив: " + string.Join(" ", array.PrintArray));

            Console.WriteLine("Сумма элементов массива: " + array.Sum);
            sw.WriteLine("Сумма элементов массива: " + array.Sum);

            Console.WriteLine("Количество максимальных элементов массива: " + array.MaxCount);
            sw.WriteLine("Количество максимальных элементов массива: " + array.MaxCount);

            Console.WriteLine("Массив с значениями умноженными на введенное число 5: " + string.Join(" ", array.Multy));
            sw.WriteLine("Массив с значениями умноженными на введенное число 5: " + string.Join(" ", array.Multy));
            array = new MyArray(numberOfElements, minValue, stepForArray);

            Console.WriteLine("Массив с измененными знаками: " + string.Join(" ", array.Inverse));
            sw.WriteLine("Массив с измененными знаками: " + string.Join(" ", array.Inverse));
            array = new MyArray(numberOfElements, minValue, stepForArray);

            sw.Flush();
            sw.Close();

            sr.Close();

            Console.ReadLine();
        }
    }

    class MyArray
    {
        int[] array;
        public MyArray(int numberOfElements, int value, int stepForArray)
        {
            array = new int[numberOfElements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
                value += stepForArray;
            }
        }

        public int[] PrintArray
        {
            get
            {
                return array;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for(int i = 0; i< array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
        }

        public int[] Inverse
        {
            get
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] * (-1);
                }
                return array;
            }
        }

        public int[] Multy
        {
            get
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] * 5;
                }
                return array;
            }
        }

        public int MaxCount
        {
            get
            {
                int maxValue = 0;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= maxValue)
                    {
                        maxValue = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == maxValue)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

    }
}
