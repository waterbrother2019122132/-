using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_2_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // 单击“button1”后执行的操作
        {
            textBox1.Text = "Hello!"; //“textBox1”的文本显示为“Hello!”
            button1.BackColor = Color.DarkRed; //“button1”的按钮背景色变为“深红色”
        }
    }
}
