Console.WriteLine("Digite sua altura para saber o seu peso ideal: ");

double altura = Convert.ToDouble(Console.ReadLine());

double pesoIdeal = (72.7 * altura) - 58;

Console.WriteLine($"O seu peso ideal é igual a: {pesoIdeal}");
