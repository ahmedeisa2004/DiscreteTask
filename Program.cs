using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, n1, n2;
            Console.Write("enter the first number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", n1, n2);

            for (num = n1; num <= n2; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.WriteLine("{0} ", num);
            }

            Console.ReadLine();
        }
    }
}
