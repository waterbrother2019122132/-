namespace App_38_E7_File_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示零用钱明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存取零用钱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.存取ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示零用钱明细ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 显示零用钱明细ToolStripMenuItem
            // 
            this.显示零用钱明细ToolStripMenuItem.Name = "显示零用钱明细ToolStripMenuItem";
            this.显示零用钱明细ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.显示零用钱明细ToolStripMenuItem.Text = "显示零用钱明细";
            this.显示零用钱明细ToolStripMenuItem.Click += new System.EventHandler(this.显示零用钱明细ToolStripMenuItem_Click);
            // 
            // 存取ToolStripMenuItem
            // 
            this.存取ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.存取零用钱ToolStripMenuItem});
            this.存取ToolStripMenuItem.Name = "存取ToolStripMenuItem";
            this.存取ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.存取ToolStripMenuItem.Text = "存取";
            // 
            // 存取零用钱ToolStripMenuItem
            // 
            this.存取零用钱ToolStripMenuItem.Name = "存取零用钱ToolStripMenuItem";
            this.存取零用钱ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.存取零用钱ToolStripMenuItem.Text = "存取零用钱";
            this.存取零用钱ToolStripMenuItem.Click += new System.EventHandler(this.存取零用钱ToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(41, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 345);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 453);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示零用钱明细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存取零用钱ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

