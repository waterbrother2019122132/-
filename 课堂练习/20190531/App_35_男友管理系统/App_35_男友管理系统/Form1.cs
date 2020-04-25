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
    public partial class Form1 : Form
    {
        static public int n = 0;
        int flag = 0;
        static public Boyfriend[] bfs = new Boyfriend[100];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            新建男友 f2 = new 新建男友();
            DialogResult dr2 = f2.ShowDialog();
            if (dr2 == DialogResult.OK)
            {
                Boyfriend bf = f2.BF;
                bfs[n] = bf;
                n++;
                MessageBox.Show("新建成功！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            删除男友 f3 = new 删除男友();
            DialogResult dr3 = f3.ShowDialog();
            if (dr3 == DialogResult.OK)
            {
                flag = 0;
                for (int i = 0; i < n; i++)
                {
                    if (bfs[i].Name == f3.STR)
                    {
                        bfs[i] = bfs[n-1];
                        flag = 1;
                        n--;
                        MessageBox.Show("删除成功！");
                        break;
                    }
                }
                if (flag == 0) { MessageBox.Show("未找到该男友，删除失败！"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boyfriend t = new Boyfriend("", DateTime.Now, 0);
            int j, k, index;
            for (j = 0; j < n - 1; j++)
            {
                index = j;
                for (k = j + 1; k < n; k++) if (bfs[k].DT > bfs[index].DT) index = k;
                t = bfs[index]; bfs[index] = bfs[j]; bfs[j] = t;
            }
            排序输出 f4 = new 排序输出();
            DialogResult dr4 = f4.ShowDialog();
        }
    }
}
