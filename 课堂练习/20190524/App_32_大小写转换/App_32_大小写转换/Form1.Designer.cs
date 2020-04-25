namespace App_32_大小写转换
{
    partial class textForm
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.bigtosmallRadioButton = new System.Windows.Forms.RadioButton();
            this.smalltobigRadioButton = new System.Windows.Forms.RadioButton();
            this.letterCheckBox = new System.Windows.Forms.CheckBox();
            this.numCheckBox = new System.Windows.Forms.CheckBox();
            this.otherCheckBox = new System.Windows.Forms.CheckBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputLabel.Location = new System.Drawing.Point(130, 127);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(134, 52);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "输入：";
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputLabel.Location = new System.Drawing.Point(130, 195);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(134, 52);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "转换：";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTextBox.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputTextBox.Location = new System.Drawing.Point(260, 124);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(586, 59);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            this.inputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyUp);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTextBox.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputTextBox.Location = new System.Drawing.Point(260, 192);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(586, 59);
            this.outputTextBox.TabIndex = 3;
            // 
            // bigtosmallRadioButton
            // 
            this.bigtosmallRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bigtosmallRadioButton.AutoSize = true;
            this.bigtosmallRadioButton.Checked = true;
            this.bigtosmallRadioButton.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bigtosmallRadioButton.Location = new System.Drawing.Point(139, 307);
            this.bigtosmallRadioButton.Name = "bigtosmallRadioButton";
            this.bigtosmallRadioButton.Size = new System.Drawing.Size(238, 57);
            this.bigtosmallRadioButton.TabIndex = 4;
            this.bigtosmallRadioButton.TabStop = true;
            this.bigtosmallRadioButton.Text = "大写转小写";
            this.bigtosmallRadioButton.UseVisualStyleBackColor = true;
            this.bigtosmallRadioButton.CheckedChanged += new System.EventHandler(this.bigtosmallRadioButton_CheckedChanged);
            // 
            // smalltobigRadioButton
            // 
            this.smalltobigRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smalltobigRadioButton.AutoSize = true;
            this.smalltobigRadioButton.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.smalltobigRadioButton.Location = new System.Drawing.Point(608, 307);
            this.smalltobigRadioButton.Name = "smalltobigRadioButton";
            this.smalltobigRadioButton.Size = new System.Drawing.Size(238, 57);
            this.smalltobigRadioButton.TabIndex = 5;
            this.smalltobigRadioButton.TabStop = true;
            this.smalltobigRadioButton.Text = "小写转大写";
            this.smalltobigRadioButton.UseVisualStyleBackColor = true;
            // 
            // letterCheckBox
            // 
            this.letterCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.letterCheckBox.AutoSize = true;
            this.letterCheckBox.Checked = true;
            this.letterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.letterCheckBox.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterCheckBox.Location = new System.Drawing.Point(139, 403);
            this.letterCheckBox.Name = "letterCheckBox";
            this.letterCheckBox.Size = new System.Drawing.Size(277, 57);
            this.letterCheckBox.TabIndex = 6;
            this.letterCheckBox.Text = "允许输入字符";
            this.letterCheckBox.UseVisualStyleBackColor = true;
            // 
            // numCheckBox
            // 
            this.numCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCheckBox.AutoSize = true;
            this.numCheckBox.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numCheckBox.Location = new System.Drawing.Point(139, 466);
            this.numCheckBox.Name = "numCheckBox";
            this.numCheckBox.Size = new System.Drawing.Size(277, 57);
            this.numCheckBox.TabIndex = 7;
            this.numCheckBox.Text = "允许输入数字";
            this.numCheckBox.UseVisualStyleBackColor = true;
            // 
            // otherCheckBox
            // 
            this.otherCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otherCheckBox.AutoSize = true;
            this.otherCheckBox.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.otherCheckBox.Location = new System.Drawing.Point(139, 529);
            this.otherCheckBox.Name = "otherCheckBox";
            this.otherCheckBox.Size = new System.Drawing.Size(277, 57);
            this.otherCheckBox.TabIndex = 8;
            this.otherCheckBox.Text = "允许输入其它";
            this.otherCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeButton.Font = new System.Drawing.Font("苹方 常规", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeButton.Location = new System.Drawing.Point(494, 513);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(352, 73);
            this.changeButton.TabIndex = 9;
            this.changeButton.Text = "转换";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 703);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.otherCheckBox);
            this.Controls.Add(this.numCheckBox);
            this.Controls.Add(this.letterCheckBox);
            this.Controls.Add(this.smalltobigRadioButton);
            this.Controls.Add(this.bigtosmallRadioButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "textForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.RadioButton bigtosmallRadioButton;
        private System.Windows.Forms.RadioButton smalltobigRadioButton;
        private System.Windows.Forms.CheckBox letterCheckBox;
        private System.Windows.Forms.CheckBox numCheckBox;
        private System.Windows.Forms.CheckBox otherCheckBox;
        private System.Windows.Forms.Button changeButton;

    }
}

