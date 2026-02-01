Console.WriteLine("Digite a temperatra em Farenheit: ");

double farenheit = Convert.ToDouble(Console.ReadLine());

double celsius = (5 * (farenheit - 32 ) /9 );

Console.WriteLine($"O valor em graus Celsius é igual a : {celsius}");
