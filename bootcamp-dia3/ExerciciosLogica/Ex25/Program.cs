//saída de sistema e entrada de usuário
Console.WriteLine("Digite o primeiro número:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
double num3 = Convert.ToDouble(Console.ReadLine());

//valores das variaveis maior e menor
double menor = num1;
double maior = num1;

//dá as condições
if (num2 > maior) 
	maior = num2;
if (num3 > maior) 
	maior = num3;
if (num2 < menor)
	menor = num2;
if (num3 < menor)
	menor = num3;

Console.WriteLine($"O número maior entre os três é o: {maior}");
Console.WriteLine($"O número menor entre os três é o: {menor}");