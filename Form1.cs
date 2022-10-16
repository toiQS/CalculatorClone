using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorClone
{
    public partial class Form1 : Form
    {
        double A;
        string Operation = "";
        bool g = false;
        bool lock1 = false;
        bool lock2 = false;
        double origin;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void n1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "1";
            }
            else
            {
                label3.Text = label3.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "2";
            }
            else
            {
                label3.Text = label3.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "3";
            }
            else
            {
                label3.Text = label3.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "4";
            }
            else
            {
                label3.Text = label3.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "5";
            }
            else
            {
                label3.Text = label3.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "6";
            }
            else
            {
                label3.Text = label3.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "7";
            }
            else
            {
                label3.Text = label3.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "8";
            }
            else
            {
                label3.Text = label3.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0" && label3.Text != null)
            {
                label3.Text = "9";
            }
            else
            {
                label3.Text = label3.Text + "9";
            }
        }
        private void n0_Click(object sender, EventArgs e)
        {
            if (label3.Text != "0" && label3.Text != null)
            {
                label3.Text = label3.Text + "0";
            }
        }*/
        private void MyButtonClick(object sender, EventArgs e)
        {
            lock2 = false;
            lock1 = false;
            if (Operation == "")
            {
                label2.Text = "0";
            }
            if (g == true)
            {
                label3.Text = "0";
                g = false;
            }
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "C":
                    label2.Text = "0";
                    label3.Text = "0";
                    Operation = "";
                    break;
                case "CE":
                    label3.Text = "0";
                    break;
                case "+/-":
                    if (label3.Text.Contains('-') == true)
                    {
                        label3.Text = label3.Text.Remove(0, 1);
                    }
                    else
                    {
                        label3.Text = "-" + label3.Text;
                    }
                    break;
                case ".":
                    if (label3.Text.Contains('.') == false && label3.Text != null)
                    {
                        label3.Text = label3.Text + ".";
                    }
                    break;
                case "0":
                    if (label3.Text != "0" && label3.Text != null)
                    {
                        label3.Text = label3.Text + "0";
                    }
                    break;
                case "1":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "1";
                    }
                    else
                    {
                        label3.Text = label3.Text + "1";
                    }
                    break;
                case "2":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "2";
                    }
                    else
                    {
                        label3.Text = label3.Text + "2";
                    }
                    break;
                case "3":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "3";
                    }
                    else
                    {
                        label3.Text = label3.Text + "3";
                    }
                    break;
                case "4":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "4";
                    }
                    else
                    {
                        label3.Text = label3.Text + "4";
                    }
                    break;
                case "5":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "5";
                    }
                    else
                    {
                        label3.Text = label3.Text + "5";
                    }
                    break;
                case "6":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "6";
                    }
                    else
                    {
                        label3.Text = label3.Text + "6";
                    }
                    break;
                case "7":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "7";
                    }
                    else
                    {
                        label3.Text = label3.Text + "7";
                    }
                    break;
                case "8":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "8";
                    }
                    else
                    {
                        label3.Text = label3.Text + "8";
                    }
                    break;
                case "9":
                    if (label3.Text == "0" && label3.Text != null)
                    {
                        label3.Text = "9";
                    }
                    else
                    {
                        label3.Text = label3.Text + "9";
                    }
                    break;
            }
        }
        /*private void bad_Click(object sender, EventArgs e)
        {

            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " +";
                label3.Text = "0";
                Operation = "+";
            }
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " -";
                label3.Text = "0";
                Operation = "-";
            }
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " *";
                label3.Text = "0";
                Operation = "*";
            }
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            if (Operation == "")
            {
                A = Convert.ToDouble(label3.Text);
                label2.Text = label3.Text + " /";
                label3.Text = "0";
                Operation = "/";
            }
        }*/
        private void basic_math2(object sender, EventArgs e)
        {
            double Result2;
            if (lock2 == false)
            {
                origin = Convert.ToDouble(label3.Text);
                label2.Text = Convert.ToString(origin);
                lock2 = true;
            }
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "sqrt":
                    A = Convert.ToDouble(label3.Text);
                    //Result2 = Math.Sqrt(A);
                    //label2.Text = "sqrt(" + label2.Text + ")";
                    //label3.Text = Convert.ToString(Result2);

                    if(A < 0)
                    {
                        label2.Text = "sqrt(-" + label2.Text + ")";
                        label3.Text = "Invalid Input";
                    }
                    else
                    {
                        Result2 = Math.Sqrt(A);
                        label2.Text = "sqrt(" + label2.Text + ")";
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                    }
                    
                    break;
                case "pow(2)":
                    A = Convert.ToDouble(label3.Text);
                    Result2 = Math.Pow(A, 2);
                    label2.Text = "pow(" + label2.Text + ")2";
                    label3.Text = Convert.ToString(Result2);
                    A = Result2;
                    break;
                case "1/x":
                    A = Convert.ToDouble(label3.Text);
                    Result2 = 1 / A;
                    label2.Text = "1/(" + label2.Text + ")";
                    label3.Text = Convert.ToString(Result2);
                    A = Result2;
                    break;
                case "%":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        Result2 = A / 100;
                        label2.Text = Convert.ToString(Result2);
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                    }
                    else
                    {
                        double B;
                        double Result;
                        B = Convert.ToDouble(label3.Text) / 100;

                        if (Operation == "+")
                        {
                            Result = (A + B);
                            label2.Text = label2.Text + " + " + B + " =";
                            label3.Text = Convert.ToString(Result);
                            A = Result;
                        }
                        if (Operation == "-")
                        {
                            Result = (A - B);
                            label2.Text = label2.Text + " - " + B + " =";
                            label3.Text = Convert.ToString(Result);
                            A = Result;
                        }
                        if (Operation == "*")
                        {
                            Result = (A * B);
                            label2.Text = label2.Text + " * " + B + " =";
                            label3.Text = Convert.ToString(Result);
                            A = Result;
                        }
                        if (Operation == "/")
                        {
                            if (B == 0)
                            {
                                label3.Text = "Cannot divide by zero";

                            }
                            else
                            {
                                Result = (A / B);
                                label2.Text = label2.Text + " / " + B + " =";
                                label3.Text = Convert.ToString(Result);
                                A = Result;
                            }
                        }
                        if (Operation == "")
                        {
                            label2.Text = label3.Text + " =";
                        }
                        Operation = "";
                        g = true;
                        lock1 = true;
                    }
                    break;
            }
            g = true;
            lock1 = true;
        }

        private void basic_math(object sender, EventArgs e)
        {
            lock2 = false;
            double Result2;
            int count = 2;
            lock1 = false;
            string buttonText = ((Button)sender).Text;
            switch (buttonText)
            {
                case "sqrt":
                    A = Convert.ToDouble(label3.Text);
                    //Result2=Math.Sqrt(A);
                    //label2.Text = label3.Text;
                    //label2.Text = "sqrt(" + label2.Text + ")"+count;
                    //label3.Text = Convert.ToString(Result2);

                    if (A >= 0)
                    {
                        Result2 = Math.Sqrt(A);
                        label2.Text = label3.Text;
                        label2.Text = $"Sqrt({label2.Text}){count}";
                        label3.Text = Convert.ToString(Result2);
                        A = Result2;
                    }
                    else
                    {
                        label2.Text = label3.Text;
                        label2.Text = $"Sqrt({label2.Text}){count}";
                        label3.Text = "Invalid Input";

                    }
                    count = 2;
                    break;
                case "+":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " +";
                        label3.Text = "0";
                        Operation = "+";
                    }
                    break;
                case "-":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " -";
                        label3.Text = "0";
                        Operation = "-";
                    }
                    break;
                case "*":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " *";
                        label3.Text = "0";
                        Operation = "*";
                    }
                    break;
                case "/":
                    if (Operation == "")
                    {
                        A = Convert.ToDouble(label3.Text);
                        label2.Text = label3.Text + " /";
                        label3.Text = "0";
                        Operation = "/";
                    }
                    break;
            }
        }

        private void bequ_Click(object sender, EventArgs e)
        {
            double B;
            double Result;
            B = Convert.ToDouble(label3.Text);

            if (Operation == "+")
            {
                Result = (A + B);
                label2.Text = label2.Text + " " + B + " =";
                label3.Text = Convert.ToString(Result);
                A = Result;
            }
            if (Operation == "-")
            {
                Result = (A - B);
                label2.Text = label2.Text + " " + B + " =";
                label3.Text = Convert.ToString(Result);
                A = Result;
            }
            if (Operation == "*")
            {
                Result = (A * B);
                label2.Text = label2.Text + " " + B + " =";
                label3.Text = Convert.ToString(Result);
                A = Result;
            }
            if (Operation == "/")
            {
                if (B == 0)
                {
                    label3.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (A / B);
                    label2.Text = label2.Text + " " + B + " =";
                    label3.Text = Convert.ToString(Result);
                    A = Result;
                }
            }
            if (Operation == "")
            {
                label2.Text = label3.Text + " =";
            }
            Operation = "";
            g = true;
            lock1 = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (lock1 == false)
            {
                if (label3.Text.Length > 1)
                {
                    string n = label3.Text.Remove(label3.Text.Length - 1);
                    label3.Text = n;
                }
                else
                {
                    label3.Text = "0";
                }
            }
        }
    }
}
