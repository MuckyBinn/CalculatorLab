using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxInput.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string userinput = textboxInput.Text;
            textboxInput.Text = userinput + "ผมอยากหัวแตกอ่ะม๊าพาไปหน่อยดิ";
        }
        string userinput ="";
        private void button8_Click(object sender, EventArgs e)

        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "1";
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userinput = textboxInput.Text;
            textboxInput.Text = userinput + "0";
        }
        string button16v2 ;
        string operation;
        private void button16_Click(object sender, EventArgs e)
        {
            button16v2 = textboxInput.Text;
            textboxInput.Text = string.Empty;
            operation = "+";


        }
        //Enter
        private void button12_Click(object sender, EventArgs e)
            
        {
            string num2 = textboxInput.Text;
            double Num1 = double.Parse(button16v2), Num2 = double.Parse(num2);

            if (operation == "+")
            {
                textboxInput.Text = (Num1 + Num2).ToString();
            }
            if (operation == "-")
            {
                textboxInput.Text = String.Format("{0}", Num1 - Num2);
            }
            if (operation == "*")
            {
                textboxInput.Text = (Num1 * Num2).ToString();
            }
            if (operation == "/")
            {
                textboxInput.Text = (Num1 / Num2).ToString();
            }


        }

        
        private void button14_Click(object sender, EventArgs e)
        {
            button16v2 = textboxInput.Text;
            textboxInput.Text = string.Empty;
            operation = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button16v2 = textboxInput.Text;
            textboxInput.Text = string.Empty;
            operation = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button16v2 = textboxInput.Text;
            textboxInput.Text = string.Empty;
            operation = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button16v2 = textboxInput.Text;
            textboxInput.Text = string.Empty;
            operation = ".";
        }
    }
}
