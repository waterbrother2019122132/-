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
    public partial class Form1 : Form
    {
        int n = 0;
        Boyfriend[] bfs = new Boyfriend[100];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void toRightButton_Click(object sender, EventArgs e)
        {
            int n = leftListBox.SelectedIndices.Count;

            for (int i = 0; i < n; i++)
            {
                string str = leftListBox.SelectedItems[i].ToString();
                rightListBox.Items.Add(str);                                // 将内容添加到 right
            }

            // 删除
            for (int i = 0; i < n; i++)
            {
                int index = leftListBox.SelectedIndex;
                leftListBox.Items.RemoveAt(index);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("未知男友");
            // f2.Show();                               // 非模式
            DialogResult dr = f2.ShowDialog();          // 模式，返回值为枚举类型
            if (dr == DialogResult.OK)                  // 单击确定按钮
            {
                Boyfriend bf = f2.BF;
                bfs[n] = bf;
                n++;
                showLabel.Text = bf.show();
            }
            if (dr == DialogResult.Cancel)              // 单击取消按钮
            { showLabel.Text = "窗体 f2 的操作被取消！"; }
        }
    }
}
