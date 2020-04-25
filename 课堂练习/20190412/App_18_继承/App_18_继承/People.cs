using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_18_继承
{
    class People                                        // 基类：People
    {
        protected string name;                          // 创建保护成员变量：本名

        public People(string name)                      // 创建构造函数：本名
        {
            this.name = name;
        }

        public void showName()                          // 公有成员方法：输出本名
        {
            Console.WriteLine("他的本名是{0}", name);
        }
    }

    class Boyfriend : People                            // 基于 People 的第一个派生类 Boyfriend
    {
        new string name;                                // 创建私有成员变量：昵称（与基类 People 中的保护成员 name 同名）
        int length;                                     // 创建私有成员变量：恋爱长度

        public Boyfriend(string name, int length)       // 创建构造函数：本名 + 恋爱长度
            : base(name)                                // 基于基类中的本名构造函数，可以继承基类中的本名
        {
            this.length = length;
        }

        public Boyfriend(string name_1, int length, string name_2)      // 创建构造函数：本名 + 恋爱长度 + 昵称
            : base(name_1)
        {
            this.length = length;
            name = name_2;
        }

        public void show()                              // 公有成员方法：输出本名、昵称和恋爱长度
        {
            showName();                                 // 调用基类中的公有成员方法输出本名
            Console.WriteLine("他的昵称是{0}", name);
            Console.WriteLine("恋爱长度是{0}\n", length);
        }
    }
}
