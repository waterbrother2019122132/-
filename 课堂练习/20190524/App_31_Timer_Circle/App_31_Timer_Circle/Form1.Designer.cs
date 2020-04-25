namespace App_31_Timer_Circle
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
            this.dollarLabel = new System.Windows.Forms.Label();
            this.dollarTimer = new System.Windows.Forms.Timer(this.components);
            this.moveButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.twinkleButton = new System.Windows.Forms.Button();
            this.directionButton = new System.Windows.Forms.Button();
            this.visibleTimer = new System.Windows.Forms.Timer(this.components);
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(310, 431);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(25, 25);
            this.dollarLabel.TabIndex = 0;
            this.dollarLabel.Text = "$";
            // 
            // dollarTimer
            // 
            this.dollarTimer.Interval = 50;
            this.dollarTimer.Tick += new System.EventHandler(this.dollarTimer_Tick);
            // 
            // moveButton
            // 
            this.moveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveButton.Location = new System.Drawing.Point(598, 41);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(133, 41);
            this.moveButton.TabIndex = 1;
            this.moveButton.Text = "开始";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorButton.Location = new System.Drawing.Point(598, 106);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(133, 41);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "变色";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // twinkleButton
            // 
            this.twinkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.twinkleButton.Location = new System.Drawing.Point(598, 171);
            this.twinkleButton.Name = "twinkleButton";
            this.twinkleButton.Size = new System.Drawing.Size(133, 41);
            this.twinkleButton.TabIndex = 3;
            this.twinkleButton.Text = "闪烁";
            this.twinkleButton.UseVisualStyleBackColor = true;
            this.twinkleButton.Click += new System.EventHandler(this.twinkleButton_Click);
            // 
            // directionButton
            // 
            this.directionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.directionButton.Location = new System.Drawing.Point(598, 236);
            this.directionButton.Name = "directionButton";
            this.directionButton.Size = new System.Drawing.Size(133, 41);
            this.directionButton.TabIndex = 4;
            this.directionButton.Text = "顺时针";
            this.directionButton.UseVisualStyleBackColor = true;
            this.directionButton.Click += new System.EventHandler(this.directionButton_Click);
            // 
            // visibleTimer
            // 
            this.visibleTimer.Interval = 50;
            this.visibleTimer.Tick += new System.EventHandler(this.visibleTimer_Tick);
            // 
            // colorTimer
            // 
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 527);
            this.Controls.Add(this.directionButton);
            this.Controls.Add(this.twinkleButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.dollarLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Timer dollarTimer;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button twinkleButton;
        private System.Windows.Forms.Button directionButton;
        private System.Windows.Forms.Timer visibleTimer;
        private System.Windows.Forms.Timer colorTimer;
    }
}

