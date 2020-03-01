using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //Задание 1
    //Тюмянцева Ирина
    //Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов, содержащая
    //только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль");
            string login = Console.ReadLine();

            string s1 = login;
            StringBuilder sb = new StringBuilder(s1);

            bool mistake1 = IfFirstLetter(sb[0]); //Подается первый символ
            bool mistake2 = IfEnoughtLetters(login);

            if (mistake1 == false && mistake2 == false)
            {
                Console.WriteLine("Логин удовлетворяет условиям");
            }

            Console.ReadLine();
        }

        public static bool IfFirstLetter(char sb)
        {
            bool mistake = false;
            for (int j = 0; j< 10; j++)
            {
                if (sb.ToString() == j.ToString()) //Проверка является ли первый символ цифрой
                {
                    Console.WriteLine("Первый символ не должен быть цифрой");
                    mistake = true;
                    return mistake;
                }
            }
            return mistake;
        }

        public static bool IfEnoughtLetters(string login)
        {
            bool mistake = false;
            if (login.Length < 2 || login.Length > 10)
            {
                Console.WriteLine("Логин должен быть от 2 до 10 символов");
                mistake = true;
                return mistake;
            }
            return mistake;
        }

    }
}
