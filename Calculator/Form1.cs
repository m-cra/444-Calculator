﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;
using System.Xml;
using System.Linq;
using System.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculator Calc;
        string dataType = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calc = new Calculator();
            this.MaximumSize = new System.Drawing.Size(401, 692);
            this.MinimumSize = new System.Drawing.Size(401, 692);
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.1\nThis Calculator was created by Michael, James and Zach.\n4/7/2017");
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Calc.PrintHisotry());
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                historyLabel.Text = Calc.equationUnsolved.ToString() + " ->";
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.Solve());
                Calc.equationUnsolved.Clear();
                e.Handled = true;
            }
            else if(e.KeyChar == (char)Keys.Back) 
            {
                if (Calc.equationUnsolved.Length != 0)
                {
                    Calc.equationUnsolved.Length -= 1;
                }
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else
            {
                if (Calc.checkSolved())
                {
                    richTextBox1.Clear();
                    Calc.setCheckSolved();
                    Calc.equationUnsolved.Append(e.KeyChar); 
                }
                else
                {
                    Calc.equationUnsolved.Append(e.KeyChar);
                }
            }
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterButton_MouseEnter(object sender, EventArgs e)
        {

            var button = (Button)sender;
            button.BackColor = System.Drawing.Color.Gray;

        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = System.Drawing.Color.LightGray;
        }


        private void enterButton_Click_1(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string btnName = button.Name;
            richTextBox1.AppendText(btnName);

            if (btnName.Equals("percentButton"))
            {
                Calc.equationUnsolved.Append("%");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("squareRootButton"))
            {
                Calc.equationUnsolved.Append("√(");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("squareButton"))
            {
                Calc.equationUnsolved.Append("^2");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("equalButton"))
            {
                Calc.equationUnsolved.Append("=");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("leftParaButton"))
            {
                Calc.equationUnsolved.Append("(");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("rightParaButton"))
            {
                Calc.equationUnsolved.Append(")");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("clearButton"))
            {
                Calc.equationUnsolved.Clear();
                richTextBox1.Clear();
            }
            else if (btnName.Equals("delButton"))
            {
                if (Calc.equationUnsolved.Length != 0)
                {
                    Calc.equationUnsolved.Length -= 1;
                }
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("sevenButton"))
            {
                Calc.equationUnsolved.Append("7");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("eightButton"))
            {
                Calc.equationUnsolved.Append("8");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("nineButton"))
            {
                Calc.equationUnsolved.Append("9");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("multiplyButton"))
            {
                Calc.equationUnsolved.Append("*");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("fourButton"))
            {
                Calc.equationUnsolved.Append("4");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("fiveButton"))
            {
                Calc.equationUnsolved.Append("5");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("sixButton"))
            {
                Calc.equationUnsolved.Append("6");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("minusButton"))
            {
                Calc.equationUnsolved.Append("-");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("oneButton"))
            {
                Calc.equationUnsolved.Append("1");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("twoButton"))
            {
                Calc.equationUnsolved.Append("2");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("threeButton"))
            {
                Calc.equationUnsolved.Append("3");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("plusButton"))
            {
                Calc.equationUnsolved.Append("+");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("decimalButton"))
            {
                Calc.equationUnsolved.Append(".");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("zeroButton"))
            {
                Calc.equationUnsolved.Append("0");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("divButton"))
            {
                Calc.equationUnsolved.Append("/");
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.equationUnsolved.ToString());
            }
            else if (btnName.Equals("enterButton"))
            {
                historyLabel.Text = Calc.equationUnsolved.ToString() + " ->";
                richTextBox1.Clear();
                richTextBox1.AppendText(Calc.Solve());
                Calc.equationUnsolved.Clear();
            }
            else
                Application.Exit();


        }

        private void importEquationsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                XmlReader xmlIn = XmlReader.Create(path, settings);


                if (xmlIn.ReadToDescendant("Equation"))
                {

                    int counter = 0;
                    // create one Product object for each Product node
                    do
                    {
                        Calc.equationUnsolved.Append (xmlIn["q"]);
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Equations Solved - Check View Hisotry");
                        Calc.Solve();
                        Calc.equationUnsolved.Clear();
                        counter++;
                    }
                    while (xmlIn.ReadToNextSibling("Equation"));
                }

                // close the XmlReader object
                xmlIn.Close();

            }
            
        }
    }


    public class Calculator
    {
        public StringBuilder equationUnsolved;
        ArrayList equations = new ArrayList();
        bool equationSolved = false;

        public Calculator()
        {
            equationUnsolved = new StringBuilder("");
        }

        public string Solve()
        {
            string equation = equationUnsolved.ToString();
            string answer;
            try
            {
                answer = new DataTable().Compute(equation, null).ToString();
                equations.Add(equation + "    ->  " + answer);
                equationSolved = true;
            }
            catch
            {
                return "Syntax Error";
            }
            return answer;
        }
        public string PrintHisotry()
        {
            StringBuilder history = new StringBuilder("");
            int i = 0;
            history.Append("HISTORY\n\n");
            foreach (string e in equations)
            {
                i++;
                history.Append(i + ".   " + e + "\n");
            }


            return history.ToString();
        }

        public bool checkSolved()
        {
            return equationSolved;
        }

        public void setCheckSolved()
        {
            equationSolved = false;
        }
    }

}





