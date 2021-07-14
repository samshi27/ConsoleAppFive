using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFive
{
    public class SwapNumber
    {
        public void DoSwap()
        {
            int a, b;
            Console.Write("Enter integer 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter integer 2: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Elements before swap:\na = " + a + "\nb = " + b);

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("Elements after swap:\na = " + a + "\nb = " + b);
        }

    }
}
