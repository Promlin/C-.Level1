using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //Задание 1
    //Тюмянцева Ирина
    //Дан целочисленный массив из 20 элементов.
    //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    //Написать программу, позволяющую найти и вывести количество пар элементов массива,
    //в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Например, для массива из пяти элементов: 6; 2; –3; 9; 6 – ответ: 4.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив из 20 чисел");
            int[] array = new int[20];
            array = MakingArray(array);
            Console.WriteLine(string.Join(",", array));
            FindingMultiplicity(array);
            Console.ReadLine();
        }

        static int[] MakingArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10000, 10000);

            }
            return array;
        }

        public static void FindingMultiplicity(int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] % 3 == 0 || array[i+1] % 3 == 0)
                {
                    number++;
                }
            }
            Console.WriteLine("Количество пар, в котрых хотя бы одно число кратно 3 равно " + number);
        }

    }
}
