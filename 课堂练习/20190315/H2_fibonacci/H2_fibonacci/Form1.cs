using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2_fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputButton_Click(object sender, EventArgs e)     // 单击按钮时的操作
        {
            int[] fib = new int[10];                                    // 新建整型数组“fib”，含10个元素
            string text = "1, 1";                                       // 新建字符串“text”，初始内容为“1, 1”（斐波拉契数列的前两项）
            fib[0] = fib[1] = 1;                                        // 根据 C 学习的内容编写斐波拉契数列程序
            for (int i = 2; i < 10; i++)
                fib[i] = fib[i - 1] + fib[i - 2];
            for (int i = 2; i < 10; i++)
                text = text + ", " + fib[i].ToString();                 // 从第三项开始在字符串“text”后添加“, ”和对应项的数字
            numberBox.Text = text;                                      // 将“numberBox”（输出框）的内容更改为“text”的内容
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tipText_Click(object sender, EventArgs e)
        {

        }
    }
}
