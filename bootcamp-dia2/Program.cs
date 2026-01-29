using System;

class Produto

{
   public string Nome {get ; private set; }
   public double Preco { get; private set; }
   public int Quantidade {get; private set; }


public Produto (string nome, double preco, int quantidade)
    {
        if(nome == " ")
        {
            Console.WriteLine("Campo em branco. Preencha com o nome do produto.");
        } else
        {
            Console.WriteLine("Nome cadastrado");
        }

        if(preco < 0)
        {
            Console.WriteLine("Preencha o preço válido do produto.");
        } else
        {
            Console.WriteLine("Preço cadastrado.");
        }

        if(quantidade < 0)
        {
            Console.WriteLine("Preencha a quantidade válida do produto.");
        }else
        {
            Console.WriteLine("Quantidade cadastrada.");
        }

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

        Console.Write("Nome do Produto: ");
        string nome = Console.ReadLine();

        Console.Write("Preço do Produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade do Produto: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco, quantidade);

        if(!string.IsNullOrEmpty(p.Nome))
        {
            produtos.Add(p);
        }

    }
}
