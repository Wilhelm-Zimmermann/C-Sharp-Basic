using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operadores
{

    class Operadores 
    {
        static void Main(string[] args)
        {
            // Soma +
            // Subtraçao -
            // Multiplicaçao *
            // Divisao /
            // Potenciaçao **
            Console.WriteLine("Soma de 2 numeros");
            Console.WriteLine("Digite um numero inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("A soma foi de: "+soma);
            Console.ReadLine();
        }
    }
}