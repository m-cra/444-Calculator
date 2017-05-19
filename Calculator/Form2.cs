using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        RandomClass rc;
        Max max;
        string input1;
        string input2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rc = new RandomClass();
            max = new Max();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            input2 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rc.Solve(input1,input2);        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double ans =  r.NextDouble() * (int)Math.Log10(Math.Pow(10, 3) + 1) + Math.Pow(-Math.Exp(1.0), -7);
            MessageBox.Show("Random Value: " + ans.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            max.Solve(input1, input2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ans = Math.Max(Math.Pow(15, 10), Math.Pow(10, 15));
            MessageBox.Show("Max value is: " + ans.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] array = {3, 20, 1976, 30};
            int val = r.Next(4);
            int ans = array[val];
            MessageBox.Show("Random value in array: " + ans.ToString());
        }
    }

    public class RandomClass
    {
        private String number1;
        private String number2;

        public RandomClass()
        {
            number1 = "";
            number2 = "";
        }
        public RandomClass(string v1, string v2)
        {
            number1 = v1;
            number2 = v2;
        }

        public string Solve(string n1, string n2)
        {
            Calculator calc = new Calculator();
            n1 = calc.setEquationUnsolved(n1);
            n2 = calc.setEquationUnsolved(n2);
            string answer = "";


            if ((n1.Where(x => Char.IsDigit(x)).Any() && n2.Where(x => Char.IsDigit(x)).Any()) || (n1.Length == 0 || n2.Length == 0))
            {
                int ans = 0;
                Random r = new Random();
                ans = r.Next(Convert.ToInt32(n1), Convert.ToInt32(n2));
                answer = ans.ToString();
                MessageBox.Show("The random value is: " + answer);
            }
            else
            {
                MessageBox.Show("Error - input integer or equation");
            }
            return answer;
        }
    }

    public class Max
    {
        private String number1;
        private String number2;

        public Max()
        {
            number1 = "";
            number2 = "";
        }
        public Max(string v1, string v2)
        {
            number1 = v1;
            number2 = v2;
        }

        public string Solve(string n1, string n2)
        {
            Calculator calc = new Calculator();
            n1 = calc.setEquationUnsolved(n1);
            n2 = calc.setEquationUnsolved(n2);
            string answer = "";
            

            if ((n1.Where(x => Char.IsDigit(x)).Any() && n2.Where(x => Char.IsDigit(x)).Any()) || (n1.Length == 0 || n2.Length == 0))
            {
                int ans = 0;
                ans = Math.Max(Convert.ToInt32(n1), Convert.ToInt32(n2));
                answer = ans.ToString();
                MessageBox.Show("The bigger value is: " + answer);
            }
            else
            {
                MessageBox.Show("Error - input integer or equation");
            }
            return answer;
        }
    }
}
