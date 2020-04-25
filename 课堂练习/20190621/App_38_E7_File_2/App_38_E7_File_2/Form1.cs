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

namespace App_38_E7_File_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示零用钱明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\money.txt";
                StreamReader reader = new StreamReader(path, System.Text.Encoding.UTF8);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                string line = reader.ReadLine();
                string text = "";
                listBox1.Items.Clear();
                while (line != null)
                {
                    text = line;
                    listBox1.Items.Add(text);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到 D:\\money.txt！", "读取文件出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 存取零用钱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加收支 f1 = new 添加收支();
            DialogResult dr1 = f1.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                Item item = f1.Item;
                string str = item.Result + " " + item.Money + " " + item.DT.Year + "/" + item.DT.Month + "/" + item.DT.Day;
                listBox1.Items.Add(str);

                string path = @"D:\money.txt";
                StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                for (int i = 0; i < listBox1.Items.Count; i++)
                    writer.WriteLine(listBox1.Items[i].ToString());
                writer.Close();
            }
        }
    }
}
