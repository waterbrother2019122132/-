using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_15_构造函数
{
    class Girlfriend
    {
        string name;                                // 变量一般是私有或保护的，方法和属性一般是公有的
        int date;
        int length;

        // 使用构造函数进行初始化
        public Girlfriend(string name)              // 构造函数 ①：一个参数的构造函数
        {
            this.name = name;
        }
        public Girlfriend(string name, int date)    // 构造函数 ②：构造函数重载，两个参数的构造函数
        {
            this.name = name;
            this.date = date;
        }

        // 恋爱时长属性：可读可写
        public int Length
        {
            get                     // 可读
            {
                return length;
            }
            set                     // 可写
            {
                length = value;     // value 表示外部的赋值
            }
        }

        // 女友名字属性：可读、不可写
        public string Name
        {
            get                     // 可读
            {
                return name;
            }
            set { }                 // 无内容，即不可写
        }

        // 同理，恋爱时长属性：可读、不可写
        public int Date
        {
            get { return date; }
            set { }
        }
    }
}
