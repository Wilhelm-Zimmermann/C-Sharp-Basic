using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace condicionais 
{
    class Condicao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qualquer coisa");
            string nome = Console.ReadLine();
            if(nome == "Wil"){
                Console.WriteLine("verdade");
            }else if(nome == "joao" || nome == "maria"){
                Console.WriteLine("Legal!");
            }
            else{
                Console.WriteLine("Falso");
            }
            Console.ReadLine();
        }
    }
}