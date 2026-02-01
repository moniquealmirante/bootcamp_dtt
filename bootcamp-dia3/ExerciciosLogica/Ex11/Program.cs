//saída e entrada de variáveis

Console.WriteLine("Digite o primeiro número inteiro");

int num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo número inteiro");

int num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o número real");

double numR = Convert.ToDouble(Console.ReadLine());

//cálculos

//o produto do dobro do primeiro com metade do segundo.
double letraA = (num1 * 2) * (num2 / 2);
//a soma do triplo do primeiro com o terceiro.
double letraB = (num1 * 3) + numR;
//o terceiro elevado ao cubo.
double  letraC = Math.Pow(numR, 3);


Console.WriteLine($"Valor da letra A:{letraA}");
Console.WriteLine($"Valor da letra B: {letraB}");
Console.WriteLine($"Valor da letra C: {letraC}");
