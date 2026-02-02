



ContaCorrente contaUsuario = new ContaCorrente(numeroConta: "0508-X", saldoConta: 500, ehEspecial: false, limiteConta: 0 );
Console.WriteLine("Conta do Usuário");
Console.WriteLine(contaUsuario);

Console.WriteLine("Tentando sacar R$ 600,00 (deve falhar)");
bool sacou = contaUsuario.Sacar(600);
Console.WriteLine($"Segue realizado? {(sacou ? "Sim" : "Não")}. Saldo: {contaUsuario.ConsultarSaldo():C}");

Console.WriteLine("Depositando R$ 300,00...");
contaUsuario.Depositar(300);
Console.WriteLine($"Saldo após depósito: {contaUsuario.ConsultarSaldo()}:C");
Console.WriteLine($"Usando cheque especial? {(contaUsuario.EstaUsandoChequeEspecial() ? "Sim" : "Não")}");

Console.WriteLine(contaUsuario); 


