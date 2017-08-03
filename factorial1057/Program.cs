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

            int n = Convert.ToInt32(Console.ReadLine());
            ulong factorialResult = 1;
            for (int i = n; i 
                > 0; i--)
            {
                factorialResult = factorialResult * i;
            }
            Console.WriteLine(factorialResult);

        }
    }
}
