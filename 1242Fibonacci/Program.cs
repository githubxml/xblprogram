using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1242Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the num {0}", num);
            //Console.WriteLine(Fibonacci(num));
            Console.WriteLine(Fibonacci2(num));
        }
        static int Fibonacci(int n)
        {
            if (n==1||n==2)
            {
                return 1;
            }
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
            
        }
        static int Fibonacci2(int n)
        {
            int[] fibArrary= new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i==0 || i==1)
                {
                    fibArrary[i] = 1;
                }
                else
                {
                    fibArrary[i] = fibArrary[i - 1] + fibArrary[i - 2];
                }                
            }
            return fibArrary[n - 1];
        }
    }
}
