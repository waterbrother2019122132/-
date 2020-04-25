using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_38_E7_File_2
{
    public partial class 添加收支 : Form
    {
        Item item;
        public 添加收支()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text;
            double money = double.Parse(textBox2.Text);
            DateTime dt = dateTimePicker1.Value;
            item = new Item(result, money, dt);
        }

        public Item Item
        { get { return item; } }
    }
}
