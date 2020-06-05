using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F', '-' };
        bool isNormalSymbols = false;
        int counter = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int comboBox1SelectedItem = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int comboBox2SelectedItem = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            string str = Convert.ToString(textBox1.Text);
            var hash = new HashSet<char>(symbols);
            for (int i = 0; i < str.Length; i++)
            {
                if (hash.Contains(str[i]))
                {
                    counter++;
                }
                if (str[i] == '-' && i != 0)
                {
                    break;
                }
            }
            if (counter == str.Length) 
            {
                isNormalSymbols = true;
            }
            if (isNormalSymbols)
            {
                try
                { 
                    label4.Text = Convert.ToString(Convert.ToInt32(str, comboBox1SelectedItem), comboBox2SelectedItem);
                }
                catch { }
            }
            else
            {
                label4.Text = "Невірно введені данні";
            }         
        }
    }
}
