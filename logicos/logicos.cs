using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicos
{
    class Logicos 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade <= 12){
                Console.WriteLine("Você é uma criança");
            }
            if(idade > 12 && idade < 18){
                Console.WriteLine("Você é um adolescente");
            }
            if(idade >= 18 && idade <= 55){
                Console.WriteLine("Você é um adulto");
            }
            else{
                Console.WriteLine("Você é um Idoso");
            }
        }
    }
}