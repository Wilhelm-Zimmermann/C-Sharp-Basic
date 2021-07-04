// Projeto .cs de console
//------------------------------------//
// Tudo isso são módulos Padroes      //
                                      //
using System;                         //
using System.Collections.Generic;     //
using System.Linq;                    //
using System.Text;                    //
                                      //
//------------------------------------//
namespace FirstCSharp
{
    class Program
    {
        // Funçao principal
        static void Main(string[] args)
        {
            // Podemos criar uma variavel igual a js mas nao é muito viável
            // var user = Console.ReadLine();
            // Console.WriteLine("Você digitou: "+user);
            // Para declarar uma variavel : 'tipo'+'nome' = 'valor'
            
            // variavel do tipo int
            int num = 1;
            // variavel do tipo string
            string cor = "Roxo";
            cor = "Verde";
            // variavel do tipo float
            float velocidadeCarro = 192.12f;
            // variavel do tipo boolean
            bool verdade = true;
            // variavel dinamica, podemos mudar seu tipo.Nao recomendado usar
            dynamic qualquerCoisa = "meu nome";
            
            
            Console.WriteLine("Kono Sekai");
            Console.WriteLine(num);
            Console.WriteLine("A velocidade do carro é de: " + velocidadeCarro);
            Console.WriteLine("Sua cor favorita é: " + cor);
            string texto = Console.ReadLine();
            Console.WriteLine("Você digitou: " + texto);
            Console.ReadLine();

            
        }
    }   
}