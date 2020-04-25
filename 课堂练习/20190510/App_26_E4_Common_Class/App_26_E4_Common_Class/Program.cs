using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_26_E4_Common_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一、随机类 Random：非静态方法，需要新建一个随机变量后再使用方法
            
            Random rd = new Random();           // 新建一个随机变量 rd
            for (int i = 0; i < 10; i++)
            {
                int a = rd.Next();              // 产生一个随机的非负整数，这个数字是伪随机数，基于毫秒级的时间做种
                a = rd.Next(10);                // 产生一个小于 10 的非负整数，即范围是 0~10
                a = rd.Next(-10, 20);           // 产生一个属于 [-10, 20) 的整数，即范围是 -10~19

                double b = rd.NextDouble();     // 产生一个属于 (0, 1) 的浮点数

                Console.WriteLine("a = {0}\t b = {1}", a, b);
            }
            Console.WriteLine();

            // 二、数学类 Math：静态方法，直接使用

            for (int i = 0; i < 10; i++)
            {
                int r = rd.Next(0, 10);                     // 圆的半径
                double s = Math.PI * Math.Pow(r, 2);        // 圆的面积，通过 Math.PI 获取π的值，通过 Math.Power(x, y) 计算 x 的 y 次幂
                Console.WriteLine("r = {0}\t S = {1}", r, s);
            }
            Console.WriteLine();

            // 三、日期类 DateTime：非静态方法

            DateTime date = new DateTime(2017,2,14, 13,14,00,888);      // 新建一个日期类变量：年,月,日,时,分,秒,毫秒
            date = DateTime.Parse("2019,6,28, 16:20:00");               // 将字符串转化为 DateTime 类型
            date = DateTime.Now;                                        // 获取当前系统时间
            Girlfriend gf = new Girlfriend("现在", 100, date);
            
            gf.show();
            gf.addYear(3);
            gf.show();

            Console.Read();
        }
    }
}
