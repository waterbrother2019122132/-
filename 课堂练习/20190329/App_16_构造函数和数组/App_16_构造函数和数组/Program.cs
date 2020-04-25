using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_16_构造函数和数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Girlfriend[] gfs = new Girlfriend[2];           // 给数组分配存储空间
            for (int i = 0; i < gfs.Length; i++)
            {
                Console.Write("请输入女友姓名：");
                string name = Console.ReadLine();

                Console.Write("请输入相识日期（如果不记得，请直接回车）：");
                string dateStr = Console.ReadLine();
                if (dateStr == "")                          // 如果输入的相识日期为空，调用构造函数 ①
                    gfs[i] = new Girlfriend(name);
                else {                                      // 如果输入了相识日期，调用构造函数 ②
                    int date = int.Parse(dateStr);
                    gfs[i] = new Girlfriend(name, date); }

                Console.Write("请输入恋爱长度：");
                string lengthStr = Console.ReadLine();
                int length = int.Parse(lengthStr);
                gfs[i].Length = length;
            }

            Console.WriteLine("\n大于30天的女友列表：");
            for (int i = 0; i < gfs.Length; i++)
                if (gfs[i].Length > 30) Console.WriteLine("名字：{0}；恋爱时长：{1}", gfs[i].Name, gfs[i].Length);

            Console.ReadLine();
        }
    }
}
