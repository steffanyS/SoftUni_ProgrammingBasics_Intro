using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(textBox1.Text);
            var number2 = int.Parse(textBox2.Text);
            var result = number1 + number2;
            textBox3.Text = result.ToString();

        }
    }
}
