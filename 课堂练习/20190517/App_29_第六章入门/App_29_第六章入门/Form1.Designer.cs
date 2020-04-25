namespace App_29_第六章入门
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
            this.components = new System.ComponentModel.Container();
            this.sharpTimer = new System.Windows.Forms.Timer(this.components);
            this.sharpLabel = new System.Windows.Forms.Label();
            this.controlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sharpTimer
            // 
            this.sharpTimer.Interval = 50;
            this.sharpTimer.Tick += new System.EventHandler(this.sharpTimer_Tick);
            // 
            // sharpLabel
            // 
            this.sharpLabel.AutoSize = true;
            this.sharpLabel.Location = new System.Drawing.Point(262, 161);
            this.sharpLabel.Name = "sharpLabel";
            this.sharpLabel.Size = new System.Drawing.Size(25, 25);
            this.sharpLabel.TabIndex = 0;
            this.sharpLabel.Text = "#";
            this.sharpLabel.Click += new System.EventHandler(this.sharpLabel_Click);
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(201, 83);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(143, 55);
            this.controlButton.TabIndex = 1;
            this.controlButton.Text = "开始";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 291);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.sharpLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer sharpTimer;
        private System.Windows.Forms.Label sharpLabel;
        private System.Windows.Forms.Button controlButton;

    }
}

