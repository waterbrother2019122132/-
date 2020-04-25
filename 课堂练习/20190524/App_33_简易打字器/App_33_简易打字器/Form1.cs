using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_33_简易打字器
{
    public partial class Form1 : Form
    {
        // 窗体
        public Form1()
        {
            InitializeComponent();
        }

        // 重载：设置字体
        private void SetFont(String fontname)
        {
            Font ft;
            inputTextBox.Text = mainRichTextBox.SelectionStart.ToString();
            int start = mainRichTextBox.SelectionStart;
            int end = mainRichTextBox.SelectionStart + mainRichTextBox.SelectionLength - 1;

            for (int i = start; i <= end; i++)
            {
                mainRichTextBox.Select(i, 1);
                ft = mainRichTextBox.SelectionFont;
                ft = new Font(fontname, ft.Size, ft.Style);
                mainRichTextBox.SelectionFont = ft;
            }
            mainRichTextBox.Select(start, end - start + 1);
            mainRichTextBox.Focus();
        }

        // 重载：设置字号
        private void SetFont(int fontsize)
        {
            Font ft;
            inputTextBox.Text = mainRichTextBox.SelectionStart.ToString();
            int start = mainRichTextBox.SelectionStart;
            int end = mainRichTextBox.SelectionStart + mainRichTextBox.SelectionLength - 1;

            for (int i = start; i <= end; i++)
            {
                mainRichTextBox.Select(i, 1);
                ft = mainRichTextBox.SelectionFont;
                ft = new Font(ft.Name, fontsize, ft.Style);
                mainRichTextBox.SelectionFont = ft;
            }
            mainRichTextBox.Select(start, end - start + 1);
            mainRichTextBox.Focus();
        }

        // 重载：设置字形
        private void SetFont(FontStyle style, char c)
        {
            Font ft;
            inputTextBox.Text = mainRichTextBox.SelectionStart.ToString();
            int start = mainRichTextBox.SelectionStart;
            int end = mainRichTextBox.SelectionStart + mainRichTextBox.SelectionLength - 1;

            for (int i = start; i <= end; i++)
            {
                mainRichTextBox.Select(i, 1);
                ft = mainRichTextBox.SelectionFont;
                System.Drawing.FontStyle fs = ft.Style;

                if (c == '+') fs = (System.Drawing.FontStyle)(fs | style);
                else fs = (System.Drawing.FontStyle)(fs - style);

                if (fs.ToString().IndexOf("Strikeout") >= 0) fs = (System.Drawing.FontStyle)(fs - FontStyle.Strikeout);
                
                ft = new Font(ft.Name, ft.Size, fs);
                mainRichTextBox.SelectionFont = ft;
            }
            mainRichTextBox.Select(start, end - start + 1);
            mainRichTextBox.Focus();
        }

        // 粗体按钮设置
        private void boldButton_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle fs = FontStyle.Regular;
            if (boldButton.FlatStyle == FlatStyle.Flat)
            {
                boldButton.FlatStyle = FlatStyle.Standard;
                boldButton.BackColor = Color.White;
                fs = System.Drawing.FontStyle.Bold;
                SetFont(fs, '-');
            }
            else
            {
                boldButton.FlatStyle = FlatStyle.Flat;
                boldButton.BackColor = Color.Silver;
                fs = System.Drawing.FontStyle.Bold;
                SetFont(fs, '+');
            }
        }

        // 斜体按钮设置
        private void italyButton_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle fs = FontStyle.Regular;
            if (italyButton.FlatStyle == FlatStyle.Flat)
            {
                italyButton.FlatStyle = FlatStyle.Standard;
                italyButton.BackColor = Color.White;
                fs = System.Drawing.FontStyle.Italic;
                SetFont(fs, '-');
            }
            else
            {
                italyButton.FlatStyle = FlatStyle.Flat;
                italyButton.BackColor = Color.Silver;
                fs = System.Drawing.FontStyle.Italic;
                SetFont(fs, '+');
            }
        }

        // 下划线按钮设置
        private void underlineButton_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle fs = FontStyle.Regular;
            if (underlineButton.FlatStyle == FlatStyle.Flat)
            {
                underlineButton.FlatStyle = FlatStyle.Standard;
                underlineButton.BackColor = Color.White;
                fs = System.Drawing.FontStyle.Underline;
                SetFont(fs, '-');
            }
            else
            {
                underlineButton.FlatStyle = FlatStyle.Flat;
                underlineButton.BackColor = Color.Silver;
                fs = System.Drawing.FontStyle.Underline;
                SetFont(fs, '+');
            }
        }

        // 打开文件
        private void openButton_Click(object sender, EventArgs e)
        {
            try { mainRichTextBox.LoadFile(inputTextBox.Text, RichTextBoxStreamType.RichText); }
            catch (Exception ex) { MessageBox.Show("打开文件出现错误：" + ex.ToString()); }
        }

        // 保存文件
        private void saveButton_Click(object sender, EventArgs e)
        {
            try { mainRichTextBox.SaveFile(saveTextBox.Text, RichTextBoxStreamType.RichText); }
            catch (Exception ex) { MessageBox.Show("保存文件出现错误：" + ex.ToString()); }
        }

        // 字体按钮相关
        private void songRB_CheckedChanged(object sender, EventArgs e)
        { if (songRB.Checked) SetFont("宋体"); }
        private void kaiRB_CheckedChanged(object sender, EventArgs e)
        { if (kaiRB.Checked) SetFont("楷体"); }
        private void heiRB_CheckedChanged(object sender, EventArgs e)
        { if (heiRB.Checked) SetFont("黑体"); }

        // 颜色按钮相关
        private void redRB_CheckedChanged(object sender, EventArgs e)
        { if (redRB.Checked) mainRichTextBox.SelectionColor = Color.Red; }
        private void blueRB_CheckedChanged(object sender, EventArgs e)
        { if (blueRB.Checked) mainRichTextBox.SelectionColor = Color.Blue; }
        private void blackRB_CheckedChanged(object sender, EventArgs e)
        { if (blackRB.Checked) mainRichTextBox.SelectionColor = Color.Black; }
        private void randomRB_CheckedChanged(object sender, EventArgs e)
        { if (randomRB.Checked) mainRichTextBox.SelectionColor = Color.FromArgb(new Random().Next(0, 255 * 255 * 255)); }

        // 字号按钮相关
        private void RB12_CheckedChanged(object sender, EventArgs e)
        { if (RB12.Checked) SetFont(12); }
        private void RB16_CheckedChanged(object sender, EventArgs e)
        { if (RB16.Checked) SetFont(16); }
        private void RB20_CheckedChanged(object sender, EventArgs e)
        { if (RB20.Checked) SetFont(20); }
    }
}
