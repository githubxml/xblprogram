using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome1088
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            char[] cArray = originalString.ToArray<char>();
            int maxLength = 0;
            int flag = 0;
            List<string> ls = new List<string>();
            int offset = 0;

            for (int i = 1; i < cArray.Length; i++)
            {
                for (int j = 1; j < cArray.Length; j++)
                {
                    if (((i-j)>=0)&&((j+i)<cArray.Length))
                    {
                        if ((cArray[i-j]==cArray[i+j])&&(2*j+1<cArray.Length)&&(cArray[i]!=cArray[i+1]))
                        {
                            flag = i;
                            offset = j;
                            if ((2 * j + 1)>maxLength)
                            {
                                maxLength = 2 * j + 1;
                                Console.WriteLine(maxLength);
                            }
                            
                            Console.WriteLine(cArray[i]);
                        }
                    }
                    else if ((cArray[i]==cArray[i+1])&&(cArray[i-j]==cArray[i+1+j])&&((2*j+2)<=cArray.Length))
                    {
                        
                        flag = i;
                        offset = j+1;
                        if ((2 * j + 1) > maxLength)
                        {
                            maxLength = 2 * j + 2;
                            Console.WriteLine(maxLength);
                        }

                        Console.WriteLine(cArray[i]);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            
            Console.WriteLine("the flag is {0}, and the maxLength is {1}, offset is {2}", flag, maxLength, offset);

            Console.WriteLine(originalString.Substring(flag-offset,flag+offset+1));
        }
    }
}
