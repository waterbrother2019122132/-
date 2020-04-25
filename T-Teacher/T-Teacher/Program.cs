using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Teacher
{
    class Teacher
    {
        public int number;
        public string name;
        public double salary;
        public static int a;
        public Teacher(int number, string name, double salary)
        {
            this.number = number;
            this.name = name;
            this.salary = salary;
            a++;
        }
        public dynamic this[int index]
        {
            get
            {
                if (index == 1) return name;
                else if (index > 1) return number;
                else return salary;
            }
            set
            {
                if (index == 1) name = value;
                else if (index > 1) number = value;
                else salary = value;
            }
        }
        public virtual void PrintInfor()
        {
            Console.WriteLine("工号:" + number + "姓名:" + name + "工资:" + salary);
        }
        public static void PrintNum()
        {
            Console.WriteLine("当前老师对象共有" + a + "个");
        }
    }
    class ExcellentTeacher : Teacher
    {
        private double reward;
        public ExcellentTeacher(int number, string name, double salary, double reward)
            : base(number, name, salary)
        {
            this.reward = reward;
        }
        public override void PrintInfor()
        {
            Console.WriteLine("工号:" + number + "姓名:" + name + "工资:" + salary + "奖金:" + reward);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] ls = new Teacher[6];
            ls[0] = new Teacher(01, "小李", 5000);
            ls[1] = new Teacher(02, "小王", 6000);
            ls[2] = new Teacher(03, "小张", 7000);
            ls[3] = new ExcellentTeacher(04, "小陈", 8000, 1000);
            ls[4] = new ExcellentTeacher(05, "小林", 9000, 2000);
            ls[5] = new ExcellentTeacher(06, "小刘", 10000, 3000);

            Teacher.PrintNum();
            ls[3][0] = 8100;
            ls[4][0] = 9100;
            ls[5][0] = 10100;
            Console.WriteLine("排序前:");
            for (int n = 0; n < ls.Length; n++)
            {
                ls[n].PrintInfor();
            }

            for (int i = 0; i < ls.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < ls.Length; j++)
                {
                    if (ls[j][0] > ls[max][0])
                        max = j;
                    Teacher temp = ls[i];
                    ls[i] = ls[max];
                    ls[max] = temp;
                }

            }
            Console.WriteLine("排序后:");
            for (int m = 0; m < ls.Length; m++)
            {
                ls[m].PrintInfor();
            }
            Console.Read();
        }

    }
}
