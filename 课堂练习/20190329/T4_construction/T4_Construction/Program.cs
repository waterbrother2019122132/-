using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower[] fls = new Flower[3];
            
            // 输入信息
            for (int i = 0; i < fls.Length; i++)
            {
                Console.Write("请输入第{0}朵花的名字：", i+1);
                string name = Console.ReadLine();

                Console.Write("请输入这朵花的产地：");
                string place = Console.ReadLine();

                if (place == "")
                    fls[i] = new Flower(name);
                else
                    fls[i] = new Flower(name, place);

                Console.Write("请输入这朵花的评分：");
                string scoreStr = Console.ReadLine();
                double score = double.Parse(scoreStr);
                fls[i].Score = score;

                Console.WriteLine("");
            }

            // 点赞
            for (int i = 0; i < 2; i++) 
                Flower.praise();
            Console.WriteLine("");

            // 根据评分进行排序：选择排序法
            Flower t = new Flower("交换");
            int j, k, index, n;
            n = fls.Length;
            for (j = 0; j < n - 1; j++)
            {
                index = j;
                for (k = j + 1; k < n; k++) if (fls[k].Score > fls[index].Score) index = k;
                t = fls[index]; fls[index] = fls[j]; fls[j] = t;
            }
            
            // 输出
            for (int i = 0; i < fls.Length; i++)
                Console.WriteLine("第{0}名：{1}，评分为{2}。", i+1, fls[i].Name, fls[i].Score);

            Console.ReadLine();
        }
    }
}
