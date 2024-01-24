using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascal_alghoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                List<int> list2 = new List<int>();
                list2.Add(1);
                for (int j = 0; j <= list1.Count - 1; j++)
                {
                    list2.Add(list1[j] + list1[j + 1]);
                }
                list2.Add(1);
                foreach (var item in list1)
                {
                    Console.WriteLine(item + " ");
                }
                list1 = list2;
                Console.WriteLine();
            }
        }
    }
}
