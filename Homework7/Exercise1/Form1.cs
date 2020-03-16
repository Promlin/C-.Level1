using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double rightAnswer = GenerateNumber();
        private void buttonToGetNumber_Click(object sender, EventArgs e)
        {
            var userAnswer = gettingNumber.Text;
            int answer;
            bool result = int.TryParse(userAnswer, out answer);
            if (result == true)
            {
                bool ifAnswerCorrect = Check(answer, rightAnswer);
                if (ifAnswerCorrect)
                {
                    MessageBox.Show("Вы угадали");
                }
                else
                {
                    MessageBox.Show("Попробуйте еще раз");
                    gettingNumber.Clear();
                }
            }
            else
            {
                string textAboutMistake = "Убедитесь в том, что ввели корректный ответ";
                MessageBox.Show(textAboutMistake);
                gettingNumber.Clear();
            }
        }

        public static double GenerateNumber()
        {
            Random rnd = new Random();
            double number = rnd.Next() * 100;
            number = Math.Round(number);
            return number;
        }

        public static bool Check(int userAnswer, double rightAnswer)
        {
            if (userAnswer == rightAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
