using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_static
{
    class Cat
    {
        string name;
        int birthday;
        int idnum;
        string birthplace;
        static int count;

        public Cat(string name)                                         // 构造函数 ① 名字
        { this.name = name; count++; }

        public Cat(string name, int birthday)                           // 构造函数 ② 名字 出生日期
        { this.name = name; this.birthday = birthday; count++; }

        public Cat(string name, int birthday, string birthplace)        // 构造函数 ③ 名字 出生日期 出生地点
        { this.name = name; this.birthday = birthday; this.birthplace = birthplace; count++; }

        public int IDNum {                                              // 属性 ① 身份号码：可读可写
            get { return idnum; }
            set { idnum = value; }
        }
        public string Name {                                            // 属性 ② 名字：可读不可写
            get { return name; } set { } }

        public void outPutName() {                                      // 非静态成员方法：输出名字
            Console.Write("\n当前猫的名字是{0}，", name);
        }
        public static void outPutCount() {                              // 静态成员方法：输出总数
            Console.WriteLine("现在共有猫{0}个。\n", count);
        }
    }
}
