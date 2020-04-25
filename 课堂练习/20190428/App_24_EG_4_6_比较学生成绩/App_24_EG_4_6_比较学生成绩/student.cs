using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_24_EG_4_6_比较学生成绩
{
    class student
    {
        string name;   // 姓名
        double score;   // 成绩
        public student(string name, double score)   // 定义构造函数，以初始化姓名和成绩
        {
            this.name = name;
            this.score = score;
        }
        public void showInfo()   // 显示学生信息
        { Console.WriteLine("姓名：{0}，\t成绩：{1}", name, score.ToString()); }
        
        public static object max(object obj1, object obj2)   // 求最大者（静态方法）
        {
            student st1 = (student)obj1;
            student st2 = (student)obj2;
            if (st1.score > st2.score) return st1;
            return st2;
        }

        public static object min(object obj1, object obj2)   // 求最小者（静态方法）
        {
            student st1 = (student)obj1;
            student st2 = (student)obj2;
            if (st1.score > st2.score) return st2;
            return st1;
        }
    }
}
