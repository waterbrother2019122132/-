using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H6_Common_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            { MessageBox.Show("请选择完成事件的时间！"); }
            else if (listBox1.SelectedItem == null)
            { MessageBox.Show("请选择完成的事件内容！"); }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            { MessageBox.Show("请选择一起完成事件的对象！"); }
            else
            {
                string str = "";
                str += comboBox1.SelectedItem.ToString();
                str += "我要";
                if (radioButton2.Checked == true)
                {
                    str += "和";
                    if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true) { str += "家人、男朋友、同学"; }
                    else if (checkBox1.Checked == true && checkBox2.Checked == true) { str += "家人、男朋友"; }
                    else if (checkBox1.Checked == true && checkBox3.Checked == true) { str += "家人、同学"; }
                    else if (checkBox2.Checked == true && checkBox3.Checked == true) { str += "男朋友、同学"; }
                    else if (checkBox1.Checked == true) { str += "家人"; }
                    else if (checkBox2.Checked == true) { str += "男朋友"; }
                    else { str += "同学"; }
                    str += "一起";
                }
                else { str += "独自一人"; }
                str += listBox1.SelectedItem.ToString();
                str += "！";
                textBox1.Text = str;
            }
        }
    }
}
