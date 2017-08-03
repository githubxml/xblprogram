using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace inversion1019
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int n = int.Parse(Console.ReadLine());
            int[] allint = new int[n];
            int inversionAccount = 0;
            int min=0;

            for (int i = 0; i < n; i++)
            {
                allint[i] = int.Parse(Console.ReadLine());
                min = allint[0];
                if ((min > allint[i]) || (i != 0))
                {
                    min = allint[i];
                }
            }

            Console.WriteLine("The min number is {0}", min);

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (allint[i]==min)
                    {
                        break;
                    }
                    if (allint[i]>allint[j])
                    {
                        inversionAccount++;
                    }
                }

            }
            Console.WriteLine(inversionAccount);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds.ToString());
        }
    }
}
