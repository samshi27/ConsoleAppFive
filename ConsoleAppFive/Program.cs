using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            while (true)
            {
                Console.WriteLine("Press 1 to check for armstrong number");
                Console.WriteLine("Press 2 to check for palindrome number");
                Console.WriteLine("Press 3 for fibonacci series");
                Console.WriteLine("Press 4 to swap two integers");
                Console.WriteLine("Press 5 to convert a decimal to binary");
                Console.WriteLine("Enter 6 to exit");
                Console.Write("Your choice: ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ArmstrongNumber armstrong = new ArmstrongNumber();
                        armstrong.IsArmstrong();
                        Console.WriteLine();
                        break;
                    case 2:
                        PalindromeNumber palindrome = new PalindromeNumber();
                        palindrome.IsPalindrome();
                        break;
                    case 3:
                        SeriesFibonacci fibonacci = new SeriesFibonacci();
                        fibonacci.FibonacciSeries();
                        Console.WriteLine();
                        break;
                    case 4:
                        SwapNumber swap = new SwapNumber();
                        swap.DoSwap();
                        Console.WriteLine();
                        break;
                    case 5:
                        DecimalBinary DecBi = new DecimalBinary();
                        DecBi.DecimalToBinary();
                        Console.WriteLine();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

            }
        }
    }
}
