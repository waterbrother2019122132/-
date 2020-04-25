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
    public partial class 生活记账簿 : Form
    {
        static public int n = 0;
        static public Money[] ms = new Money[1000];
        
        public 生活记账簿()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            新建收支记录 f1 = new 新建收支记录();
            DialogResult dr1 = f1.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                Money money = f1.MONEY;
                ms[n] = money;
                n++;
                MessageBox.Show("保存成功！");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            查看收支记录 f2 = new 查看收支记录();
            DialogResult dr2 = f2.ShowDialog();
        }
    }
}
