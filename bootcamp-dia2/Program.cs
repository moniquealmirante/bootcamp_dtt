using System;
using System.Diagnostics.Tracing;

class Produto

{
   public string Nome {get ; private set; }
   public double Preco { get; private set; }
   public int Quantidade {get; private set; }


public Produto (string nome, double preco, int quantidade)
    {
        if(string.IsNullOrWhiteSpace(nome))
            throw new Exception("O campo não pode ficar em branco");
        
        if(preco <= 0)
            throw new Exception("O preço deve ser maior do que zero");
         
        if(quantidade < 0)
            throw new Exception("A quantidade não pode ser negativa");

        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;

    }
}
class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        try
        {
            Console.Write("Nome do Produto: ");
        string nome = Console.ReadLine();

        Console.Write("Preço do Produto: ");
         if (!double.TryParse(Console.ReadLine(), out double preco)) 
            throw new Exception("Preço inválido.");

        Console.Write("Quantidade do Produto em estoque: ");
         if(!int.TryParse(Console.ReadLine(), out int quantidade))
            throw new Exception("Quantidade inválida.");
        
            Produto produto = new Produto(nome, preco,quantidade);
            produtos.Add(produto);

            Console.WriteLine("Produto cadastrado!");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro {ex.Message}");
        }
    }
}


