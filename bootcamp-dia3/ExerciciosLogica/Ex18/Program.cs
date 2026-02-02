Console.Write.Line("Digite o tamanho do arquivo para Download: ");
//entrada de usuário
double tamanhoArq = Convert.ToDouble(Console.ReadLine());

Console.Write.Line("Digite a velocidade do link de internet: ");
double velocidadeLink = Convert.ToDouble(Console.ReadLine());

//calculo do tempo de download do arquivo

double tempoSegundos = (tamanhoMB * 8) / velocidadeLink;
double tempoMinutos = tempoSegundos / 60;

Console.WriteLine($"O tempo aproximado do Download é de: {tempoMinutos}");

