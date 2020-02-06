using System;
using System.Windows.Forms;
namespace Lab_0_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void number_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        double a = 0, b = 0, c = 0;
        char operation;
        private void operation_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            operation = (sender as Button).Text[0];
            textBox1.Clear();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void equally_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (operation)
            {
                case '+': c = a + b; break;
                case '-': c = a - b; break;
                case '/': c = a / b; break;
                case 'x': c = a * b; break;
            }
            textBox1.Text = c.ToString();
        }
        private void poin_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int counter = 0;
            if (String.IsNullOrEmpty(str))
            {
                textBox1.Text += '0';
                textBox1.Text += (sender as Button).Text;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ',')
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    textBox1.Text += (sender as Button).Text;
                }
            }
        }
    }
}
