using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_24_EG_4_6_比较学生成绩
{
    class Program
    {
        // 声明委托类型，它可以关联静态方法 student.max() 和 student.min()
        delegate object xnDelegate(object o1, object o2);

        // 以委托作为参数，定义方法 fun()，以求 st1 和 st2 中成绩较好或较差的学生
        static student fun(student st1, student st2, xnDelegate fxn)
        {
            return (student)fxn(st1, st2);
        }

        static void Main(string[] args)
        {
            // 创建学生对象数组
            student[] sts = {                                 
                new student("罗振武",90),
                new student("蒙舒意",100),
                new student("李丽",80),
                new student("周芷",60),
                new student("王惠",70), };

            // 创建委托对象 mx，关联静态方法 student.max 
            xnDelegate mx = new xnDelegate(student.max);

            // 创建委托对象 mn，关联静态方法 student.min 
            xnDelegate mn = new xnDelegate(student.min);

            student maxst, minst;
            maxst = minst = sts[0];
            sts[0].showInfo();

            // 利用 fun() 方法求成绩最好的学生和成绩最差的学生
            for (int i = 1; i < sts.Length; i++)  
            {
                sts[i].showInfo();
                maxst = fun(maxst, sts[i], mx);
                minst = fun(minst, sts[i], mn);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("成绩最好的学生：");
            maxst.showInfo();

            Console.WriteLine("-------------------------");
            Console.WriteLine("成绩最差的学生：");
            minst.showInfo();

            Console.ReadLine();
        }
    }
}
