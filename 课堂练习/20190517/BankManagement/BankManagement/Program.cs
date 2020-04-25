using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Manage m = new Manage();
                for (; ; )
                {
                    Console.WriteLine("\n***********【银行账户管理系统】***********");
                    Console.WriteLine("请选择以下操作：");
                    Console.WriteLine("[1] 创建新账户\n[2] 注销账户\n[3] 取钱\n[4] 存钱\n[5] 使用账户编号查询账户信息\n[6] 退出系统\n");

                    string str_1 = Console.ReadLine();

                    try
                    {
                        int choose_1 = int.Parse(str_1);
                        switch (choose_1)
                        {
                            case 1:   // 创建新账户
                                Console.Write("请输入账户编号：");
                                string idnumStr = Console.ReadLine();
                                int idnum = int.Parse(idnumStr);

                                // 判断账户编号是否重复
                                int flag = 0;
                                for (int i = 0; i < Person.Num; i++)
                                {
                                    if (m.People[i].Idnum == idnum) 
                                    {
                                        flag = 1; 
                                        Console.WriteLine("账户编号重复，本次操作终止！");
                                        break;
                                    }
                                }
                                for (int i = 0; i < VIPPerson.Num; i++)
                                {
                                    if (m.VIPPeople[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.WriteLine("账户编号重复，本次操作终止！");
                                        break;
                                    }
                                }
                                if (flag == 1) break;

                                Console.Write("请输入账户姓名：");
                                string name = Console.ReadLine();
                                Console.Write("请输入存入账户金额：");
                                string moneyStr = Console.ReadLine();
                                double money = double.Parse(moneyStr);

                                if (money >= 20000)
                                {
                                    Console.Write("请输入创建账户时间 (格式为：年,月,日)：");
                                    string dateStr = Console.ReadLine();
                                    DateTime date = DateTime.Parse(dateStr);

                                    m.VIPPeople[VIPPerson.Num] = new VIPPerson(idnum, name, money, date);
                                    VIPPerson.Num++;
                                    Console.WriteLine("添加 VIP 账户成功！");
                                }
                                else if (money > 0)
                                {
                                    m.People[Person.Num] = new Person(idnum, name, money);
                                    Person.Num++;
                                    Console.WriteLine("添加普通账户成功！");
                                }
                                else Console.WriteLine("输入的金额必须大于 0，添加账户失败，本次操作终止！");
                                break;

                            case 2:   // 注销账户
                                Console.WriteLine("请选择注销的账户的方式：");
                                Console.WriteLine("[1] 通过输入账户 编号 注销账户\n[2] 通过输入账户 姓名 注销账户\n");
                                string str_2 = Console.ReadLine();
                                int choose_2 = int.Parse(str_2);
                                switch (choose_2)
                                {
                                    case 1:   // 通过输入账户 编号 注销账户
                                        Console.Write("请输入您需要注销账户的编号：");
                                        idnumStr = Console.ReadLine();
                                        idnum = int.Parse(idnumStr);
                                        flag = 0;
                                        for (int i = 0; i <= Person.Num; i++)
                                        {
                                            if (m.People[i].Idnum == idnum) 
                                            {
                                                flag = 1;
                                                m.People[i] = m.People[Person.Num];
                                                m.People[Person.Num] = null;
                                                Person.Num--;
                                                Console.WriteLine("注销成功！");
                                                break;
                                            }
                                        }
                                        for (int i = 0; i <= VIPPerson.Num; i++)
                                        {
                                            if (m.VIPPeople[i].Idnum == idnum)
                                            {
                                                flag = 1;
                                                m.VIPPeople[i] = m.VIPPeople[VIPPerson.Num];
                                                m.VIPPeople[VIPPerson.Num] = null;
                                                VIPPerson.Num--;
                                                Console.WriteLine("注销成功！");
                                                break;
                                            }
                                        }
                                        if (flag == 0) Console.WriteLine("未找到该账户，本次操作终止！");
                                        break;

                                    case 2:   // 通过输入账户 姓名 注销账户
                                        Console.Write("请输入您需要注销账户的姓名：");
                                        name = Console.ReadLine();
                                        flag = 0;
                                        for (int i = 0; i <= Person.Num; i++)
                                        {
                                            if (m.People[i].Name == name) 
                                            {
                                                flag = 1;
                                                m.People[i] = m.People[Person.Num];
                                                m.People[Person.Num] = null;
                                                Person.Num--;
                                                Console.WriteLine("注销成功！");
                                                break;
                                            }
                                        }
                                        for (int i = 0; i <= VIPPerson.Num; i++)
                                        {
                                            if (m.VIPPeople[i].Name == name)
                                            {
                                                flag = 1;
                                                m.VIPPeople[i] = m.VIPPeople[VIPPerson.Num];
                                                m.VIPPeople[VIPPerson.Num] = null;
                                                VIPPerson.Num--;
                                                Console.WriteLine("注销成功！");
                                                break;
                                            }
                                        }
                                        if (flag == 0) Console.WriteLine("未找到该账户，本次操作终止！");
                                        break;

                                    default:
                                        Console.WriteLine("您输入的数据有误，本次操作终止！");
                                        break;
                                }
                                break;

                            case 3:   // 取钱
                                Console.Write("请输入您的账户编号：");
                                idnumStr = Console.ReadLine();
                                idnum = int.Parse(idnumStr);
                                flag = 0;
                                for (int i = 0; i <= Person.Num; i++)
                                {
                                    if (m.People[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.Write("请输入您需要取走的金额：");
                                        moneyStr = Console.ReadLine();
                                        money = double.Parse(moneyStr);
                                        if (money <= m.People[i].Money)
                                        {
                                            m.People[i].Money = m.People[i].Money - money;
                                            Console.WriteLine("取款成功！");
                                        }
                                        else Console.WriteLine("账户余额不足，取款失败！");
                                        break;
                                    }
                                }
                                for (int i = 0; i <= VIPPerson.Num; i++)
                                {
                                    if (m.VIPPeople[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.Write("请输入您需要取走的金额：");
                                        moneyStr = Console.ReadLine();
                                        money = double.Parse(moneyStr);
                                        if (money <= m.VIPPeople[i].Money + 5000)
                                        {
                                            m.VIPPeople[i].Money = m.VIPPeople[i].Money - money;
                                            Console.WriteLine("取款成功！");
                                        }
                                        else Console.WriteLine("账户余额不足，取款失败！");
                                        break;
                                    }
                                }
                                if (flag == 0) Console.WriteLine("未找到该账户，本次操作终止！");
                                break;

                            case 4:   // 存钱
                                Console.Write("请输入您的账户编号：");
                                idnumStr = Console.ReadLine();
                                idnum = int.Parse(idnumStr);
                                flag = 0;
                                for (int i = 0; i <= Person.Num; i++)
                                {
                                    if (m.People[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.Write("请输入您需要存入的金额：");
                                        moneyStr = Console.ReadLine();
                                        money = double.Parse(moneyStr);
                                        m.People[i].Money = m.People[i].Money + money;
                                        Console.WriteLine("存款成功！");
                                        break;
                                    }
                                }
                                for (int i = 0; i <= VIPPerson.Num; i++)
                                {
                                    if (m.VIPPeople[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.Write("请输入您需要存入的金额：");
                                        moneyStr = Console.ReadLine();
                                        money = double.Parse(moneyStr);
                                        m.VIPPeople[i].Money = m.VIPPeople[i].Money + money;
                                        Console.WriteLine("存款成功！");
                                        break;
                                    }
                                }
                                if (flag == 0) Console.WriteLine("未找到该账户，本次操作终止！");
                                break;

                            case 5:   // 使用账户编号查询账户信息
                                Console.Write("请输入您的账户编号：");
                                idnumStr = Console.ReadLine();
                                idnum = int.Parse(idnumStr);
                                flag = 0;
                                for (int i = 0; i <= Person.Num; i++)
                                {
                                    if (m.People[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.WriteLine("账户类型：普通账户");
                                        Console.WriteLine("账户编号：{0}", m.People[i].Idnum);
                                        Console.WriteLine("账户姓名：{0}", m.People[i].Name);
                                        Console.WriteLine("账户余额：{0}", m.People[i].Money);
                                        break;
                                    }
                                }
                                for (int i = 0; i <= VIPPerson.Num; i++)
                                {
                                    if (m.VIPPeople[i].Idnum == idnum)
                                    {
                                        flag = 1;
                                        Console.WriteLine("账户类型：VIP 账户"); 
                                        Console.WriteLine("账户编号：{0}", m.VIPPeople[i].Idnum);
                                        Console.WriteLine("账户姓名：{0}", m.VIPPeople[i].Name);
                                        Console.WriteLine("账户余额：{0}", m.VIPPeople[i].Money);
                                        Console.WriteLine("账户创建日期：{0}年{1}月{2}日",
                                            m.VIPPeople[i].Date.Year, m.VIPPeople[i].Date.Month, m.VIPPeople[i].Date.Day);
                                        break;
                                    }
                                }
                                if (flag == 0) Console.WriteLine("未找到该账户，本次操作终止！");
                                break;

                            case 6:   // 退出系统
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("您输入的数据有误，本次操作终止！");
                                break;
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
