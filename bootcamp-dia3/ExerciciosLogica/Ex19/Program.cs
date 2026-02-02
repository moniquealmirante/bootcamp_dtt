Console.WriteLine("Digite o primeiro número");
//entrada de usuário
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
double num2 = Convert.ToDouble(Console.ReadLine());

//dá as condiçoes

if (num1 > num2) 
{
	Console.WriteLine(num1);
} else if (num1 < num2)
{
	Console.WriteLine(num2); 
} else 
{ 
	Console.WriteLine("Os números digitados são iguais");
}