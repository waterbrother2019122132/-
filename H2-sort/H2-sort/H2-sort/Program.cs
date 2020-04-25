using System;

namespace SelectionSorter
{
    public class SelectionSorter
    {
        private int min;
        public void Sort(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                        min = j;
                }
                int t = list[min];
                list[min] = list[i];
                list[i] = t;
            }
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            int[] iArrary = new int[10] ; 
            Console.WriteLine("Input 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                iArrary[i] = int.Parse(Console.ReadLine());
            }
            SelectionSorter ss = new SelectionSorter();
            ss.Sort(iArrary);
            for (int m = 0; m < iArrary.Length; m++)
                Console.Write("{0} ", iArrary[m]);
            Console.WriteLine();
        }
    }
}