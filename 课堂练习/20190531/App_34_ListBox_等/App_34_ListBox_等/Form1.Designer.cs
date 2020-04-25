namespace App_34_ListBox_等
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "贝贝"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "晶晶"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftListBox = new System.Windows.Forms.ListBox();
            this.rightListBox = new System.Windows.Forms.ListBox();
            this.toRightButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.showLabel = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftListBox
            // 
            this.leftListBox.Font = new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.ItemHeight = 52;
            this.leftListBox.Items.AddRange(new object[] {
            "贝贝",
            "晶晶",
            "欢欢",
            "莹莹",
            "妮妮"});
            this.leftListBox.Location = new System.Drawing.Point(62, 69);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.leftListBox.Size = new System.Drawing.Size(210, 316);
            this.leftListBox.TabIndex = 0;
            // 
            // rightListBox
            // 
            this.rightListBox.Font = new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightListBox.FormattingEnabled = true;
            this.rightListBox.ItemHeight = 52;
            this.rightListBox.Location = new System.Drawing.Point(679, 69);
            this.rightListBox.Name = "rightListBox";
            this.rightListBox.Size = new System.Drawing.Size(210, 316);
            this.rightListBox.TabIndex = 1;
            // 
            // toRightButton
            // 
            this.toRightButton.Font = new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toRightButton.Location = new System.Drawing.Point(378, 189);
            this.toRightButton.Name = "toRightButton";
            this.toRightButton.Size = new System.Drawing.Size(189, 73);
            this.toRightButton.TabIndex = 2;
            this.toRightButton.Text = ">>>";
            this.toRightButton.UseVisualStyleBackColor = true;
            this.toRightButton.Click += new System.EventHandler(this.toRightButton_Click);
            // 
            // listView
            // 
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(62, 435);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(827, 142);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Chrysanthemum.jpg");
            this.imageList.Images.SetKeyName(1, "Desert.jpg");
            this.imageList.Images.SetKeyName(2, "Hydrangeas.jpg");
            this.imageList.Images.SetKeyName(3, "Jellyfish.jpg");
            this.imageList.Images.SetKeyName(4, "Koala.jpg");
            this.imageList.Images.SetKeyName(5, "Lighthouse.jpg");
            this.imageList.Images.SetKeyName(6, "Penguins.jpg");
            this.imageList.Images.SetKeyName(7, "Tulips.jpg");
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openButton.Location = new System.Drawing.Point(62, 626);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(281, 73);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "打开新窗口";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showLabel.Location = new System.Drawing.Point(53, 740);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(0, 53);
            this.showLabel.TabIndex = 5;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("苹方 中等", 13.94764F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sortButton.Location = new System.Drawing.Point(738, 720);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(151, 73);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "排序";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 853);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toRightButton);
            this.Controls.Add(this.rightListBox);
            this.Controls.Add(this.leftListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox leftListBox;
        private System.Windows.Forms.ListBox rightListBox;
        private System.Windows.Forms.Button toRightButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.Button sortButton;
    }
}

