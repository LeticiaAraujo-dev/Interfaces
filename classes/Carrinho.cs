
using System;
using System.Collections.Generic;

namespace Objetos_como_argumentos.classes
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal {get; set;}
        List<Produto> carrinho = new List<Produto>();


        public void Adicionar( Produto produto)
        {
            carrinho.Add(produto);
        }
        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if(carrinho != null){
                foreach(Produto p in carrinho){
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do Carrinho R$ {ValorTotal.ToString("n2")}");
            }else{
                Console.WriteLine($"Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }
        public void Listar()
        {
            if(carrinho != null){
                foreach(Produto p in carrinho){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{p.Preco.ToString("n2")} - {p.Nome} ");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
    }
}