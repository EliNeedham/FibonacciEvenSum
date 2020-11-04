using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("something");

            //have to find all the numbers in the fibonacci sequence under 4 million but then only add the even ones
            int sum = 0;
            int a = 1;
            int b = 1;
            int total = 0;
            while (sum <= 4000000)
            {
                sum = a + b;
                if (sum % 2 == 0)
                {
                    total += sum;
                }

                a = b;
                b = sum;
            }
            Console.WriteLine(total);

            int first = 1;
            int second = 1;
            int newTerm = 0;
            int sum1 = 0;

            while (newTerm <= 4000000)
            {
                newTerm = first + second;

                if (newTerm % 2 == 0)
                {
                    sum1 += newTerm;
                }

                first = second;
                second = newTerm;
            }

            Console.WriteLine("The answer is " + sum);
        }
    }
}
