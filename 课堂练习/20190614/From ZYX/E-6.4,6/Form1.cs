using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_6._4_6
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        FontDialog fontDialog;
        ColorDialog colorDialog;
        RichTextBox[] richTextBoxes;
        Label[] labels;
        

        public Form1()
        {
        
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "rtf 文件(*.rtf) |*.rtf|txt 文件(*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                txtRichTextBox.LoadFile(openFileDialog.FileName);
                int x = txtRichTextBox.Location.X;
                int y = txtRichTextBox.Location.Y;
                namelabel.Text = "1.文件名:"+openFileDialog.SafeFileName;
              richTextBoxes = new RichTextBox[openFileDialog.FileNames.Length];
                labels= new Label[openFileDialog.FileNames.Length];
            
                for (int i = 1; i <openFileDialog.FileNames.Length; i++)
                 {
                  
                    this.labels[i - 1] = new Label();
                    this.Controls.Add(labels[i - 1]);
                  labels[i-1].Location = new System.Drawing.Point(i * 250, y-10);
                    this.richTextBoxes[i-1] = new RichTextBox();
                    this.Controls.Add(richTextBoxes[i - 1]);
                    this.richTextBoxes[i-1].Location = new System.Drawing.Point(i*250, y+20);
                    this.richTextBoxes[i-1].Size = new System.Drawing.Size(200, 200);
                    int pos = openFileDialog.FileNames[i].LastIndexOf('\\');
                    string dirpath = openFileDialog.FileNames[i].Substring(0, pos);
                    string filename = openFileDialog.FileNames[i].Substring(pos + 1);
                   richTextBoxes[i-1].LoadFile(dirpath+'\\'+filename);
                    labels[i - 1].Text = i+1+".文件名:"+filename;
              
                 }
                
               
            }        
                    
               
               
            
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.Filter = "rtf 文件(*.rtf) |*.rtf|txt 文件(*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            
                txtRichTextBox.SaveFile(saveFileDialog.FileName);
             

            
        }
        private void Modify(RichTextBox x)
        {
            if (x.SelectionLength == 0)
            {
                字体ToolStripMenuItem.Enabled = false;               
                颜色ToolStripMenuItem.Enabled = false;
                字体ToolStripMenuItem1.Enabled = false;
                颜色ToolStripMenuItem1.Enabled = false;
                复制ToolStripMenuItem.Enabled = false;
                复制ToolStripMenuItem1.Enabled = false;
                剪切ToolStripMenuItem.Enabled = false;
                剪切ToolStripMenuItem2.Enabled = false;
                
                
            }
            else if(x.SelectionLength>=1)
            {
                字体ToolStripMenuItem.Enabled = true;
                颜色ToolStripMenuItem.Enabled = true;
                字体ToolStripMenuItem1.Enabled = true ;
                颜色ToolStripMenuItem1.Enabled = true;
                复制ToolStripMenuItem.Enabled = true ;
                复制ToolStripMenuItem1.Enabled = true;
                剪切ToolStripMenuItem.Enabled =true;
                剪切ToolStripMenuItem2.Enabled = true;
            }

        }
      
        private void txtRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            Modify(txtRichTextBox);
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                txtRichTextBox.SelectionFont = fontDialog.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                txtRichTextBox.SelectionColor = colorDialog.Color;
        }

        private void 字体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                txtRichTextBox.SelectionFont = fontDialog.Font;
        }

        private void 颜色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                txtRichTextBox.SelectionColor = colorDialog.Color;
        }

        private void openStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "rtf 文件(*.rtf) |*.rtf|txt 文件(*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRichTextBox.LoadFile(openFileDialog.FileName);
                
            }
                
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.Filter = "rtf 文件(*.rtf) |*.rtf|txt 文件(*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                txtRichTextBox.SaveFile(saveFileDialog.FileName);
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Paste();
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Copy();
           
           
        }

        private void 粘贴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Paste();
        }

        private void 撤销ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Undo();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Cut();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichTextBox.SelectAll();
        }

        private void 剪切ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtRichTextBox.Cut();
        }

        private void 全选ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtRichTextBox.SelectAll();
        }

       
    }
}
