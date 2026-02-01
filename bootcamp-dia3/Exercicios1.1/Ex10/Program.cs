Console.WriteLine("Digite a temperatura em Graus Celsius: ");

double celsius = Convert.ToDouble(Console.ReadLine());

double farenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"O valor da temperatura em graus Farenheit é igual a : {farenheit}");