using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_P101_比较大整数_V2
{
    class Number
    {
        int judgement = 2;                                                                          // 当 judgement = 0 时，判断为不符合规范，结束程序
        int[] num = new int[101];
        int length;
        string big_num_str;

        public Number(string big_num_str_enter)
        {
            // ————————————————————————————————————————————————————————————————————————————————
            // 第一部分：处理数据
            big_num_str = big_num_str_enter.Replace(" ", "");                                       // 去除字符中的所有空格
            big_num_str = big_num_str.Replace(",", "");                                             // 去除字符中的所有逗号

            // ————————————————————————————————————————————————————————————————————————————————
            // 第二部分：判断数据
            if (big_num_str.Length > 101) judgement = 0;                                            // 当字符长度达到 101 位以上时，超出数字范围
            if (big_num_str.Length == 0) judgement = 0;

            if (judgement != 0)
            {
                // 对第一个字符进行判断
                char pos_char = big_num_str[0];
                if (pos_char == '-') judgement = -1;                                                // judgement = -1 时，数字为负值
                else if (pos_char == '+' || (pos_char >= '0' && pos_char <= '9')) judgement = 1;    // judgement = 1 时，数字为正值
                else judgement = 0;

                if (pos_char >= '0' && pos_char <= '9' && big_num_str.Length > 100) judgement = 0;  // 当首个字符已是数字，数字还达到 100 位以上时，超出数字范围

                // 对剩余字符进行判断
                for (int i = 1; i < big_num_str.Length; i++)
                {
                    pos_char = big_num_str[i];
                    if (pos_char < '0' || pos_char > '9') judgement = 0;
                }
            }

            if (judgement != 0)
            {
                // 去除符号数据，现在的字符串仅剩下数字
                big_num_str = big_num_str.TrimStart('+', '-');

                // ————————————————————————————————————————————————————————————————————————————
                // 第三部分：将字符数据存入整数数组
                length = big_num_str.Length;
                for (int i = 0; i < num.Length; i++) num[i] = 0;
                for (int i = 0; i < big_num_str.Length; i++) num[100 - i] = big_num_str[length - i - 1] - '0';
            }
        }

        public int Judgement
        {
            get { return judgement; }
            set { }
        }

        public int[] Num
        {
            get { return num; }
            set { }
        }

        public int Length
        {
            get { return length; }
            set { }
        }
    }
}
