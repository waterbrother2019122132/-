using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_Interface
{
    interface ICat
    {
        void getInterest();
        string Color { get; set; }
    }

    class Animal
    {
        string name;
        public Animal(string name)
        {
            this.name = name;
        }
    }

    class Cat : Animal, ICat
    {
        string name, interest, color;

        public Cat(string name, string interest)
            : base(name)
        {
            this.name = name;
            this.interest = interest;
        }

        public void show()
        {   Console.WriteLine("小猫的名字是{0}，它的颜色是{1}", name, color); }

        public void getInterest()
        {   Console.WriteLine("它的爱好是{0}。", interest); }
        
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("汤姆", "抓老鼠");
            cat.Color = "灰色";
            cat.show();
            cat.getInterest();

            Console.ReadLine();
        }
    }
}
