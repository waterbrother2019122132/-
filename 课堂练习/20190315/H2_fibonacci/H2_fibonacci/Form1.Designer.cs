namespace H2_fibonacci
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.numberBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.tipText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(67, 79);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(532, 35);
            this.numberBox.TabIndex = 0;
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(278, 128);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(110, 39);
            this.outputButton.TabIndex = 1;
            this.outputButton.Text = "输出";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // tipText
            // 
            this.tipText.AutoSize = true;
            this.tipText.Location = new System.Drawing.Point(62, 41);
            this.tipText.Name = "tipText";
            this.tipText.Size = new System.Drawing.Size(537, 25);
            this.tipText.TabIndex = 2;
            this.tipText.Text = "单击“输出”按钮，输出斐波拉契数列的前十项";
            this.tipText.Click += new System.EventHandler(this.tipText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 203);
            this.Controls.Add(this.tipText);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.numberBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label tipText;
    }
}

