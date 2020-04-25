using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_20_EG_4_1_学习
{
    class Complex
    {
        double RP, IP;
        public Complex(double RP, double IP)
        {
            this.RP = RP;
            this.IP = IP;
        }
        public Complex()
        {
            IP = RP = 0;
        }
        public static Complex operator +(Complex a, Complex b)      /* 加号“+”重载（二元运算符重载）：重新定义“+”的功能，使两个虚数对象可以相加
                                                                     * 第一个“Complex”意思是返回类型是一个“Complex类”的值
                                                                     * “operator”是一个关键字，它和运算符一起使用，表示一个运算符函数
                                                                     * 所有操作符想要重新定义的话，需使用静态函数 */
        {
            Complex c = new Complex();
            c.RP = a.RP + b.RP;
            c.IP = a.IP + b.IP;
            return c;
        }
        public static Complex operator -(Complex a, Complex b)      // 对减号“-”重载（二元运算符重载）：重新定义二元运算符“-”的功能，使两个虚数对象可以相减
        {
            Complex c = new Complex();
            c.RP = a.RP - b.RP;
            c.IP = a.IP - b.IP;
            return c;
        }
        public static Complex operator -(Complex a)                 // 对取反符号“-”重载（一元运算符重载）：重新定义一元运算符“-”的功能，使虚数的实部和虚部取反
        {
            Complex b = new Complex();
            b.RP = -a.RP;
            b.IP = -a.IP;
            return b;
        }
        public override string ToString()                           // 父类（object）中已经含有“ToString”这种虚函数了，需要用 override 重写虚函数
        {
            if (IP > 0) return RP.ToString() + "+" + IP.ToString() + "i";
            else if (IP < 0) return RP.ToString() + IP.ToString() + "i";
            else return RP.ToString();
        }

        public static implicit operator Complex(string str)         // “implicit”是隐式操作符类型转换关键字，“explicit”对应显示类型转换
        {
            str = str.Trim();                                       /* “.Trim”方法：去掉首末的某一个字符，此处去除空格
                                                                     * str 从“ -3 -4* i ”变为“-3 -4* i”*/
            str = str.TrimEnd('i');                                 /* “.TrimEnd”方法：去掉末尾的某一个字符
                                                                     * str 从“-3 -4* i”变为“-3 -4* ”*/
            str = str.Trim();                                       // str 从“-3 -4 *”变为“-3 -4*”
            str = str.TrimEnd('*');                                 // str 从“-3 -4*”变为“-3 -4”

            int pos1 = str.IndexOf("-");                            // 从前往后索引“-”号首次出现的位置，若无负号返回“-1”，如果负号出现在首位，则返回“0”
            int pos2 = str.LastIndexOf("-");                        // 从前往后索引“-”号最后出现的位置，若无负号返回“-1”
            
            /* 方法一：
            int pos3 = str.IndexOf("+");

            if (pos1 == 0) str = str.Trim('-');
            if (pos3 == 0) str = str.Trim('+'); */

            string[] p = str.Split('+','-');                        /* “.Split”方法：将字符串从某个字符两边分割开
                                                                     * 函数返回值从“5+6”变为“5”和“6”，将函数实部和虚部放在数组中 */
            string RPString = p[0];
            string IPString = p[1];

            // 方法二
            if (p[0] == "") 
            {
                RPString = p[1];
                IPString = p[2];
            }
            // 在该程序中，方法二和方法一都能起到忽略实数部分负号的作用

            double RPValue, IPValue;

            if (pos1 == 0) RPValue = -double.Parse(RPString);       // 如果 pos1==0 的话，即首符号为负号，说明实部为负数
            else RPValue = double.Parse(RPString);

            if (pos2 > 0) IPValue = -double.Parse(IPString);        // 如果 pos2>0 的话，说明后面有负号，虚部为负数
            else IPValue = double.Parse(IPString);

            Complex c = new Complex(RPValue, IPValue);
            return c;
        }
    }
}
