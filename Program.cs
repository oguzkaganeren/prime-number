using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)//example
            {
                Console.WriteLine(findPrime());
                System.Threading.Thread.Sleep(500);
            }
            Console.Read();
        }
        public static int primeNumber = 2;
        public static int findPrime()
        {
            for (int i = primeNumber; i > -1; i++)
            {
                int count = 0;
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    primeNumber = i + 1;
                    return (i);
                }
                else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count < 2)
                    {
                        primeNumber = i + 1;
                        return (i);
                    }
                }
            }
            return primeNumber;
        }
    }
}
