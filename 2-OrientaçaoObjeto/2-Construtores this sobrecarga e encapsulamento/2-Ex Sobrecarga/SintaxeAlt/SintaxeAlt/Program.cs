﻿using System;
using System.Globalization;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());


            Produto p = new Produto(nome);

            Produto p2 = new Produto()
            {
                Nome = "Tv",
                Preco = 300.00,
                Quantidade = 10
            };

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}
