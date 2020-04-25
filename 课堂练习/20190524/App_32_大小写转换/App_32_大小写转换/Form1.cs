using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_32_大小写转换
{
    public partial class textForm : Form
    {
        string str;
        bool isUpper;
        
        public textForm()
        {
            InitializeComponent();
            str = "";
            isUpper = false;
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                if (letterCheckBox.Checked) str += c;
            }
            else if (c >= '0' && c <= '9')
            {
                if (numCheckBox.Checked) str += c;
            }
            else
                if (otherCheckBox.Checked) str += c;
        }

        private void inputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            inputTextBox.Text = str;
            inputTextBox.Select(str.Length, 0);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (isUpper) outputTextBox.Text = str.ToUpper();
            else outputTextBox.Text = str.ToLower();
        }

        private void bigtosmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smalltobigRadioButton.Checked == true) isUpper = true;
            else isUpper = false;
        }
    }
}
