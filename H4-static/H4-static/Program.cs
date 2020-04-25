using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_static
{
    class Cat
    {
        private int age;
        private string names;
        private static string gender;  //静态成员变量

        public Cat(int age, string colors)  //构造函数
        { this.age = age;
        this.names = colors;
        }

        public int Attage    //属性 1
        {
            get { return age; }
            set { age = value; }
        }

        public string Attnames  //属性 2
        {

            get { return names; }
            set { names = value; }
        }
        public int this[int index]//索引器 
        {
            get
            {
                if (index == 1)
                    return age;
                else return 0;
                
            }
            set
            {
                if (index == 1)
                    age = value;
                
            }
        }

        public void setAge()//非静态成员方法
        {
            age = 6;
        }

        public static void setGender(string y)//静态成员方法
        {
            gender = y;
        }

    }
   
 class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[5];
            cats[0] = new Cat(5, "小白");
            cats[1] = new Cat(4, "小黑");
            cats[2] = new Cat(7, "小黄");
            cats[3] = new Cat(2, "小灰");
            cats[4] = new Cat(9, "小蓝");
            cats[0].setAge();//调用非静态成员方法
            Cat.setGender("雄");//调用静态成员方法
            Console.WriteLine("Before sorted:");
            for (int n = 0; n < cats.Length; n++)
            {
                Console.WriteLine("{0}" + " " + "{1}" + "岁", cats[n].Attnames, cats[n].Attage);
            }
            Console.WriteLine("第一只猫的年龄:" + cats[0][1]+"岁");//利用索引器访问数组中第0个元素的数据，并输出

            for (int i = 0; i < cats.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < cats.Length; j++)
                {
                    if (cats[j][1] > cats[max][1])
                        max = j;
                    Cat temp = cats[i];
                    cats[i] = cats[max];
                    cats[max] = temp;
                } 
            }//对年龄降序排序

            Console.WriteLine(" ");
            Console.WriteLine("After sorted:");
            for (int m = 0; m < cats.Length; m++)
            {
                Console.WriteLine("{0}"+" "+"{1}"+"岁",cats[m].Attnames,cats[m].Attage );
            }
                Console.Read();
        }
    }
        }
        
    
 