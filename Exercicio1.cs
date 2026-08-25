using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Nome do cliente: ");
        string cliente = Console.ReadLine();

        List<Produto> vitrine = new List<Produto>
        {
            new Produto(1, "Teclado", 150.00m),
            new Produto(2, "Mouse", 80.00m),
            new Produto(3, "Monitor", 1200.00m)
        };

        decimal total = 0;
        List<string> itensComprados = new List<string>();

        while (true)
        {
            Console.WriteLine("\nCatálogo: 1-Teclado (R$150) | 2-Mouse (R$80) | 3-Monitor (R$1200) | 0-Finalizar");
            Console.Write("Digite o ID do produto: ");

            if (!int.TryParse(Console.ReadLine(), out int id) || id == 0) break;

            Produto produtoSelecionado = vitrine.Find(p => p.Id == id);

            if (produtoSelecionado != null)
            {
                itensComprados.Add(produtoSelecionado.Nome);
                total += produtoSelecionado.Preco;
                Console.WriteLine($"{produtoSelecionado.Nome} adicionado!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        if (itensComprados.Count == 0) return;

        Console.Write("\nForma de pagamento (ex: Pix, Cartão, Dinheiro): ");
        string pagamento = Console.ReadLine();

        Console.WriteLine("\n--- Resumo do Pedido ---");
        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"Produtos: {string.Join(", ", itensComprados)}");
        Console.WriteLine($"Total a Pagar: {total:C}");
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
