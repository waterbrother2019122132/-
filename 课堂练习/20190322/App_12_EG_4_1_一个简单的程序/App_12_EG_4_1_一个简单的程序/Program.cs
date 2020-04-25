using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_12_EG_4_1_一个简单的程序
{
    class Complex                               // 定义一个虚数类，类的名称首字母要求大写
    {                                           //“类”中的内容用大括号括起来，“类”中有函数、有变量
        private double RP; 	                	// 私有成员变量“RP”和“IP”，分别表示虚数的实部和虚部
        private double IP;
        public double getRP() { return RP; }    // 定义一个函数：成员方法“getRP()”：用于获取虚数的实部，下同理
        public double getIP() { return IP; }
        public Complex()                        // 不带参数的构造函数：Complex，和类重名，无返回值，当调用该构造函数创建虚数对象时，实部和虚部均为0 

        {
            RP = IP = 0;
        }
        public Complex(double RP, double IP)    /*“类”中可以定义多个重名函数，但是要求参数的个数不同或参数的类型不同。有多个重名函数的现象称为“函数重载”。
                                                 * 当调用该构造函数创建虚数对象时，实部和虚部的值分别由参数RP和IP来设定 */
        {
            this.RP = RP;                       // 当函数参数与成员变量重名时，要通过关键字“this”来应用成员变量，“this”代表当所创建的对象。
            this.IP = IP;
        }
        public static Complex operator +(Complex c1, Complex c2)    // 加号“+”重载（二元运算符重载）：重新定义“+”的功能（“operator”是一个关键字），使得两个虚数对象可以相加
        {
            Complex c = new Complex(c1.RP + c2.RP, c1.IP + c2.IP);
            return c;
        }

        public static Complex operator -(Complex c)                 // 对取反符号“-”重载（一元运算符重载）：重新定义一元运算符“-”的功能，当调用此运算符时，虚数的实部和虚部将被取反
        {
            Complex c2 = new Complex(-c.RP, -c.IP);
            return c2;
        }
        public static Complex operator -(Complex c1, Complex c2)    // 对减号“-”重载（二元运算符重载）：重新定义二元运算符“-”的功能，使得两个虚数对象可以相减
        {
            Complex c = new Complex(c1.RP - c2.RP, c1.IP - c2.IP);
            return c;
        }
        public static implicit operator Complex(string s)           // 实现隐式类型转换（从 string 到 Complex），使得可以对虚数对象赋一个表示虚数的字符串
        {
            s = s.Trim().TrimEnd('i');
            s = s.Trim().TrimEnd('*');
            string[] digits = s.Split('+', '-');
            Complex c;
            c=new Complex(Convert.ToDouble(digits[0]), Convert.ToDouble(digits[1]));           
            return c;
        }
        public void putIN()                     // 成员方法“putIN()”：用于从屏幕上输出一个虚数
        {
            Console.WriteLine("{0} + {1}*i", RP, IP);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();         // 调用不带参数的构造函数创建虚数对象 c1
            Complex c2 = new Complex(1, 2);     // 调用带参数的构造函数创建虚数对象 c2
            Console.Write("c1 = "); c1.putIN();
            Console.Write("c2 = "); c2.putIN();
            Complex c3;
            c3 = "100+200*i";                   // 通过隐式转换对c3赋值
            Console.Write("c3 = "); c3.putIN();
            Complex c4;
            c4 = c2 - c1 + (-c3);               // 对对象进行加减运算
            Console.Write("c4 = "); c4.putIN();
            Console.ReadLine();
        }
    }
}
