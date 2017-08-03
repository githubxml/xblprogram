using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51nod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lI = new List<int>();
            int account = int.Parse(Console.ReadLine());
            for (int i = 0; i < account; i++)
            {
                lI.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("============================");
            lI.Sort();
            foreach (int item in lI)
            {
                Console.WriteLine(item);
            }
        }
    }
}
