using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_16_构造函数和数组
{
    class Girlfriend
    {
        string name;
        int date;
        int length;

        public Girlfriend(string name)              // 构造函数 ①
        { this.name = name; }
        public Girlfriend(string name, int date)    // 构造函数 ②
        { this.name = name; this.date = date; }

        public int Length {                         // 可读可写
            get { return length; }
            set { length = value; } }
        public string Name {                        // 可读不可写
            get { return name; } set { } }
    }
}
