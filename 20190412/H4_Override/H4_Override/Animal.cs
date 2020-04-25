using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Override
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void printSelf()             // 创建虚函数
        {
            Console.WriteLine("它的名字是{0}。", name);
        }

        public static void show(Animal ani)
        {
            ani.printSelf();
        }
    }

    class Cat : Animal
    {
        string color;

        public Cat(string name, string color)
            : base(name)
        {
            this.color = color;
        }

        public override void printSelf()            // 重写
        {
            Console.WriteLine("它的名字是{0}，颜色是{1}。", name, color);
        }
    }

    class Mouse : Animal
    {
        double weight;

        public Mouse(string name, double weight)
            : base(name)
        {
            this.weight = weight;
        }

        public override void printSelf()            // 重写
        {
            Console.WriteLine("它的名字是{0}，重量是{1}千克。", name, weight);
        }
    }
}
