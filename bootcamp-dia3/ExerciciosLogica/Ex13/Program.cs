//entrada de usuário

Console.WriteLine("Digite a sua altura: ");

double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o seu sexo (M para masculino e F para feminino)");

string sexo = Console.ReadLine().ToUpper();

Console.WriteLine("Digite seu peso atual: ");

double peso = Convert.ToDouble(Console.ReadLine());

double pesoIdeal = 0;

//calculo peso ideal
if (sexo == "M")
{
    pesoIdeal = (72.7 * altura) - 58;

} else if (sexo == "F")
{
    pesoIdeal = (62.1 * altura) - 44.7;
} else
{
    Console.WriteLine("Sexo inválido. Use F ou M");
    return;
}


//verifica se o peso do usuario ta dentro do peso ideal

if (peso < pesoIdeal)
{
    Console.WriteLine("Seu peso está abaixo do peso ideal.");

} else if (peso > pesoIdeal)
{
    Console.WriteLine("Seu peso está acima do peso ideal.");
}else
{
    Console.WriteLine("Você está dentro do peso ideal.");
}
