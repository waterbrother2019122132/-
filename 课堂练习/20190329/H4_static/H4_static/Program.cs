using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[5];
            for (int i = 0; i < cats.Length; i++)
            {
                Console.Write("请输入猫的姓名：");
                string name = Console.ReadLine();

                Console.Write("请输入这只猫的出生日期（如果不记得，请直接回车）：");
                string birthdayStr = Console.ReadLine();
                if (birthdayStr == "")
                    cats[i] = new Cat(name);
                else
                {
                    int birthday = int.Parse(birthdayStr);
                    Console.Write("请输入这只猫的出生地点（如果不记得，请直接回车）：");
                    string birthplace = Console.ReadLine();
                    if (birthplace == "")
                        cats[i] = new Cat(name, birthday);
                    else
                        cats[i] = new Cat(name, birthday, birthplace);
                }

                Console.Write("请输入这只猫的身份号码（必须输入）：");
                string idnumStr = Console.ReadLine();
                int idnum = int.Parse(idnumStr);
                cats[i].IDNum = idnum;

                cats[i].outPutName();
                Cat.outPutCount();
            }

            // 选择排序
            Cat t = new Cat("交换");
            int j, k, index, n;
            n = cats.Length;
            for(j=0; j<n-1; j++)
            {
                index=j;
                for (k = j + 1; k < n; k++) if (cats[k].IDNum > cats[index].IDNum) index = k;
                t=cats[index]; cats[index]=cats[j]; cats[j]=t;
            }

            // 输出
            Console.WriteLine("按照身份号码降序排序：");
            for (int i = 0; i < cats.Length; i++)
                Console.WriteLine("身份号码：{0}\t名称：{1}", cats[i].IDNum, cats[i].Name);

            Console.ReadLine();
        }
    }
}
