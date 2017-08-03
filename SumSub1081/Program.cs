using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSub1081
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> li = new List<int>();
            Dictionary<int, int> di = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                 li.Add(int.Parse(Console.ReadLine()));
            }

            int nQuery= Convert.ToInt32(Console.ReadLine());
            int[,] count=new int[nQuery,2];
            for (int i = 0; i < nQuery; i++)
            {
                string s = Console.ReadLine();
                string[] sArrary = s.Split(' ');
                count[i, 0] = int.Parse(sArrary[0]);
                count[i, 1] = int.Parse(sArrary[1]);
            }

            for (int i = 0; i < nQuery; i++)
            {
                Console.WriteLine(sumResult(li, count[i, 0], count[i, 1])); 
            }            

        }

        static int sumResult(List<int> ls, int start, int offset)
        {
            int result = 0;
            for (int i = start-1; i < start-1+offset; i++)
            {
                result += ls[i];
            }
            return result;
        }
    }


}
