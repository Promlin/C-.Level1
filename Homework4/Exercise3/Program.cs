using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise3
{
    //Задание 3
    //Тюмянцева Ирина
    //Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
    //Создайте структуру Account, содержащую Login и Password.
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("toRead.txt");

            string[] loginAndPassword = new string[2];
            loginAndPassword[0] = sr.ReadLine();
            loginAndPassword[1] = sr.ReadLine();

            String trueLogin = loginAndPassword[0];
            String truePassword = loginAndPassword[1];

            int numberOfTry = 1;
            do
            {
                Console.WriteLine("Введите логин");
                Account.login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                Account.password = Console.ReadLine();
                if (Account.login == trueLogin && Account.password == truePassword)
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

            sr.Close();
        }
    }
    struct Account
    {
        public static String login;
        public static String password;
    }
}
