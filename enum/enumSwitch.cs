using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace enumerate
{
    class Enumerate
    {
        enum cor
        {
            Azul,
            Verde,
            Amarelo,
            Roxo
        }

        enum Opcao { Criar, Editar, Deletar, Atualizar}
        static void Main(string[] args)
        {
            
            Console.WriteLine("Selecione uma das opçoes");
            Console.WriteLine("1-Criar\n2-Editar\n3-Deletar\n4-Atualizar");
            int select = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)select;
            Console.WriteLine("Você selecionou a opcao de: "+opcaoSelecionada);
            switch (opcaoSelecionada)
            {
                case Opcao.Atualizar:
                    Console.WriteLine("Voce deseja Atualizar");
                    break;
                case Opcao.Criar:
                    Console.WriteLine("Voce deseja Criar");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Voce deseja Deletar");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Voce deseja Editar");
                    break;
                
            }
            Console.ReadLine();
        }
    }
}