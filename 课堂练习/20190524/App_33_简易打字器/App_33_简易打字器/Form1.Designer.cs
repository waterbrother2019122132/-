namespace App_33_简易打字器
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
            this.randomRB = new System.Windows.Forms.RadioButton();
            this.blackRB = new System.Windows.Forms.RadioButton();
            this.blueRB = new System.Windows.Forms.RadioButton();
            this.redRB = new System.Windows.Forms.RadioButton();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.boldButton = new System.Windows.Forms.Button();
            this.italyButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.fontLabel = new System.Windows.Forms.Label();
            this.heiRB = new System.Windows.Forms.RadioButton();
            this.kaiRB = new System.Windows.Forms.RadioButton();
            this.songRB = new System.Windows.Forms.RadioButton();
            this.RB20 = new System.Windows.Forms.RadioButton();
            this.RB16 = new System.Windows.Forms.RadioButton();
            this.RB12 = new System.Windows.Forms.RadioButton();
            this.formGB = new System.Windows.Forms.GroupBox();
            this.fontsGB = new System.Windows.Forms.GroupBox();
            this.colorGB = new System.Windows.Forms.GroupBox();
            this.pixelGB = new System.Windows.Forms.GroupBox();
            this.formGB.SuspendLayout();
            this.fontsGB.SuspendLayout();
            this.colorGB.SuspendLayout();
            this.pixelGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // randomRB
            // 
            this.randomRB.AutoSize = true;
            this.randomRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomRB.Location = new System.Drawing.Point(18, 172);
            this.randomRB.Name = "randomRB";
            this.randomRB.Size = new System.Drawing.Size(112, 29);
            this.randomRB.TabIndex = 17;
            this.randomRB.Text = "随机色";
            this.randomRB.UseVisualStyleBackColor = true;
            this.randomRB.CheckedChanged += new System.EventHandler(this.randomRB_CheckedChanged);
            // 
            // blackRB
            // 
            this.blackRB.AutoSize = true;
            this.blackRB.Checked = true;
            this.blackRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blackRB.Location = new System.Drawing.Point(18, 43);
            this.blackRB.Name = "blackRB";
            this.blackRB.Size = new System.Drawing.Size(87, 29);
            this.blackRB.TabIndex = 16;
            this.blackRB.TabStop = true;
            this.blackRB.Text = "黑色";
            this.blackRB.UseVisualStyleBackColor = true;
            this.blackRB.CheckedChanged += new System.EventHandler(this.blackRB_CheckedChanged);
            // 
            // blueRB
            // 
            this.blueRB.AutoSize = true;
            this.blueRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blueRB.Location = new System.Drawing.Point(18, 86);
            this.blueRB.Name = "blueRB";
            this.blueRB.Size = new System.Drawing.Size(87, 29);
            this.blueRB.TabIndex = 15;
            this.blueRB.Text = "蓝色";
            this.blueRB.UseVisualStyleBackColor = true;
            this.blueRB.CheckedChanged += new System.EventHandler(this.blueRB_CheckedChanged);
            // 
            // redRB
            // 
            this.redRB.AutoSize = true;
            this.redRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redRB.Location = new System.Drawing.Point(18, 129);
            this.redRB.Name = "redRB";
            this.redRB.Size = new System.Drawing.Size(87, 29);
            this.redRB.TabIndex = 14;
            this.redRB.Text = "红色";
            this.redRB.UseVisualStyleBackColor = true;
            this.redRB.CheckedChanged += new System.EventHandler(this.redRB_CheckedChanged);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Location = new System.Drawing.Point(38, 158);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(750, 709);
            this.mainRichTextBox.TabIndex = 12;
            this.mainRichTextBox.Text = "";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(905, 42);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(136, 35);
            this.openButton.TabIndex = 11;
            this.openButton.Text = "打开";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(215, 42);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(658, 35);
            this.inputTextBox.TabIndex = 10;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(33, 45);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(187, 25);
            this.textLabel.TabIndex = 9;
            this.textLabel.Text = "加载文件路径：";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(905, 94);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 35);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveTextBox
            // 
            this.saveTextBox.Location = new System.Drawing.Point(215, 94);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(658, 35);
            this.saveTextBox.TabIndex = 19;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(33, 97);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(187, 25);
            this.saveLabel.TabIndex = 18;
            this.saveLabel.Text = "保存文件路径：";
            // 
            // boldButton
            // 
            this.boldButton.Font = new System.Drawing.Font("Georgia", 10.93194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Location = new System.Drawing.Point(18, 37);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(53, 48);
            this.boldButton.TabIndex = 21;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italyButton
            // 
            this.italyButton.Font = new System.Drawing.Font("Georgia", 10.93194F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italyButton.Location = new System.Drawing.Point(85, 37);
            this.italyButton.Name = "italyButton";
            this.italyButton.Size = new System.Drawing.Size(53, 48);
            this.italyButton.TabIndex = 23;
            this.italyButton.Text = "I";
            this.italyButton.UseVisualStyleBackColor = true;
            this.italyButton.Click += new System.EventHandler(this.italyButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.Font = new System.Drawing.Font("Georgia", 10.93194F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.Location = new System.Drawing.Point(152, 37);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(53, 48);
            this.underlineButton.TabIndex = 24;
            this.underlineButton.Text = "U";
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fontLabel.Location = new System.Drawing.Point(815, 284);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(0, 25);
            this.fontLabel.TabIndex = 25;
            // 
            // heiRB
            // 
            this.heiRB.AutoSize = true;
            this.heiRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heiRB.Location = new System.Drawing.Point(18, 127);
            this.heiRB.Name = "heiRB";
            this.heiRB.Size = new System.Drawing.Size(87, 29);
            this.heiRB.TabIndex = 28;
            this.heiRB.Text = "黑体";
            this.heiRB.UseVisualStyleBackColor = true;
            this.heiRB.CheckedChanged += new System.EventHandler(this.heiRB_CheckedChanged);
            // 
            // kaiRB
            // 
            this.kaiRB.AutoSize = true;
            this.kaiRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kaiRB.Location = new System.Drawing.Point(18, 83);
            this.kaiRB.Name = "kaiRB";
            this.kaiRB.Size = new System.Drawing.Size(87, 29);
            this.kaiRB.TabIndex = 27;
            this.kaiRB.Text = "楷体";
            this.kaiRB.UseVisualStyleBackColor = true;
            this.kaiRB.CheckedChanged += new System.EventHandler(this.kaiRB_CheckedChanged);
            // 
            // songRB
            // 
            this.songRB.AutoSize = true;
            this.songRB.Checked = true;
            this.songRB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.songRB.Location = new System.Drawing.Point(18, 39);
            this.songRB.Name = "songRB";
            this.songRB.Size = new System.Drawing.Size(87, 29);
            this.songRB.TabIndex = 26;
            this.songRB.TabStop = true;
            this.songRB.Text = "宋体";
            this.songRB.UseVisualStyleBackColor = true;
            this.songRB.CheckedChanged += new System.EventHandler(this.songRB_CheckedChanged);
            // 
            // RB20
            // 
            this.RB20.AutoSize = true;
            this.RB20.Font = new System.Drawing.Font("Cambria", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB20.Location = new System.Drawing.Point(18, 79);
            this.RB20.Name = "RB20";
            this.RB20.Size = new System.Drawing.Size(66, 34);
            this.RB20.TabIndex = 33;
            this.RB20.Text = "20";
            this.RB20.UseVisualStyleBackColor = true;
            this.RB20.CheckedChanged += new System.EventHandler(this.RB20_CheckedChanged);
            // 
            // RB16
            // 
            this.RB16.AutoSize = true;
            this.RB16.Font = new System.Drawing.Font("Cambria", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB16.Location = new System.Drawing.Point(119, 39);
            this.RB16.Name = "RB16";
            this.RB16.Size = new System.Drawing.Size(66, 34);
            this.RB16.TabIndex = 32;
            this.RB16.Text = "16";
            this.RB16.UseVisualStyleBackColor = true;
            this.RB16.CheckedChanged += new System.EventHandler(this.RB16_CheckedChanged);
            // 
            // RB12
            // 
            this.RB12.AutoSize = true;
            this.RB12.Checked = true;
            this.RB12.Font = new System.Drawing.Font("Cambria", 9.047121F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB12.Location = new System.Drawing.Point(18, 39);
            this.RB12.Name = "RB12";
            this.RB12.Size = new System.Drawing.Size(66, 34);
            this.RB12.TabIndex = 31;
            this.RB12.TabStop = true;
            this.RB12.Text = "12";
            this.RB12.UseVisualStyleBackColor = true;
            this.RB12.CheckedChanged += new System.EventHandler(this.RB12_CheckedChanged);
            // 
            // formGB
            // 
            this.formGB.Controls.Add(this.boldButton);
            this.formGB.Controls.Add(this.italyButton);
            this.formGB.Controls.Add(this.underlineButton);
            this.formGB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formGB.Location = new System.Drawing.Point(820, 158);
            this.formGB.Name = "formGB";
            this.formGB.Size = new System.Drawing.Size(221, 103);
            this.formGB.TabIndex = 34;
            this.formGB.TabStop = false;
            this.formGB.Text = "格式";
            // 
            // fontsGB
            // 
            this.fontsGB.Controls.Add(this.songRB);
            this.fontsGB.Controls.Add(this.kaiRB);
            this.fontsGB.Controls.Add(this.heiRB);
            this.fontsGB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fontsGB.Location = new System.Drawing.Point(820, 284);
            this.fontsGB.Name = "fontsGB";
            this.fontsGB.Size = new System.Drawing.Size(221, 173);
            this.fontsGB.TabIndex = 35;
            this.fontsGB.TabStop = false;
            this.fontsGB.Text = "字体";
            // 
            // colorGB
            // 
            this.colorGB.Controls.Add(this.redRB);
            this.colorGB.Controls.Add(this.blueRB);
            this.colorGB.Controls.Add(this.blackRB);
            this.colorGB.Controls.Add(this.randomRB);
            this.colorGB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorGB.Location = new System.Drawing.Point(820, 490);
            this.colorGB.Name = "colorGB";
            this.colorGB.Size = new System.Drawing.Size(221, 221);
            this.colorGB.TabIndex = 36;
            this.colorGB.TabStop = false;
            this.colorGB.Text = "颜色";
            // 
            // pixelGB
            // 
            this.pixelGB.Controls.Add(this.RB20);
            this.pixelGB.Controls.Add(this.RB16);
            this.pixelGB.Controls.Add(this.RB12);
            this.pixelGB.Font = new System.Drawing.Font("宋体", 9.047121F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pixelGB.Location = new System.Drawing.Point(820, 741);
            this.pixelGB.Name = "pixelGB";
            this.pixelGB.Size = new System.Drawing.Size(221, 126);
            this.pixelGB.TabIndex = 37;
            this.pixelGB.TabStop = false;
            this.pixelGB.Text = "字号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 913);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveTextBox);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.mainRichTextBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.formGB);
            this.Controls.Add(this.fontsGB);
            this.Controls.Add(this.colorGB);
            this.Controls.Add(this.pixelGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.formGB.ResumeLayout(false);
            this.fontsGB.ResumeLayout(false);
            this.fontsGB.PerformLayout();
            this.colorGB.ResumeLayout(false);
            this.colorGB.PerformLayout();
            this.pixelGB.ResumeLayout(false);
            this.pixelGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton randomRB;
        private System.Windows.Forms.RadioButton blackRB;
        private System.Windows.Forms.RadioButton blueRB;
        private System.Windows.Forms.RadioButton redRB;
        private System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italyButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.RadioButton heiRB;
        private System.Windows.Forms.RadioButton kaiRB;
        private System.Windows.Forms.RadioButton songRB;
        private System.Windows.Forms.RadioButton RB20;
        private System.Windows.Forms.RadioButton RB16;
        private System.Windows.Forms.RadioButton RB12;
        private System.Windows.Forms.GroupBox formGB;
        private System.Windows.Forms.GroupBox fontsGB;
        private System.Windows.Forms.GroupBox colorGB;
        private System.Windows.Forms.GroupBox pixelGB;
    }
}

