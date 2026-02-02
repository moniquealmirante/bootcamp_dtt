

public class Lampada
{
    
    private bool isLigada;
    
    public Lampada()
    {
       isLigada = false;
    }

    public void Ligar()
    {
        isLigada = true;
        Console.WriteLine("Está ligada");
    }

    public void Desligar()
    {
        isLigada = false;
        Console.WriteLine("Está desligada");
    }

}