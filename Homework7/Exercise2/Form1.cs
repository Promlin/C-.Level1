using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool firstCase = false;
        bool secondCase = false;
        bool thirdCase = false;
        bool fourthCase = false;
        bool fifthCase = false;
        bool sixthCase = false;
        bool seventhCase = false;
        bool eighthCase = false;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();


        private void Button1_1_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase)
            {
                secondCase = true;
                button1_1.BackColor = Color.Brown;
                button1_1.Text = "2";
            }
        }

        private void Button1_2_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase && secondCase && thirdCase && fourthCase && fifthCase && sixthCase)
            {
                seventhCase = true;
                button1_2.BackColor = Color.Brown;
                button1_2.Text = "7";
            }
        }

        private void Button1_3_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase && secondCase)
            {
                thirdCase = true;
                button1_3.BackColor = Color.Brown;
                button1_3.Text = "3";
            }
        }

        private void Button2_1_Mouse(object sender, EventArgs e)
        {
            if (firstCase && secondCase && thirdCase && fourthCase && fifthCase && sixthCase && seventhCase && eighthCase)
            {
                button2_1.BackColor = Color.Brown;
                button2_1.Text = "9";
            }
        }

        private void Button2_2_Mouse(object sender, EventArgs e)
        {
            firstCase = true;
            button2_2.BackColor = Color.Brown;
            button2_2.Text = "1";
        }

        private void Button2_3_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase && secondCase && thirdCase && fourthCase && fifthCase)
            {
                sixthCase = true;
                button2_3.BackColor = Color.Brown;
                button2_3.Text = "6";
            }
        }

        private void Button3_1_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase && secondCase && thirdCase && fourthCase && fifthCase && sixthCase && seventhCase)
            {
                eighthCase = true;
                button3_1.BackColor = Color.Brown;
                button3_1.Text = "8";
            }
        }

        private void Button3_2_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase && secondCase && thirdCase)
            {
                fourthCase = true;
                button3_2.BackColor = Color.Brown;
                button3_2.Text = "4";
            }
        }

        private void Button3_3_Mouse(object sender, EventArgs e)
        {
            
            if (firstCase && secondCase && thirdCase && fourthCase)
            {
                fifthCase = true;
                button3_3.BackColor = Color.Brown;
                button3_3.Text = "5";
            }
        }
    }
}
