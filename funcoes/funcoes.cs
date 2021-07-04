using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace funcoes
{
    class Funcoes
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());
            ExibeMsg();
            precoProduto(num);


            Console.ReadLine();
        }
        static void ExibeMsg()
        {
            Console.WriteLine("Ola mundo");
        }

        static void precoProduto(int num = 0)
        {
            Console.WriteLine("O preço é de: "+ num);
        }
    }
}