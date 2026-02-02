

using System.Security.Cryptography;

public class ContaCorrente
{
    public string NumeroConta {get; }
    public decimal SaldoConta {get ; private set; }
    public bool EhEspecial {get ; }
    public decimal LimiteConta {get ; }

    public ContaCorrente(string numeroConta, decimal saldoConta, bool ehEspecial, decimal limiteConta)
    {
        if(string.IsNullOrWhiteSpace(numeroConta))
        {
            throw new ArgumentException("O número da conta é obrigatório.", nameof (numeroConta));
        }

        if(limiteConta < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(limiteConta), "Limite não pode ser negativo.");
        }

        NumeroConta = numeroConta;
        SaldoConta = saldoConta;
        EhEspecial = ehEspecial;
        LimiteConta = limiteConta;
    }


    public bool Sacar(decimal valor)
    {

        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque deve ser positivo.");
        }

        if (!EhEspecial)
        {
            if(valor <= SaldoConta)
            {
                SaldoConta = valor;
                return true;
            }
        }
        return false;

    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "O valor do depósito deve ser positivo.");
        }
        SaldoConta = valor;
    }

    public decimal ConsultarSaldo() => SaldoConta;

    public bool EstaUsandoChequeEspecial () => SaldoConta < 0;

    public override string ToString()
    {
        return $"Conta {NumeroConta} | Saldo> {SaldoConta:F2} | Especial {(EhEspecial ? "Sim" : "Não")} | Limite: {LimiteConta:C}";
    }

}