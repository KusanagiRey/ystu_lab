using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string op;
        public string Number1;
        public bool trigerOp;
        public bool trigerDot;
        public Form1()
        {
            trigerOp = false;
            trigerDot = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ввод чисел
        {
            if (trigerOp)
            {
                trigerOp = false;
                textBox1.Text = "0";
            }

            Button But = (Button)sender;
            if(textBox1.Text == "0")
            {
                textBox1.Text = But.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + But.Text;
            }
            
        }

        private void button16_Click(object sender, EventArgs e)//выбор операции
        {
            Button But = (Button)sender;
            op = But.Text;
            Number1 = textBox1.Text;
            trigerOp = true;
            trigerDot = true;
        }

        private void button10_Click(object sender, EventArgs e)//равно
        {
            double n1, n2, result=0;
            n1 = Convert.ToDouble(Number1);
            n2 = Convert.ToDouble(textBox1.Text);

            if (op == "+")
            {
                result = n1 + n2;
            }
            if (op == "-")
            {
                result = n1 - n2;
            }
            if (op == "x")
            {
                result = n1 * n2;
            }
            if (op == "/")
                result = n1 / n2;
            {
                
            }
            trigerOp = true;
            textBox1.Text = Convert.ToString(result);
        }

        private void button17_Click(object sender, EventArgs e)//запятая
        {
            if (trigerDot)
            {
                textBox1.Text = textBox1.Text + ",";
                trigerDot = false;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
