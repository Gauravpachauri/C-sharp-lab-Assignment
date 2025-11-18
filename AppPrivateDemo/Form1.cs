using UtilityLibrary;  // Your class library namespace
using System;
using System.Windows.Forms;

namespace AppPrivateDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        
        private void button1_Click(object? sender, EventArgs e)
        {
            string input = textBox1.Text;
            string result = Utils.FormatText(input);
            label2.Text = result;
        }

        
        private void button2_Click(object? sender, EventArgs e)
        {
            string input = textBox1.Text;
            bool isNum = Utils.ValidateNumber(input);
            label2.Text = isNum ? "Valid Number" : "Not a Number";
        }

        
        private void label1_Click(object? sender, EventArgs e)
        {
        }
    }
}
