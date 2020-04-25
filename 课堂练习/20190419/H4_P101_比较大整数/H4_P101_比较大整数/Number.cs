using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_P101_比较大整数
{
    class Number
    {
        int judgement = 2;
        int[] num = new int[101];
        int length;
        string big_num_str;

        public Number(string big_num_str_enter)
        {
            big_num_str = big_num_str_enter.Replace(" ", "");
            big_num_str = big_num_str.Replace(",", "");
            if (big_num_str.Length > 101) judgement = 0;
            if (big_num_str.Length == 0) judgement = 0;
            if (judgement != 0)
            {
                char pos_char = big_num_str[0];
                if (pos_char == '-') judgement = -1;
                else if (pos_char == '+' || (pos_char >= '0' && pos_char <= '9')) judgement = 1;
                else judgement = 0;
                if (pos_char >= '0' && pos_char <= '9' && big_num_str.Length > 100) judgement = 0;
                for (int i = 1; i < big_num_str.Length; i++)
                {
                    pos_char = big_num_str[i];
                    if (pos_char < '0' || pos_char > '9') judgement = 0;
                }
            }
            if (judgement != 0)
            {
                big_num_str = big_num_str.TrimStart('+', '-');
                length = big_num_str.Length;
                for (int i = 0; i < num.Length; i++) num[i] = 0;
                for (int i = 0; i < big_num_str.Length; i++) num[100 - i] = big_num_str[length - i - 1] - '0';
            }
        }
        public int Judgement { get { return judgement; } set { } }
        public int[] Num { get { return num; } set { } }
        public int Length { get { return length; } set { } }
    }
}
