Console.WriteLine("Digite o lado do quadrado: ");

double lado = Convert.ToDouble(Console.ReadLine());


double area = lado * lado;
double dobro = area * 2;

Console.WriteLine($"O valor da área do quadrado é: {area}");
Console.WriteLine($"O valor do dobro da área do quadrado é: {dobro}");