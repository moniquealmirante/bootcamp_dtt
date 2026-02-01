Console.WriteLine("Digite quanto você ganha por hora: ");
double porHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Agora digite quantas horas você trabalhou no mês: ");
double mesHora = Convert.ToDouble(Console.ReadLine());

double salario = porHora * mesHora;

Console.WriteLine($"O valor do salário é igual a : {salario}");







