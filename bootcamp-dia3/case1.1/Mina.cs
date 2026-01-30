

class Mina

{
    private Minerio minerio;
    string codigo;
    string nome;
    decimal capacidade;


public string getCodigo()
    {
        return this.codigo;
    }

public void setCodigo(string pCodigo)
    {
        
    }

public string getNome()
    {
        return this.nome;
    }

public void setNome()
    {
        
    }

public decimal getCapacidade()
    {
        return this.capacidade;
    }

public void setCapacidade()
    {
        
    }

//getters e setters


    public Minerio acessarExtrairMinerio(bool isGestorMina)
    {
        if (isGestorMina)
        {
            return extrairMinerio();
        } else
        {
            Minerio minerio = new Minerio();
            minerio.codigo = "0";
            return minerio;
        }

    }

    private Minerio extrairMinerio()
    {
        Minerio minerio = new Minerio();
        minerio.codigo = "1";
        minerio.tipo = "Ouro";
    }


}

