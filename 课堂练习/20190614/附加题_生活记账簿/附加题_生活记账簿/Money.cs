using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 附加题_生活记账簿
{
    public class Money
    {
        string name;
        double num;
        string kind;
        DateTime dt;
        int flag;

        public Money(string name, double num, string kind, DateTime dt, int flag)
        {
            this.name = name;
            this.num = num;
            this.kind = kind;
            this.dt = dt;
            this.flag = flag;
        }

        public string Name
        { get { return name; } }

        public double Num
        { get { return num; } }

        public DateTime DT
        { get { return dt; } }

        public string Kind
        { get { return kind; } }

        public int Flag
        { get { return flag; } }
    }
}
