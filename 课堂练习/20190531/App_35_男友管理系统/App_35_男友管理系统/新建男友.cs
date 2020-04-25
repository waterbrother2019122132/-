using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_35_男友管理系统
{
    public partial class 新建男友 : Form
    {
        Boyfriend bf;

        public 新建男友()
        {
            InitializeComponent();
            bf = null;
        }

        public Boyfriend BF
        { get { return bf; } }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime dt = meetDTP.Value;
            string daystr = textBox2.Text;
            int day = int.Parse(daystr);
            bf = new Boyfriend(name, dt, day);
        }
    }
}
