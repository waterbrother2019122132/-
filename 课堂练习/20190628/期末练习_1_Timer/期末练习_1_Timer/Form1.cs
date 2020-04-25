using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末练习_1_Timer
{
    public partial class Form1 : Form
    {
        double Q = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            double x = this.ClientRectangle.Width / 2 - 20;
            double y = this.ClientRectangle.Height / 2;
            double r = this.ClientRectangle.Height / 3;

            Q += 0.1;

            label1.Left = (int)(r * Math.Cos(Q) + x);
            label1.Top = (int)(r * Math.Sin(Q) + y);
        }
    }
}
