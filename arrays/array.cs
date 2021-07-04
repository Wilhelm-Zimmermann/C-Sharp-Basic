using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Array com limites
            string[] produtos = new string[5] {
                "batman",
                "fifa",
                "cod",
                "free fire",
                "lol"
            };
            produtos[1] = "Fifa 20";

            for(int i = 0; i < produtos.Length; i++){
                Console.WriteLine(produtos[i]);
            }
            
            // Array comum
            int[] valores = {30,50,20,2,3,45};
            Console.ReadLine();
        }
    }
}