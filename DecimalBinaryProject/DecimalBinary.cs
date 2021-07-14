using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFive
{
    public class DecimalBinary
    {
        public void DecimalToBinary()
        {
            int n, i = 0;
            int[] res = new int[10];

            Console.Write("Enter a decimal number(without floating point): ");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                res[i] = n % 2;
                n /= 2;
                i++;
            }

            for(i = res.Length-1; i >= 0; i--)
            {
                Console.Write(res[i]);
            }

            Console.WriteLine();
        }
    }
}
