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
        static void Main(string[] args)
        {
            cor corFavorita = cor.Roxo;
            cor corFavoritaWil = cor.Verde;
            Console.WriteLine((int)corFavorita);
            Console.WriteLine(corFavoritaWil);
            Console.WriteLine((cor)3);

            Console.ReadLine();
        }
    }
}