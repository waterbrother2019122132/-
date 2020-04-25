using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_29_第六章入门
{
    public partial class Form1 : Form
    {
        int direction;

        public Form1()
        {
            direction = 0;
            InitializeComponent();
        }

        private void sharpTimer_Tick(object sender, EventArgs e)
        {
            sharpLabel.Visible = !sharpLabel.Visible;
            int max_1 = this.ClientRectangle.Width - 20;
            int max_2 = this.ClientRectangle.Height - 20;
            if (direction == 0)
            {
                sharpLabel.Left = sharpLabel.Left + 5;
                if (sharpLabel.Left >= max_1) direction = 1;
            }
            else if (direction == 1)
            {
                sharpLabel.Top = sharpLabel.Top - 5;
                if (sharpLabel.Top <= 10) direction = 2;
            }
            else if (direction == 2)
            {
                sharpLabel.Left = sharpLabel.Left - 5;
                if (sharpLabel.Left <= 10) direction = 3;
            }
            else
            {
                sharpLabel.Top = sharpLabel.Top + 5;
                if (sharpLabel.Top >= max_2) direction = 0;
            }
        }

        private void sharpLabel_Click(object sender, EventArgs e)
        {

        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            sharpTimer.Enabled = !sharpTimer.Enabled;
            if (sharpTimer.Enabled == true) controlButton.Text = "停止";
            else controlButton.Text = "继续";
        }
    }
}
