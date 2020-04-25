using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 附加题_生活记账簿
{
    public partial class 新建收支记录 : Form
    {
        Money m;
        int right = 0;
        
        public 新建收支记录()
        {
            InitializeComponent();
            comboBox1.Visible = true;
            comboBox2.Visible = false;
            m = null;
        }

        public Money MONEY
        { get { return m; } }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
            }
            else
            {
                comboBox1.Visible = false;
                comboBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                string name = textBox2.Text;
                string kind = "";
                int flag = 1;
                if (radioButton2.Checked == true)
                {
                    num = -num;
                    flag = -1;
                    kind = comboBox2.SelectedItem.ToString();
                }
                else { kind = comboBox1.SelectedItem.ToString(); }
                DateTime dt = dateTimePicker1.Value;
                m = new Money(name, num, kind, dt, flag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入的数据有误，请重试！");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
