


string nome;
string senha;

while (true)

{
	Console.WriteLine("Digite um nome de usuário");
	nome = Console.ReadLine();

	Console.WriteLine("Digite uma senha de usuário");
	senha = Console.ReadLine();

  if (nome == senha)
	{
	Console.WriteLine("Erro. O nome de usuário não pode ser igual a senha");
	break;
	}

}
