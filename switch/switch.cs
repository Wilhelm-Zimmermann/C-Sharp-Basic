using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace switches
{
    class Switches
    {
        static void Main(string[] args)
        {

            string cor = "Roxo";
            switch (cor)
            {
                case "Roxo":
                    Console.WriteLine("Legal");
                    break;
                case "Azul":
                    Console.WriteLine("Insano");
                    break;
                case "Verde":
                    Console.WriteLine("Top");
                    break;
            }
            Console.ReadLine();
        }
    }
}