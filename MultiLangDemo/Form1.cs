using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiLangDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             Thread.CurrentThread.CurrentUICulture = new CultureInfo(comboBox1.SelectedItem.ToString());
            Thread.CurrentThread.CurrentCulture = new CultureInfo(comboBox1.SelectedItem.ToString());
            ResourceManager rm = new ResourceManager("MultiLangDemo.Resource", typeof(Form1).Assembly);
            label1.Text = rm.GetString("userid");
            label2.Text = rm.GetString("password");
            this.Text = rm.GetString("title");
            //button2.Text = rm.GetString("btReset");
            button1.Text = rm.GetString("btLogin");





        }
    }
}
