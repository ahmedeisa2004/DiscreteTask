using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int n1, n2;
            Console.Write("Enter The First Number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Number : ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("The Perfect numbers between {0} and {1} are : \n",n1,n2);
            for (n = n1; n <= n2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            Console.ReadLine();
        }
    }
}
