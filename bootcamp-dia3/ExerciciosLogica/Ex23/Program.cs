//saída do sistema e entrada de usuário
Console.WriteLine("Digite a primeira nota");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
double nota2 = Convert.ToDouble(Console.ReadLine());

//media do aluno
double mediaAluno = (nota1 + nota2) / 2;

//dá as condições
if (mediaAluno >= 7) 
{
	Console.WriteLine("Aprovado");
} else if (mediaAluno < 7)
{
	Console.WriteLine("Reprovado");
} else (mediaAluno == 10);
{
	Console.WriteLine("Aprovado com Distinção");
}
