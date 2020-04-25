using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_30_E6_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sharpLabel.Visible = true;
            sharpLabel.Text = "被你抓到了";
            sharpTimer.Enabled = false;
        }

        private void sharpTimer_Tick(object sender, EventArgs e)
        {
            sharpLabel.Visible = !sharpLabel.Visible;
            int max_1 = this.ClientRectangle.Width - 30;
            int max_2 = this.ClientRectangle.Height - 30;

            Random rd = new Random();
            int a = rd.Next(10, max_1);
            int b = rd.Next(10, max_2);
            sharpLabel.Left = a;
            sharpLabel.Top = b;
        }
    }
}
