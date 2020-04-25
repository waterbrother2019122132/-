using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_14_E4_object_Girlfriend类
{
    class Girlfriend
    {
        string name; /* ① */              // 数据私有（默认是 private）
        int date;
        int length;

        public void setName(string name)   /* ② */
                                           /* 操作公有（添加修饰符 public）
                                            * 函数一般遵循“驼峰式写法”：首单词小写，后面的单词首字母大写，中间不加空格和下划线
                                            * 这里的“name”是新建的局部变量 */
        {
            this.name = name;              /* 前者的“name”表示 ①：要想访问类中的“name”，需要用“this.name”指代，表示这个类中的变量“name”
                                            * 后者的“name”表示 ②：重名时，默认指代上面定义函数的局部变量“name”*/
        }
        public void setDate(int date) { this.date = date; }
        public void setLength(int length) { this.length = length; }

        public string getName() { return name; }
        public int getDate() { return date; }
        public int getLength() { return length; }
    }
}
