using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_21_E4_Delegate
{
    class Program
    {
        public delegate void sayDelegate(string name);

     /* 建立了一个“sayDelegate”类型的函数。委托(代理)是一种特殊的类，用于给函数定义类型。
      * 声明了委托 sayDelegate，该委托可以与所有以参数列表为“string name”的函数相关联，即可以作为这些函数的代理。
      * 特征：使用关键字“delegate”，返回值是 void，(在本程序中)只有一个 string 类型的参数。*/
        
        public static void chineseSay(string name)
        {
            Console.WriteLine("我爱你，{0}！", name);
        }
        public static void englishSay(string name)
        {
            Console.WriteLine("I love you, {0}!", name);
        }

     /* 原 showLove 函数：
        public static void showLove(int language, string name)
        {
            if (language == 1) chineseSay(name);
            else englishSay(name);
        }
      
      * 原主函数：
        static void Main(string[] args)
        {
            showLove(1, "贝贝");
            showLove(2, "JingJing");
            Console.ReadLine();
        }                               */

        public static void showLove(sayDelegate say, string name)       // 使用委托重新定义函数，在新函数中使用函数作为新函数的参数。
        {
            say(name);
        }

        static void Main(string[] args)
        {
            showLove(chineseSay, "贝贝");
            showLove(englishSay, "JingJing");

            sayDelegate say1;                                           // 委托变量的声明和实例化
            say1 = chineseSay;                                          // say1 是 chineseSay 的委托
            sayDelegate say2 = new sayDelegate(englishSay);             // say2 是 englishSay 的委托

            say1("欢欢");                                               // 两种输出方法
            showLove(say2, "YingYing");

            sayDelegate say3;                                           // 委托的组合（多播）：同时将 chineseSay 和 englishSay 注册给 say3
            say3 = chineseSay;
            say3 += englishSay;                                         // 将 englishSay 注册到委托变量 say3 上
            say3("妮妮");

            say3 -= chineseSay;                                         // 将 chineseSay 在委托变量 say3 上注销
            say3("妮妮");

            Console.ReadLine();
        }
    }
}
