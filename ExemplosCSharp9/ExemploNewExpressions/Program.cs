using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ExemploNewExpressions
{
    public class Produto
    {
        public Produto() { }

        public Produto(string codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Produto prod1 = new("0001", "Produto 0001", 100.11);
            Produto prod2 = new("0002", "Produto 0002", 20.20);

            List<Produto> produtos = new() { prod1, prod2 };

            foreach (Produto produto in produtos)
                Console.WriteLine(JsonSerializer.Serialize(produto));
        }
    }
}