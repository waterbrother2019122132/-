using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_34_ListBox_等
{
    public partial class Form2 : Form
    {
        Boyfriend bf;                       // 封装所有返回到 Form1 中的值
        
        public Form2()
        {
            InitializeComponent();
            bf = null;
        }

        public Form2(string name)           // 传递 Form1 中的 name
        {
            InitializeComponent();
            nameTextBox.Text = name;
        }

        public Boyfriend BF
        { get { return bf; } }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            DateTime dt = meetDTP.Value;
            bf = new Boyfriend(name, dt);
        }
    }
}
