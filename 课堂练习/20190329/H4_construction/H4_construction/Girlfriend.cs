using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_construction
{
    class Girlfriend
    {
        string name;
        int date;
        int day;

        public Girlfriend(string name)      // 构造函数：姓名
        { this.name = name; }

        public int Date                     // 属性：相识日期（可读可写）
        {
            get { return date; }
            set { date = value; }
        }
        public int Day                      // 属性：恋爱长度（可读可写）
        {
            get { return day; }
            set { day = value; }
        }
    }
}
