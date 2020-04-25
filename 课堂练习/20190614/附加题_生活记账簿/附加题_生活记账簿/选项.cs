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
    public partial class 选项 : Form
    {
        int orderflag;

        public 选项()
        {
            InitializeComponent();
        }

        public int Orderflag
        { get { return orderflag; } }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton3.Checked == true) orderflag = 1;
                else orderflag = 2;
            }
            else
            {
                if (radioButton3.Checked == true) orderflag = 3;
                else orderflag = 4;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton3.Checked == true) orderflag = 1;
                else orderflag = 2;
            }
            else
            {
                if (radioButton3.Checked == true) orderflag = 3;
                else orderflag = 4;
            }
        }
    }
}
