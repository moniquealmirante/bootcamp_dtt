
Console.WriteLine("Digite o numéro de metros que serão convertidos: ");

double metros = double.Parse(Console.ReadLine());
double centimetros = metros * 100;

Console.WriteLine($"O resultado é: {centimetros}");