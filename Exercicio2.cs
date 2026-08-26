using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Produto> catalogo = new List<Produto>
        {
            new Produto(1, "Camiseta", 50m),
            new Produto(2, "Calça", 120m),
            new Produto(3, "Tênis", 200m)
        };

        List<Produto> carrinho = new List<Produto>();

        while (true)
        {
            Console.WriteLine("\n1-Camiseta | 2-Calça | 3-Tênis | 0-Sair");
            Console.Write("Adicionar ID (ou -ID para remover, ex: -1): ");

            if (!int.TryParse(Console.ReadLine(), out int input) || input == 0) break;

            if (input > 0)
            {
                Produto p = catalogo.Find(x => x.Id == input);
                if (p != null)
                {
                    carrinho.Add(p);
                    Console.WriteLine($"{p.Nome} adicionado!");
                }
                else Console.WriteLine("Inválido.");
            }
            else
            {
                Produto p = carrinho.Find(x => x.Id == Math.Abs(input));
                if (p != null)
                {
                    carrinho.Remove(p);
                    Console.WriteLine($"{p.Nome} removido!");
                }
                else Console.WriteLine("Não está no carrinho.");
            }
        }

        if (carrinho.Count == 0)
        {
            Console.WriteLine("\nCarrinho vazio.");
            return;
        }

        Console.Write("\nPagamento (Pix, Cartão, Dinheiro): ");
        string pagamento = Console.ReadLine();

        Console.WriteLine("\n--- Resumo ---");
        decimal total = 0;

        foreach (var item in carrinho)
        {
            Console.WriteLine($"- {item.Nome} (R$ {item.Preco})");
            total += item.Preco;
        }

        Console.WriteLine($"Total: R$ {total}");
        Console.WriteLine($"Pagamento: {pagamento}");
    }
}

class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
    }
}
