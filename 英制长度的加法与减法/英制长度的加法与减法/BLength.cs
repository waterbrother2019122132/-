using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 英制长度的加法与减法
{
    class BLength
    {
      public  double feet;
      public double inches;

      public BLength() { feet = inches = 0; }

        public BLength(double f, double i)
        {
            this.feet = f;
            this.inches = i;
        }
        public static BLength operator +(BLength b,BLength b1)//加法运算
        {
            BLength b2 = new BLength();
            b2.feet = b1.feet + b.feet;
            b2.inches = b1.inches + b.inches;
            if (b2.inches >= 12)
            {
                b2.feet = b2.feet+((int)b2.inches )/ 12;
                b2.inches = b2.inches % 12;
            }
            return b2;
        }

        public static BLength operator -(BLength b3, BLength b4)//减法运算
        {
            BLength b5 = new BLength();

            b5.feet = b3.feet - b4.feet;
            b5.inches = b3.inches - b4.inches; 
           return b5;
        }

        public static implicit operator BLength(string s)//类型转换
        {
           
            char []ch = "英尺".ToCharArray();
            char[] sh = "英寸".ToCharArray();
            s = s.Trim().TrimEnd(sh);
            string[] digits = s.Split(ch, StringSplitOptions.RemoveEmptyEntries);
            double a = double.Parse(digits[0]);
            double b = double.Parse(digits[1]);
            
            BLength b6 = new BLength(a,b);
            return b6;
        }
        
       
    }
}
