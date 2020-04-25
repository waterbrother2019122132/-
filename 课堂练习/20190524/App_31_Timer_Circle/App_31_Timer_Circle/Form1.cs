using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_31_Timer_Circle
{
    public partial class Form1 : Form
    {
        double Q = 0;
        double direction_flag = 0.1;

        // 如果不添加控制闪烁的计时器，可以使用注释中的语句实现闪烁
        // int visible_flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dollarTimer_Tick(object sender, EventArgs e)
        {
            double x = this.ClientRectangle.Height / 2;
            double y = this.ClientRectangle.Width / 2 - 50;
            double r = this.ClientRectangle.Height / 3;
            Q += direction_flag;
            dollarLabel.Top = (int)(r * Math.Cos(Q) + x);
            dollarLabel.Left = (int)(r * Math.Sin(Q) + y);
            // if (visible_flag == 1) dollarLabel.Visible = !dollarLabel.Visible;
        }

        private void visibleTimer_Tick(object sender, EventArgs e)
        {
            dollarLabel.Visible = !dollarLabel.Visible;
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            if (dollarLabel.ForeColor != Color.Red) dollarLabel.ForeColor = Color.Red;
            else dollarLabel.ForeColor = Color.Blue;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            dollarTimer.Enabled = !dollarTimer.Enabled;
            if (dollarTimer.Enabled == false) moveButton.Text = "开始";
            else moveButton.Text = "停止";
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorTimer.Enabled = !colorTimer.Enabled;
            if (colorTimer.Enabled == true) colorButton.Text = "不变色";
            else { colorButton.Text = "变色"; dollarLabel.ForeColor = Color.Black; }
        }

        private void twinkleButton_Click(object sender, EventArgs e)
        {
            // if (visible_flag == 0) { visible_flag = 1; twinkleButton.Text = "不闪烁"; }
            // else { visible_flag = 0; twinkleButton.Text = "闪烁"; dollarLabel.Visible = true; }

            visibleTimer.Enabled = !visibleTimer.Enabled;
            if (visibleTimer.Enabled == true) twinkleButton.Text = "不闪烁";
            else { twinkleButton.Text = "闪烁"; dollarLabel.Visible = true; }
        }

        private void directionButton_Click(object sender, EventArgs e)
        {
            if (direction_flag == 0.1) { direction_flag = -0.1; directionButton.Text = "逆时针"; }
            else { direction_flag = 0.1; directionButton.Text = "顺时针"; }
        }
    }
}
