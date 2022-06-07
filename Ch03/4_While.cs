using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    internal class _4_While
    {
        static void Main(string[] args)
        {
            //1부터 10까지의 합
            int sum = 0;
            int i = 1;

            while(i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);

            //do - while
            int total = 0;
            int j = 1;

            do
            {
                if (j % 2 == 0) total += j;
                j++;
            }
            while (j <= 10);

            Console.WriteLine(total);

            //break
            int num = 1;
            while (true)
            {
                if(num % 5 == 0 && num % 7 == 0)
                {
                    break;
                }

                num++;
            }

            Console.WriteLine($"5와 7의 최소공배수: {num}");

            //continue
            int total2 = 0;
            int j = 1;
            while (j <= 10)
            {
                if(j % 2 == 1)
                {
                    continue;
                }

                total += j;
            }
        }
    }
}
