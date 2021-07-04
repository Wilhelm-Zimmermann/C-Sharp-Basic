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
            string[] jogos = {
                "Cod",
                "Lol",
                "Free Fire",
                "Grand Theft Auto San Andreas",
                "Need For Speed"
            };
            foreach (string item in jogos)
            {
                Console.WriteLine(item);
            }
        }
    }
}