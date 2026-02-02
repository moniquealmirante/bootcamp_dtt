Console.WriteLine("Digite a letra F ou M para informar o seu sexo (F para Feminino e M para masculino)");
//entrada de usuário
string sexo = Console.ReadLine();

//dá as condições
  if(sexo == "F") 
{
	Console.WriteLine("F - Feminino");
} else if (sexo == "M")
{
	Console.WriteLine("M - Masculino");
} else 
{
	Console.WriteLine("Sexo inválido");
}
