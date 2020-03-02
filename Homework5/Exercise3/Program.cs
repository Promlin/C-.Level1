
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise3
{
    //Задание 2
    //Тюмянцева Ирина
    //Разработать класс Message, содержащий следующие 
    //статические методы для обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //Продемонстрируйте работу программы на текстовом файле с вашей программой.
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("toRead.txt");

            string message = sr.ReadLine();

            string[] messageArray = new string[50];
            messageArray = message.Split(' ');

            Console.WriteLine("Сообщение: " + message);

            Message.NotLessThatNSymbols(messageArray);
            Message.DeleteWords(messageArray);
            Message.TheLongestWord(messageArray);
            Message.TheArrayOfWords(messageArray);

            Console.ReadLine();
            sr.Close();
        }
    }

    class Message
    {
        public static void NotLessThatNSymbols(string[] messageArray)
        {
            Console.WriteLine("Данный метода выводит слова в которых не более 5 букв");
            Console.Write("Получившиеся слова: ");
            for (int i = 0; i < messageArray.Length; i++)
            {
                if (messageArray[i].Length < 5)
                {
                    Console.Write(messageArray[i] + " ");
                }
            }
            Console.WriteLine(" ");
        }

        public static void DeleteWords(string[] messageArray)
        {
            Console.WriteLine("Данный метод удаляет все слова оканчивающиеся на букву 'м'");
            Regex myReg = new Regex(@"[м]$");

            for (int i = 0; i < messageArray.Length; i++)
            {
                bool result = myReg.IsMatch(messageArray[i]);
                if (result == true)
                {
                    messageArray[i] = "";
                }
            }
            Console.WriteLine("Получившийся массив: " + string.Join(" ", messageArray));
        }

        public static void TheLongestWord(string[] messageArray)
        {
            Console.WriteLine("Данный метод выводит самое длинное слово в сообщении");
            int letters = 0;
            string theLongestWord = messageArray[0];
            for ( int i = messageArray[0].Length; i < messageArray.Length; i++)
            {
                if (letters <= messageArray[i].Length)
                {
                    letters = messageArray[i].Length;
                    theLongestWord = messageArray[i];
                }
            }
            Console.WriteLine("Самое длинное слово: " + theLongestWord);
        }

        public static void TheArrayOfWords(string[] messageArray)
        {
            string[] arrayOfWords = new string[100];
            Console.WriteLine("Данный метод выводит самые длинные слова в сообщении");
            int letters = 0;
            for (int i = messageArray[0].Length; i < messageArray.Length; i++)
            {
                if (letters <= messageArray[i].Length)
                {
                    letters = messageArray[i].Length;
                }
            }
            int k = 0;
            for (int j = 0; j < messageArray.Length; j++)
            {
                if (letters == messageArray[j].Length)
                {
                    arrayOfWords[k] = messageArray[j];
                    k++;
                }
            }
            Console.WriteLine("Самые длинные слова: " + string.Join(" ", arrayOfWords));
        }
    }
}
