using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_inherit
{
    class Program
    {
        class Biology
        {
        private string name;//私有成员变量
        public Biology(string name)//一个有参数的构造函数
        { this.name=name;}
        protected void pringName()//保护成员方法
        {
            Console.WriteLine("名称是" + name);//打印name
        }
        }

        class Cat : Biology 
        {
            private string food;//私有成员变量
            public Cat(string name)//构造函数1
                : base(name)
            {}
            public Cat(string name, string food)//构造函数2
                : base(name)
            {
                this.food = food;
            }
            public void show()//公有成员方法
            {
                base.pringName();
                Console.WriteLine( "食物是" + food);
            }
        }

        class Tree : Biology
        {
            private int age;//私有成员变量
            public Tree (string name):base(name)//构造函数1
            {}
            public Tree(int age, string name)//构造函数2
                : base(name)
            { this.age=age;}
            public void show()//公有成员方法
            {
                base.pringName();
                Console.WriteLine("年龄是" + age);
            }
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom","Jerry");
            Tree tree = new Tree(100, "Oldtree");
            cat.show();
            tree.show();//在主函数中新建对象cat，tree，并调用相应方法
            Console.Read();
        }
    }
}
