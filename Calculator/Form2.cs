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
        RandomClass RandomClass;
        string input1;
        string input2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RandomClass = new RandomClass();
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
            MessageBox.Show(RandomClass.Solve(input1, input2));
        }
    }

    public class RandomClass
    {
        String Number1;
        String Number2;
        public string Solve(string n1, string n2)
        {
            return "Hi";
        }
    }
}
