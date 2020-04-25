using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_17_静态方法和变量
{
    class Girlfriend
    {
        static int count;                       // count 值默认为 0
        string name;

        public Girlfriend(string name) {        // 构造函数
            this.name = name;
            count++;
        }
        public void show() {                    // 非静态方法
            Console.WriteLine("当前女友名字是{0}，迄今为止共有女朋友{1}个。", name, count);
        }
        public static void showCount() {        // 静态方法
            Console.WriteLine("迄今为止共有女朋友{0}个。", count);
        }
    }
}
