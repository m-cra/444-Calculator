using System;
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
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculator Calc;
        string dataType = "";
        TextBox inputText = new TextBox();

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
            MessageBox.Show("Version 1.6\nThis Calculator was created by Michael, James and Zach.\n5/17/2017");
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Calc.PrintHisotry());
        }

        //Random Toolstrip button event
        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
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
                        Calc.Solve();
                        Calc.equationUnsolved.Clear();
                        counter++;
                    }
                    while (xmlIn.ReadToNextSibling("Equation"));
                    MessageBox.Show("Equations Solved - Check View Hisotry");
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
            double ans = 0.0;
            string answer;
            

            StringBuilder s = new StringBuilder();
            int i = 0;
            try
            {
                string[] equation_sub = Regex.Split(equation, @"(\(|\)|(?<!e)-|(?<!e)\+|\*|\%|\=|\!|\^|\√\(|/|\s+)");
                List<string> stringList = equation_sub.ToList();
                for(int f = 0; f < stringList.Count; f++)
                {
                    //MessageBox.Show(stringList.ElementAt(f));
                    if(stringList.ElementAt(f).Contains('-'))
                    {
                       // MessageBox.Show("IAMHERE");
                        stringList.RemoveAt(f);
                        int negNum = Convert.ToInt32(stringList.ElementAt(f)) * -1;
                        stringList.Insert(f, negNum.ToString());
                        stringList.RemoveAt(f+1);
                    }
                }           
                stringList.Remove("");
                stringList.Remove("");
                equation_sub = stringList.Select(list => list.ToString()).ToArray();

                foreach (string a in equation_sub)
                {
                    s.Append(i + "  " + a + '\n');
                    i++;
                }

                //Use this to debugg what characters are in equation_sub string array           
                //MessageBox.Show(s.ToString());
                //MessageBox.Show(equation_sub.Length.ToString());
                if (equation_sub.Length == 1)
                {
                    answer = equation;
                }
                else if (equation_sub[1].Contains("!"))
                {
                    if (equation_sub.Length == 2)
                    {
                        bool negNum = false;
                        int number = Convert.ToInt32(equation_sub[0]);
                        if(number < 0 )
                        {
                            negNum = true;
                            number = number * -1;
                        }

                        double result = 1;
                        while (number != 1)
                        {
                            result = result * number;
                            number = number - 1;
                        }
                        if(negNum)
                        {
                            result = result * -1;
                        }
                        answer = result.ToString();

                    }
                    else
                    {
                        if (equation_sub[0] != equation_sub[3])
                        {
                            answer = "True";
                        }
                        else
                        {
                            answer = "False";
                        }
                    }
                }
                else if (equation_sub[1].Contains('='))
                {
                    if (equation_sub[0] == equation_sub[2])
                    {
                        answer = "True";
                    }
                    else
                    {
                        answer = "False";
                    }
                }
                else if (equation_sub[1].Contains('^'))
                {
                    double x = Convert.ToDouble(equation_sub[2]);
                    if (equation_sub[0].Contains('e'))
                    {
                        if (equation_sub.Length > 4)
                        {
                            ans = (Math.Exp(x) * Math.Cos(x)) + 1;
                        }
                        else
                        {
                            ans = Math.Exp(Convert.ToDouble(x));
                        }
                    }
                    else
                    {
                        if (equation_sub.Length > 4)
                        {
                            ans = Math.Pow(Convert.ToDouble(equation_sub[0]), (Convert.ToDouble(equation_sub[2]) / Convert.ToDouble(equation_sub[4])));
                        }
                        else
                        {
                            ans = Math.Pow(Convert.ToDouble(equation_sub[0]), x);
                        }
                       
                    }

                    answer = ans.ToString();
                }
                else if (equation_sub[0].Contains("√(") && equation_sub[3].Contains("^"))
                {
                    ans = Math.Sqrt(Convert.ToDouble(equation_sub[1]));
                    ans = Math.Pow(ans, Convert.ToDouble(equation_sub[4]));
                    answer = ans.ToString();
                }
                else if (equation_sub[1].Contains("√("))
                {
                    ans = Math.Sqrt(Convert.ToDouble(equation_sub[2]));
                    answer = ans.ToString();
                }
                else if (equation_sub[1].Contains('%'))
                {
                    Decimal num1 = Convert.ToDecimal(equation_sub[0]);
                    Decimal num2 = Convert.ToDecimal(equation_sub[2]);
                    if (num1 < 0)
                    {
                        num2 = num2 * -1;
                    }
                    if(num2 < 0)
                    {
                        num1 = num1 * -1;
                    }
                    double intAns = (double)num1 % (double)num2;
                    answer = intAns.ToString();
                }
                else if (equation_sub[1].Contains('/'))
                {
                    Decimal doubleAns = 0M;
                    if (equation_sub.Length > 4)
                    {
                        if (equation_sub[4].Contains('w'))
                        {
                            Decimal result = Convert.ToDecimal(equation_sub[0]) / Convert.ToDecimal(equation_sub[2]);
                            doubleAns = Math.Truncate(result);
                        }
                        answer = doubleAns.ToString();
                    }
                    else
                    {
                        answer = new DataTable().Compute(equation, null).ToString();
                    }                 
                }
                else if (equation_sub[0].Contains('l'))
                {
                    if(equation_sub[0].Contains("ln"))
                    {
                        ans = Math.Log(Convert.ToDouble(equation_sub[2]));
                    }
                    else
                    {
                        ans = Math.Log10(Convert.ToDouble(equation_sub[2]));
                    }
                    answer = ans.ToString();
                }
                else
                {
                    answer = new DataTable().Compute(equation, null).ToString();                
                }
                //MessageBox.Show("Before rounding " +answer);
                //MessageBox.Show("After rounding" + Math.Round(Convert.ToDouble(answer), 10, MidpointRounding.AwayFromZero).ToString());


                if(answer.Where(x => Char.IsDigit(x)).Any())
                {
                    answer = Math.Round(Convert.ToDouble(answer), 12, MidpointRounding.AwayFromZero).ToString();
                }
                
                if (answer.Length >12)
                {
                    int cutoff = answer.Length - 12;
                    answer = answer.Remove(answer.Length - cutoff);
                }
                equations.Add(equation + "     ->  " + answer);
                equationSolved = true;
            }
            catch (ArithmeticException a)
            {
                //MessageBox.Show(a.ToString());
                return "Arithmetic Error";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                equations.Add(equation + "\t->  " + "Syntax Error");
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

        public string Random()
        {

            return "";
        }

        public string setEquationUnsolved(string s)
        {
            equationUnsolved = new StringBuilder(s);
            string ans = Solve();
            return ans;
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





