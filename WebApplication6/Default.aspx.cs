using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class _Default : Page
    {

        static int firstNumber;
        static int secondNumber;
        static int answer;
        static float divideAnswer;
        static char sign;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "7";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "7";
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {

            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "0";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "0";
            }
        }

        protected void ButtonEight_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "8";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "8";
            }
        }

        protected void ButtonNine_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "9";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "9";
            }

        }

        protected void ButtonFour_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "4";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "4";
            }
        }

        protected void ButtonFive_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "5";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "5";
            }
        }

        protected void ButtonSix_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "6";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "6";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "1";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "1";
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "2";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "2";
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if ((TextBoxScreen.Text == "+") || (TextBoxScreen.Text == "-") || (TextBoxScreen.Text == "X") || (TextBoxScreen.Text == "/"))
            {
                TextBoxScreen.Text = "";
                TextBoxScreen.Text = TextBoxScreen.Text + "3";
            }
            else
            {
                TextBoxScreen.Text = TextBoxScreen.Text + "3";
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text != "")
            {
                firstNumber = int.Parse(TextBoxScreen.Text);
                sign = '+';
                TextBoxScreen.Text = "+";
            }
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text != "")
            {
                secondNumber = int.Parse(TextBoxScreen.Text);

                if (sign == '+')
                {
                    answer = firstNumber + secondNumber;
                    TextBoxScreen.Text = answer.ToString();
                } else if (sign == '-')
                {
                    answer = firstNumber + secondNumber;
                    TextBoxScreen.Text = answer.ToString();
                } else if (sign == 'X')
                {
                    answer = firstNumber * secondNumber;
                    TextBoxScreen.Text = answer.ToString();
                } else if (sign == '/')
                {
                    if (secondNumber != 0)
                    {
                        divideAnswer = (float)firstNumber / (float)secondNumber;
                        TextBoxScreen.Text = divideAnswer.ToString();
                    }
                    else
                    {
                        TextBoxScreen.Text = "Cannot Divide By Zero";
                    }
                }
            }
        }

        protected void ButtonSubtract_Click(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text != "")
            {
                firstNumber = int.Parse(TextBoxScreen.Text);
                sign = '-';
                TextBoxScreen.Text = "-";
            }
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text != "")
            {
                firstNumber = int.Parse(TextBoxScreen.Text);
                sign = 'X';
                TextBoxScreen.Text = "X";
            }
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text != "")
            {
                firstNumber = int.Parse(TextBoxScreen.Text);
                sign = '/';
                TextBoxScreen.Text = "/";
            }
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            TextBoxScreen.Text = "";
        }
    }
}