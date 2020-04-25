using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 附加题_生活记账簿
{
    public partial class 查看收支记录 : Form
    {
        int orderflag;

        public 查看收支记录()
        {
            InitializeComponent();
            orderflag = 1;
            this.ShowText();
        }

        public void ShowText()
        {
            double outmoney = 0;
            double inmoney = 0;

            richTextBox1.Text = "";

            for (int i = 0; i < 生活记账簿.n; i++)
            {
                if (生活记账簿.ms[i].Flag == -1) outmoney -= 生活记账簿.ms[i].Num;
                else inmoney += 生活记账簿.ms[i].Num;
            }
            label2.Text = "总收入：" + inmoney + "     总支出：" + outmoney + "     净收入：" + (inmoney - outmoney);

            if (orderflag == 1) this.OrderTimeDown();
            else if (orderflag == 2) this.OrderTimeUp();
            else if (orderflag == 3) this.OrderNumDown();
            else this.OrderNumUp();

            // 逐个输出
            for (int i = 0; i < 生活记账簿.n; i++)
            {
                richTextBox1.Text = richTextBox1.Text + "(" + (i + 1) + ")\t" + 生活记账簿.ms[i].DT.Year + "/" + 生活记账簿.ms[i].DT.Month + "/" + 生活记账簿.ms[i].DT.Day + "\t"
                    + 生活记账簿.ms[i].Kind + "\t" + 生活记账簿.ms[i].Num + "\t" + 生活记账簿.ms[i].Name + "\n";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            删除项目 f3 = new 删除项目();
            DialogResult dr3 = f3.ShowDialog();
            if (dr3 == DialogResult.OK)
            {
                生活记账簿.ms[f3.Order-1] = 生活记账簿.ms[生活记账簿.n-1];
                生活记账簿.ms[生活记账簿.n-1] = null;
                生活记账簿.n--;
                this.ShowText();
                MessageBox.Show("删除成功！");
            }
        }

        public void OrderTimeUp()
        {
            Money t = new Money("", 0, "", DateTime.Now, 1);
            int j, k, index;
            for (j = 0; j < 生活记账簿.n - 1; j++)
            {
                index = j;
                for (k = j + 1; k < 生活记账簿.n; k++) if (生活记账簿.ms[k].DT > 生活记账簿.ms[index].DT) index = k;
                t = 生活记账簿.ms[index]; 生活记账簿.ms[index] = 生活记账簿.ms[j]; 生活记账簿.ms[j] = t;
            }
        }

        public void OrderTimeDown()
        {
            Money t = new Money("", 0, "", DateTime.Now, 1);
            int j, k, index;
            for (j = 0; j < 生活记账簿.n - 1; j++)
            {
                index = j;
                for (k = j + 1; k < 生活记账簿.n; k++) if (生活记账簿.ms[k].DT < 生活记账簿.ms[index].DT) index = k;
                t = 生活记账簿.ms[index]; 生活记账簿.ms[index] = 生活记账簿.ms[j]; 生活记账簿.ms[j] = t;
            }
        }

        public void OrderNumUp()
        {
            Money t = new Money("", 0, "", DateTime.Now, 1);
            int j, k, index;
            for (j = 0; j < 生活记账簿.n - 1; j++)
            {
                index = j;
                for (k = j + 1; k < 生活记账簿.n; k++) if (生活记账簿.ms[k].Num > 生活记账簿.ms[index].Num) index = k;
                t = 生活记账簿.ms[index]; 生活记账簿.ms[index] = 生活记账簿.ms[j]; 生活记账簿.ms[j] = t;
            }
        }

        public void OrderNumDown()
        {
            Money t = new Money("", 0, "", DateTime.Now, 1);
            int j, k, index;
            for (j = 0; j < 生活记账簿.n - 1; j++)
            {
                index = j;
                for (k = j + 1; k < 生活记账簿.n; k++) if (生活记账簿.ms[k].Num < 生活记账簿.ms[index].Num) index = k;
                t = 生活记账簿.ms[index]; 生活记账簿.ms[index] = 生活记账簿.ms[j]; 生活记账簿.ms[j] = t;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            选项 f4 = new 选项();
            DialogResult dr4 = f4.ShowDialog();
            if (dr4 == DialogResult.OK)
            {
                orderflag = f4.Orderflag;
                this.ShowText();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "保存文件";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("文件已成功导出！");
                }
                catch (Exception ex) { MessageBox.Show("保存文件出现错误：" + ex.ToString()); }
            }
        }
    }
}
