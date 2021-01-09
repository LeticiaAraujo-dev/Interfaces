using System;
using Objetos_como_argumentos.classes;

namespace Objetos_como_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Red Dead Redemption 2", 449f);
            Produto p2 = new Produto(2, "GTA 5", 59.90f);
            Produto p3 = new Produto(3, "Detroid: Become Human", 120.99f);
            Produto p4 = new Produto(4, "Celeste", 19.99f);
            Produto p5 = new Produto(5, "Hollow Knight: Silksong", 22f);

            Carrinho carrinho = new Carrinho();
            carrinho.Adicionar(p1);
            carrinho.Adicionar(p2);
            carrinho.Adicionar(p3);
            carrinho.Adicionar(p4);
            carrinho.Adicionar(p5);

            carrinho.Listar();
        }
    }
}
