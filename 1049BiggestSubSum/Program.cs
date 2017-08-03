using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1049BiggestSubSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Int64> li = new List<Int64>();
            Int64 max = 0;
            //Console.WriteLine("Enter the account of the integers.");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] maxArrary = new int[num];
            for (int i = 1; i <= num; i++)
            {
                li.Add(Convert.ToInt64(Console.ReadLine()));
            }

            for (int i = 0; i < num ; i++)
            {
                Int64 temp = 0;
                //Console.WriteLine("======");
                for (int j = i; j < num ; j++)
                {
                    temp += li[j];
                    if (max < temp)
                    {
                        max = temp;
                    }
                    //Console.WriteLine(temp);
                }
                //Console.WriteLine("======");
            }

            Console.WriteLine(max);

        }
    }
}
