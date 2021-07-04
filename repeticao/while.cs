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
            // Enquanto for verdade faça
            while(num < 12)
            {
                Console.WriteLine(num);
                num ++;
            }
        }
    }
}