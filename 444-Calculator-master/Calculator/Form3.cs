using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Calculator
{
    public partial class Form3 : Form
    {
        Form myForm1;
        StringBuilder resultModify;
        ComplexCalculator complexCalc; 


        public Form3(Form form1)
        {
            InitializeComponent();
            myForm1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            complexCalc = new ComplexCalculator();
            this.MaximumSize = new System.Drawing.Size(401, 692);
            this.MinimumSize = new System.Drawing.Size(401, 692);

        }

        private void basicCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            myForm1.Visible = true;
        }

        private void Form3_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            myForm1.Close();
            Application.Exit();
        }

        private void complexSolveButton_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = System.Drawing.Color.Gray;
        }

        private void complexSolveButton_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = System.Drawing.Color.LightGray;
        }
        //Changed to clear  button instead
        private void complexSolveButton_Click(object sender, EventArgs e)
        {
            complexResultBox.Clear();
            eq1button1.Text = "";
            eq1button2.Text = "";
            eq2button1.Text = "";
            eq2button2.Text = "";

            for (int i = 0; i < 4; i++)
            {
                complexCalc.complexNums[i] = "";
            }

        }

        private void complexMagButton_Click(object sender, EventArgs e)
        {
            eq2button1.Text = "";
            eq2button2.Text = "";

            complexCalc.complexNums[0] = eq1button1.Text;
            complexCalc.complexNums[1] = eq1button2.Text;

            complexResultBox.Clear();

            resultModify = new StringBuilder();
            resultModify.Append(complexCalc.ComplexMag());

            complexResultBox.AppendText(resultModify.ToString());
            resultModify.Clear();
        }

        private void complexDivButton_Click(object sender, EventArgs e)
        {
            complexCalc.complexNums[0] = eq1button1.Text;
            complexCalc.complexNums[1] = eq1button2.Text;
            complexCalc.complexNums[2] = eq2button1.Text;
            complexCalc.complexNums[3] = eq2button2.Text;

            complexResultBox.Clear();

            resultModify = new StringBuilder();
            resultModify.Append(complexCalc.ComplexDiv());

            complexResultBox.AppendText(resultModify.ToString());
            resultModify.Clear();
        }

        private void complexSubButton_Click(object sender, EventArgs e)
        {
            eq2button1.Text = "";
            eq2button2.Text = "";

            complexCalc.complexNums[0] = eq1button1.Text;
            complexCalc.complexNums[1] = eq1button2.Text;

            complexResultBox.Clear();

            resultModify = new StringBuilder();
            resultModify.Append(complexCalc.ComplexAngle());

            complexResultBox.AppendText(resultModify.ToString());
            resultModify.Clear();
        }

        private void complexAddButton_Click(object sender, EventArgs e)
        {

            complexCalc.complexNums[0] = eq1button1.Text;
            complexCalc.complexNums[1] = eq1button2.Text;
            complexCalc.complexNums[2] = eq2button1.Text;
            complexCalc.complexNums[3] = eq2button2.Text;

            complexResultBox.Clear();

            resultModify = new StringBuilder();
            resultModify.Append(complexCalc.ComplexAdd());

            complexResultBox.AppendText(resultModify.ToString());      
            resultModify.Clear();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

    public class ComplexCalculator 
    {
        public string[] complexNums;
        ArrayList complexSolved = new ArrayList();
        Complex num1;
        Complex num2;
        
        

        public ComplexCalculator()
        {
            complexNums = new string[4];
        }



        public string ComplexAdd()
        {
            try
            {
                num1 = new Complex(Convert.ToDouble(complexNums[0]), Convert.ToDouble(complexNums[1]));
                num2 = new Complex(Convert.ToDouble(complexNums[2]), Convert.ToDouble(complexNums[3]));

                return String.Format(new ComplexFormatter(), "{0:I0}", (num1)) + " + " +
                       String.Format(new ComplexFormatter(), "{0:I0}", (num2)) + " =\t\t\t" +
                       String.Format(new ComplexFormatter(), "{0:I0}", (Complex.Add(num1, num2)));

            }
            catch { return "Syntax Error"; }
            }

        public string ComplexDiv()
        {
            try
            {
                num1 = new Complex(Convert.ToDouble(complexNums[0]), Convert.ToDouble(complexNums[1]));
                num2 = new Complex(Convert.ToDouble(complexNums[2]), Convert.ToDouble(complexNums[3]));

                return String.Format(new ComplexFormatter(), "{0:I0}", (num1)) + " / " +
                       String.Format(new ComplexFormatter(), "{0:I0}", (num2)) + " =\t\t\t" +
                       String.Format(new ComplexFormatter(), "{0:I0}", (Complex.Divide(num1, num2)));

            }
            catch { return "Syntax Error"; }
        }

        public string ComplexAngle()
        {
            try
            {
                num1 = new Complex(Convert.ToDouble(complexNums[0]), Convert.ToDouble(complexNums[1]));


                return String.Format(new ComplexFormatter(), "{0:I0}", (num1)) + " = " +
                       num1.Phase.ToString();

            }
            catch { return "Syntax Error - Insert query into column 1"; }
        }

        public string ComplexMag()
        {
            try
            {
                num1 = new Complex(Convert.ToDouble(complexNums[0]), Convert.ToDouble(complexNums[1]));

                
                return "|"+ String.Format(new ComplexFormatter(), "{0:I0}", (num1))+"|" + " = " +
                       num1.Magnitude.ToString();

            }
            catch { return "Syntax Error - Insert query into column 1"; }
        }


    }














}