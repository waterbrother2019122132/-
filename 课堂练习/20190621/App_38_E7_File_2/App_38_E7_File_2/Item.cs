using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_38_E7_File_2
{
    public class Item
    {
        string result;
        double money;
        DateTime dt;

        public Item(string result, double money, DateTime dt)
        {
            this.result = result;
            this.money = money;
            this.dt = dt;
        }

        public string Result
        { get { return result; } }

        public double Money
        { get { return money; } }

        public DateTime DT
        { get { return dt; } }
    }
}
