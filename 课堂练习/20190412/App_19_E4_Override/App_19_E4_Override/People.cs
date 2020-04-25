using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_19_E4_Override
{
    class People                                    // 定义基类
    {
        protected string name;
        public People(string name)
        {
            this.name = name;
        }

        public virtual void printInfo()             // 创建虚函数
        {
            Console.WriteLine("他的名字是{0}。", name);
        }

        public static void show(People p)
        {
            p.printInfo();
        }
    }

    class Boyfriend : People                        // 定义子类 1：Boyfriend
    {
        int date;

        public Boyfriend(string name, int date)
            : base(name)
        {
            this.date = date;
        }

        public override void printInfo()            // 重写
        {
            Console.WriteLine("男友的名字是{0}，相识日期是{1}。", name, date);
        }
    }

    class Father : People                           // 定义子类 2：Father
    {
        int birthday;
        
        public Father(string name, int birthday)
            : base(name)
        {
            this.birthday = birthday;
        }

        public override void printInfo()            // 重写
        {
            Console.WriteLine("爸爸的名字是{0}，生日是{1}。", name, birthday);
        }
    }
}
