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
    public partial class 删除项目 : Form
    {
        int order;

        public 删除项目()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                order = int.Parse(textBox1.Text);
                if (order <= 0 || order > 生活记账簿.n)
                { this.DialogResult = DialogResult.Cancel; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入数据有误，请重试！");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        public int Order
        { get { return order; } }
    }
}
