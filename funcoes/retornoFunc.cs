using System;
using System.Collections.Generic;
using System.Text;

namespace retornoFunc
{
    class RetornoFunc
    {
        static void Main(string[] args)
        {
            int res = somar(10, 20);
            Console.WriteLine(res);
            Console.ReadLine();
        }
            static int somar(int a, int b)
            {
                int res = a + b;
                return res;
            }
    }
}