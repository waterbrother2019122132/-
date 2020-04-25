namespace E_6._4_6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.字体ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.namelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.打开ToolStripMenuItem.Text = "打开(可以多选）";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.保存ToolStripMenuItem.Text = "保存（只能保存第一个）";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.复制ToolStripMenuItem1,
            this.粘贴ToolStripMenuItem1,
            this.撤销ToolStripMenuItem1,
            this.剪切ToolStripMenuItem2,
            this.全选ToolStripMenuItem1});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Enabled = false;
            this.字体ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Enabled = false;
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem1
            // 
            this.复制ToolStripMenuItem1.Name = "复制ToolStripMenuItem1";
            this.复制ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.复制ToolStripMenuItem1.Text = "复制";
            this.复制ToolStripMenuItem1.Click += new System.EventHandler(this.复制ToolStripMenuItem1_Click);
            // 
            // 粘贴ToolStripMenuItem1
            // 
            this.粘贴ToolStripMenuItem1.Name = "粘贴ToolStripMenuItem1";
            this.粘贴ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.粘贴ToolStripMenuItem1.Text = "粘贴";
            this.粘贴ToolStripMenuItem1.Click += new System.EventHandler(this.粘贴ToolStripMenuItem1_Click);
            // 
            // 撤销ToolStripMenuItem1
            // 
            this.撤销ToolStripMenuItem1.Name = "撤销ToolStripMenuItem1";
            this.撤销ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.撤销ToolStripMenuItem1.Text = "撤销";
            this.撤销ToolStripMenuItem1.Click += new System.EventHandler(this.撤销ToolStripMenuItem1_Click);
            // 
            // 剪切ToolStripMenuItem2
            // 
            this.剪切ToolStripMenuItem2.Name = "剪切ToolStripMenuItem2";
            this.剪切ToolStripMenuItem2.Size = new System.Drawing.Size(114, 26);
            this.剪切ToolStripMenuItem2.Text = "剪切";
            this.剪切ToolStripMenuItem2.Click += new System.EventHandler(this.剪切ToolStripMenuItem2_Click);
            // 
            // 全选ToolStripMenuItem1
            // 
            this.全选ToolStripMenuItem1.Name = "全选ToolStripMenuItem1";
            this.全选ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.全选ToolStripMenuItem1.Text = "全选";
            this.全选ToolStripMenuItem1.Click += new System.EventHandler(this.全选ToolStripMenuItem1_Click);
            // 
            // txtRichTextBox
            // 
            this.txtRichTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.txtRichTextBox.Location = new System.Drawing.Point(11, 144);
            this.txtRichTextBox.Name = "txtRichTextBox";
            this.txtRichTextBox.Size = new System.Drawing.Size(260, 264);
            this.txtRichTextBox.TabIndex = 1;
            this.txtRichTextBox.Text = "\n\n";
            this.txtRichTextBox.SelectionChanged += new System.EventHandler(this.txtRichTextBox_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem1,
            this.颜色ToolStripMenuItem1,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.全选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 172);
            // 
            // 字体ToolStripMenuItem1
            // 
            this.字体ToolStripMenuItem1.Enabled = false;
            this.字体ToolStripMenuItem1.Name = "字体ToolStripMenuItem1";
            this.字体ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.字体ToolStripMenuItem1.Text = "字体";
            this.字体ToolStripMenuItem1.Click += new System.EventHandler(this.字体ToolStripMenuItem1_Click);
            // 
            // 颜色ToolStripMenuItem1
            // 
            this.颜色ToolStripMenuItem1.Enabled = false;
            this.颜色ToolStripMenuItem1.Name = "颜色ToolStripMenuItem1";
            this.颜色ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.颜色ToolStripMenuItem1.Text = "颜色";
            this.颜色ToolStripMenuItem1.Click += new System.EventHandler(this.颜色ToolStripMenuItem1_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStripButton,
            this.saveStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openStripButton
            // 
            this.openStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openStripButton.Image")));
            this.openStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openStripButton.Name = "openStripButton";
            this.openStripButton.Size = new System.Drawing.Size(213, 24);
            this.openStripButton.Text = "打开（只能打开一个文件）";
            this.openStripButton.Click += new System.EventHandler(this.openStripButton_Click);
            // 
            // saveStripButton
            // 
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(198, 24);
            this.saveStripButton.Text = "保存（只能保存第一个）";
            this.saveStripButton.Click += new System.EventHandler(this.saveStripButton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(42, 114);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 15);
            this.namelabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "暂时只能编辑第一个richTextBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtRichTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openStripButton;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem2;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label1;
    }
}

