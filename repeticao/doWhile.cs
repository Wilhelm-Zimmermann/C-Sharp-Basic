using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace loop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int num = 10;
            // Primeiro faça depois veja a condiçao
            do
            {
                Console.WriteLine(num);
                num ++;
            } while (num <= 20);
        }
    }
}