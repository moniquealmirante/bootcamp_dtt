using System.Reflection.PortableExecutable;


Console.WriteLine("Obtendo peso do peixe...");
//pede o peso do peixe e pega a variavel
Console.WriteLine("Digite abaixo o peso do peixe mostrado: ");
double pesoPeixe = Convert.ToDouble(Console.ReadLine());

//declara as variáveis e da a condição para saber se o peixe está dentro do peso estabelecido
double excesso = 0;
double multa = 0;

if (pesoPeixe > 50)
{
    excesso = pesoPeixe - 50;
    multa = excesso * 4;
    Console.WriteLine($"Excesso em Kg: {excesso}");
    Console.WriteLine($"O valor da multa é: {multa}");
} else
{
    Console.WriteLine("O peixe não excedeu o peso. O valor da multa é zero.");
}


