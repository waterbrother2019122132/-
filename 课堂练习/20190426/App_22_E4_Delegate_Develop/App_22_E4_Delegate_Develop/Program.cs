using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_22_E4_Delegate_Develop
{
    public delegate void sayDelegate(string name);            // 将委托声明放在 class Program 外面。
    class Program
    {
        public static void chineseSay(string name)
        {
            Console.WriteLine("我爱你，{0}！", name);
        }
        public static void englishSay(string name)
        {
            Console.WriteLine("I love you, {0}!", name);
        }

        static void Main(string[] args)
        {
            Love love = new Love();                           // 声明 Love 类的对象并实例化。

            love.say3 += chineseSay;                          // 使用“对象.变量”的格式访问 say3。由于 say3 更改为事件，此时操作符应变为“+=”。
            love.say3 += englishSay;
            love.showLove("妮妮");                            // 多播之后仍可使用“对象.方法”的格式调用 showLove。

            Console.ReadLine();
        }
    }
}
