using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise2
{
    //Задание 1
    //Тюмянцева Ирина
    //Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов, содержащая
    //только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //б) с использованием регулярных выражений.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль");
            string login = Console.ReadLine();

            Regex myReg = new Regex(@"^\D[a-zA-Z0-9]{1,9}$");

            bool result = myReg.IsMatch(login);

            if (result == true)
            {
                Console.WriteLine("Логин удовлетворяет условиям");
            }
            else
            {

                Console.WriteLine("Логин не удовлетворяет условиям");
            }

            Console.ReadLine();
        }
    }
}
