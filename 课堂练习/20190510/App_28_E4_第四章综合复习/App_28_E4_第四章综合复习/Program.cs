using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_28_E4_第四章综合复习
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Manager m = new Manager();
                
                for (; ; )
                {
                    Console.WriteLine("\n**********【男朋友管理系统】**********");
                    Console.WriteLine("请选择以下操作：");
                    Console.WriteLine("1：新建男友");
                    Console.WriteLine("2：删除男友");
                    Console.WriteLine("3：修改男友信息");
                    Console.WriteLine("4：给男友排序");
                    Console.WriteLine("5：输出所有男友信息");
                    Console.WriteLine("6：退出程序\n");
                    string str_1 = Console.ReadLine();

                    try
                    {
                        int n = int.Parse(str_1);   // 字符串转为数字可能会出错
                        switch (n)
                        {
                            case 1:   // 新建男友

                                Console.Write("请输入男友姓名：");
                                string name = Console.ReadLine();
                                Console.Write("请输入相识日期 (格式为: 年,月,日)：");
                                string dateStr = Console.ReadLine();
                                DateTime date = DateTime.Parse(dateStr);
                                Console.Write("请输入恋爱时长：");
                                string dayStr = Console.ReadLine();
                                int day = int.Parse(dayStr);

                                if (m.addBoyfriend(name, date, day))
                                    Console.WriteLine("恭喜您！添加成功！");
                                else Console.WriteLine("您的男友已满，添加失败！");
                                break;

                            case 2:   // 删除男友

                                if (m.Number == 0)
                                {
                                    Console.WriteLine("好惨一个人，你还没有男朋友！");
                                    break;
                                }
                                Console.Write("请输入需要删除的男友姓名：");
                                string name_delete = Console.ReadLine();
                                for (int i = 1; i <= m.Number; i++)
                                {
                                    if (m.Bfs[i].Name == name_delete)
                                    {
                                        m.Bfs[i] = m.Bfs[m.Number];
                                        if (m.deleteBoyfriend(name_delete))
                                        {
                                            Console.WriteLine("已成功删除！");
                                            break;
                                        }
                                    }
                                    if (i == m.Number) Console.WriteLine("未找到该男友，删除失败！");
                                }
                                break;

                            case 3:   // 修改男友信息

                                if (m.Number == 0)
                                {
                                    Console.WriteLine("好惨一个人，你还没有男朋友！");
                                    break;
                                }
                                Console.Write("请输入需要更改信息的男友姓名：");
                                string name_change = Console.ReadLine();
                                for (int i = 1; i <= m.Number; i++)
                                {
                                    if (m.Bfs[i].Name == name_change)
                                    {
                                        Console.WriteLine("请重新输入您要更改的信息：");
                                        Console.WriteLine("1：姓名");
                                        Console.WriteLine("2：相识日期");
                                        Console.WriteLine("3：恋爱时长\n");
                                        string str_2 = Console.ReadLine();
                                        int p = int.Parse(str_2);
                                        switch (p)
                                        {
                                            case 1:   // 更改男友姓名
                                                Console.Write("请重新输入男友姓名：");
                                                name = Console.ReadLine();
                                                m.Bfs[i].Name = name;
                                                Console.WriteLine("更改成功！");
                                                break;

                                            case 2:   // 更改相识日期
                                                Console.Write("请重新输入相识日期 (格式为: 年,月,日)：");
                                                dateStr = Console.ReadLine();
                                                date = DateTime.Parse(dateStr);
                                                m.Bfs[i].Date = date;
                                                Console.WriteLine("更改成功！");
                                                break;

                                            case 3:   // 更恋爱时长
                                                Console.Write("请重新输入恋爱时长：");
                                                dayStr = Console.ReadLine();
                                                day = int.Parse(dayStr);
                                                m.Bfs[i].Day = day;
                                                Console.WriteLine("更改成功！");
                                                break;

                                            default:
                                                Console.WriteLine("您输入的数据有误，该次操作终止！\n");
                                                break;
                                        }
                                        break;
                                    }
                                    if (i == m.Number) Console.WriteLine("未找到该男友，更改失败！");
                                }
                                break;

                            case 4:   // 给男友排序

                                if (m.Number == 0)
                                {
                                    Console.WriteLine("好惨一个人，你还没有男朋友！");
                                    break;
                                }
                                Console.WriteLine("请输入您的排序方式：");
                                Console.WriteLine("1：姓名（升序）");
                                Console.WriteLine("2：相识日期（降序）");
                                Console.WriteLine("3：恋爱时长（降序）\n");
                                string str_3 = Console.ReadLine();
                                int q = int.Parse(str_3);

                                Boyfriend t = new Boyfriend("交换", DateTime.Now, 0);
                                int j, k, index, r;
                                r = m.Number;

                                switch (q)
                                {
                                    case 1:   // 按男友姓名排序     
                                        for(j = 1; j < r; j++)
                                        {
                                            index = j;
                                            for (k = j + 1; k <= r; k++)
                                                if (string.Compare(m.Bfs[k].Name, m.Bfs[index].Name) == -1) index = k;
                                                /* string.Compare(str1, str2) 方法：通过逐个比较字符串中字符的 Unicode 值以判断大小
                                                 * 其返回值：[1] str1 > str2；[0] str1 = str2；[-1] str1 < str2 */
                                            t = m.Bfs[index]; m.Bfs[index] = m.Bfs[j]; m.Bfs[j] = t;
                                        }
                                        Console.WriteLine("排序完成！");
                                        break;

                                    case 2:   // 按相识日期排序     
                                        for (j = 1; j < r; j++)
                                        {
                                            index = j;
                                            for (k = j + 1; k <= r; k++)
                                                if (m.Bfs[k].Date > m.Bfs[index].Date) index = k;
                                            t = m.Bfs[index]; m.Bfs[index] = m.Bfs[j]; m.Bfs[j] = t;
                                        }
                                        Console.WriteLine("排序完成！");
                                        break;

                                    case 3:   // 按恋爱时长排序     
                                        for (j = 1; j < r; j++)
                                        {
                                            index = j;
                                            for (k = j + 1; k <= r; k++)
                                                if (m.Bfs[k].Day > m.Bfs[index].Day) index = k;
                                            t = m.Bfs[index]; m.Bfs[index] = m.Bfs[j]; m.Bfs[j] = t;
                                        }
                                        Console.WriteLine("排序完成！");
                                        break;

                                    default:
                                        Console.WriteLine("您输入的数据有误，该次操作终止！\n");
                                        break;
                                }
                                break;

                            case 5:   // 输出所有男友信息

                                if (m.Number == 0)
                                {
                                    Console.WriteLine("好惨一个人，你还没有男朋友！");
                                    break;
                                }
                                Console.WriteLine("您当前一共有 " + m.Number + " 个男友。分别是：");
                                for (int i = 1; i <= m.Number; i++)
                                {
                                    Console.Write("第{0}位男友信息：", i);
                                    Console.WriteLine("名字：{0}   相识日期：{1}年{2}月{3}日   恋爱时长：{4}",
                                        m.Bfs[i].Name, m.Bfs[i].Date.Year, m.Bfs[i].Date.Month, m.Bfs[i].Date.Day, m.Bfs[i].Day);
                                }
                                break;

                            case 6:   // 退出程序

                                Environment.Exit(0);   // 退出整个程序
                                break;

                            default:
                                Console.WriteLine("您输入的数据有误，该次操作终止！\n");
                                break;
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("您输入的数据有误，该次操作终止！");
                    }
                }
            }
        }
    }
}
