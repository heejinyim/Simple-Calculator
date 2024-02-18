using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public enum Operators { Add, Sub, Multi, Div }
    public partial class Calculator : Form
    {
        public double Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text += num;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                double num = double.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                {
                    Result += num;
                }
                if (Opt == Operators.Sub)
                {
                    Result -= num;
                }
                if (Opt == Operators.Multi)
                {
                    Result *= num;
                }
                if (Opt == Operators.Div)
                {
                    Result /= num;
                }

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if(optButton.Text == "+")
                Opt = Operators.Add;
            
            if(optButton.Text == "-") 
                Opt = Operators.Sub;

            if (optButton.Text == "*")
                Opt = Operators.Multi;

            if (optButton.Text == "/")
                Opt = Operators.Div;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;
            NumScreen.Text = "0";
        }
    }
} 