
double nota;


while(true)
{

	Console.WriteLine("Digite uma nota entre zero e dez");
	double nota = Convert.ToDouble(Console.ReadLine());

	if (nota >= 0 && nota <= 10 ) 
	{	
		Console.WriteLine("Nota Válida" + nota);
		break;
	} else 
	{
		Console.WriteLine("Nota inválida");
	}

}