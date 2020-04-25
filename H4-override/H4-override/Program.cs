using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace H4_override
{
    class Animal
    {
        public string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void PrintSelf()
        {
            Console.WriteLine("name:" + name);
        }
    }

    class Cat : Animal
    {
        private string color;
        public Cat(string name, string color):base(name)
        { this.color = color; }
        public override void PrintSelf()
        {
            Console.WriteLine("name:" + name + " , color:" + color);
        }

    }

    class Mouse : Animal
    {
        private string weight;
        public Mouse(string name, string weight):base(name)
        {
            this.weight = weight;
        }
        public override void PrintSelf()
        {
            Console.WriteLine("name:" + name + " , weight:" + weight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c_1 = new Cat("猫1","白色");
            Cat c_2 = new Cat("猫2","黄色");
            Mouse m_1 = new Mouse ("鼠1","1kg");
            Mouse m_2 = new Mouse("鼠2", "2kg");
            Mouse m_3 = new Mouse("鼠3", "3kg");
            Hashtable ht = new Hashtable();
            ht.Add("猫1", c_1);
            ht.Add("猫2", c_2);
            ht.Add("鼠1", m_1);
            ht.Add("鼠2", m_2);
            ht.Add("鼠3", m_3);
            
            foreach (string index in ht.Keys)
            { ((Animal)ht[index]).PrintSelf(); }
            Console.Read();
        }
    }
}
