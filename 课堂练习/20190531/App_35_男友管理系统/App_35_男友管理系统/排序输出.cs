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
    public partial class 排序输出 : Form
    {
        public 排序输出()
        {
            InitializeComponent();
            string str = "";
            for (int i = 0; i < Form1.n; i++)
            {
                str += "相识日期：" + Form1.bfs[i].DT.Year + "/" + Form1.bfs[i].DT.Month + "/" + Form1.bfs[i].DT.Day + "\t";
                str += "姓名：" + Form1.bfs[i].Name + "\t";
                str += "恋爱时长：" + Form1.bfs[i].Day + "\n";
            }
            richTextBox1.Text = str;
        }
    }
}
