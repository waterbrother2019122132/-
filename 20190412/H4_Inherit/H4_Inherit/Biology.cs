using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Inherit
{
    class Biology
    {
        string name;                                    // 创建保护成员变量：生物名字

        public Biology(string name)                     // 创建构造函数：生物名字
        {
            this.name = name;
        }

        protected void printName()                      // 公有成员方法：输出生物名字
        {
            Console.WriteLine("这个生物的名字是{0}。", name);
        }
    }

    class Cat : Biology                                 // 基于 Biology 的第一个派生类 Cat
    {
        string food;                                    // 创建私有成员变量：食物

        public Cat(string name) : base(name) { }        // 创建构造函数 ①：生物名字

        public Cat(string name_1, string food) : base(name_1)       // 创建构造函数 ②：生物名字 + 食物
        {
            this.food = food;
        }

        public void show()                              // 公有成员方法：输出生物名字和食物
        {
            printName();                                // 调用基类中的公有成员方法输出生物名字
            Console.WriteLine("它喜欢吃{0}。\n", food);
        }
    }

    class Tree : Biology                                // 基于 Biology 的第二个派生类 Tree
    {
        int age;                                        // 创建私有成员变量：年龄

        public Tree(string name) : base(name) { }       // 创建构造函数 ①：生物名字

        public Tree(string name_1, int age) : base(name_1)       // 创建构造函数 ②：生物名字 + 年龄
        {
            this.age = age;
        }

        public void show()                              // 公有成员方法：输出生物名字和年龄
        {
            printName();
            Console.WriteLine("它的年龄是{0}。\n", age);
        }
    }
}
