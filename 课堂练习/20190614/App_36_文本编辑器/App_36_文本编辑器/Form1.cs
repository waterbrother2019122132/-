using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_36_文本编辑器
{
    public partial class Form1 : Form
    {
        int n = 1;
        RichTextBox[] richTextBoxes;
        
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Left = 0;
            richTextBox1.Top = 50;
            richTextBox1.Height = this.ClientRectangle.Height - 50;
            richTextBox1.Width = this.ClientRectangle.Width;
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "rtf文件(*.rtf)|*.rtf|txt文件(*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "打开文件";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] str = openFileDialog1.FileNames;
                    richTextBoxes = new RichTextBox[str.Length];
                    for(int i = 0; i < str.Length; i++)
                    {
                        richTextBoxes[i].Left = 0 + i * this.ClientRectangle.Width / str.Length;
                        richTextBoxes[i].Top = 50;
                        richTextBoxes[i].Height = this.ClientRectangle.Height - 50;
                        richTextBoxes[i].Width = this.ClientRectangle.Width/str.Length;
                        richTextBoxes[i].LoadFile(str[i], RichTextBoxStreamType.PlainText);
                    }
                    n = str.Length;
                }
                catch (Exception ex) { MessageBox.Show("打开文件出现错误：" + ex.ToString()); }
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "D:\\";
            saveFileDialog1.Filter = "rtf文件(*.rtf)|*.rtf|txt文件(*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "保存文件";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try { richTextBox1.SaveFile(saveFileDialog1.FileName); }
                catch (Exception ex) { MessageBox.Show("保存文件出现错误：" + ex.ToString()); }
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                字体ToolStripMenuItem.Enabled = true;
                颜色ToolStripMenuItem.Enabled = true;
                剪切XToolStripMenuItem.Enabled = true;
                复制CToolStripMenuItem.Enabled = true;
                字体ToolStripMenuItem1.Enabled = true;
                颜色ToolStripMenuItem1.Enabled = true;
                剪切ToolStripMenuItem.Enabled = true;
                复制ToolStripMenuItem.Enabled = true;
            }
            else
            {
                字体ToolStripMenuItem.Enabled = false;
                颜色ToolStripMenuItem.Enabled = false;
                剪切XToolStripMenuItem.Enabled = false;
                复制CToolStripMenuItem.Enabled = false;
                字体ToolStripMenuItem1.Enabled = false;
                颜色ToolStripMenuItem1.Enabled = false;
                剪切ToolStripMenuItem.Enabled = false;
                复制ToolStripMenuItem.Enabled = false;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        { if (fontDialog1.ShowDialog() == DialogResult.OK)
            { richTextBox1.SelectionFont = fontDialog1.Font; } }
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        { if (colorDialog1.ShowDialog() == DialogResult.OK)
            { richTextBox1.SelectionColor = colorDialog1.Color; } }
        private void 剪切XToolStripMenuItem_Click(object sender, EventArgs e)
        { richTextBox1.Cut(); }
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        { richTextBox1.Copy(); }
        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        { richTextBox1.Paste(); }

        // 联动部分

        private void toolStripButton1_Click(object sender, EventArgs e)
        { 打开OToolStripMenuItem_Click(null, null); }
        private void toolStripButton2_Click(object sender, EventArgs e)
        { 保存SToolStripMenuItem_Click(null, null); }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        { 剪切XToolStripMenuItem_Click(null, null); }
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        { 复制CToolStripMenuItem_Click(null, null); }
        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        { 粘贴PToolStripMenuItem_Click(null, null); }
        private void 字体ToolStripMenuItem1_Click(object sender, EventArgs e)
        { 字体ToolStripMenuItem_Click(null, null); }
        private void 颜色ToolStripMenuItem1_Click(object sender, EventArgs e)
        { 颜色ToolStripMenuItem_Click(null, null); }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                richTextBox1.Left = 0 + i * this.ClientRectangle.Width / n;
                richTextBox1.Top = 50;
                richTextBox1.Height = this.ClientRectangle.Height - 50;
                richTextBox1.Width = this.ClientRectangle.Width / n;
            }
        }
    }
}
