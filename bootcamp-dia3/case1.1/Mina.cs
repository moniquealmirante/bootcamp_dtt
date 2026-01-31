

class Mina

{
    private Minerio minerio;
    string codigo;
    string nome;
    decimal capacidade;

    public Minerio getMinerio()
    {
        return this.minerio;
    }

    public void setMinerio(Minerio pMinerio)
    {
    }
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

    public void setNome(string pNome)
    {
    }

    public decimal getCapacidade()
    {
        return this.capacidade;
    }

    public void setCapacidade(string pCapacidade)
    {
    }

//getters e setters

    public Minerio acessarExtrairMinerio(bool isGestorMina)
    {
        if (isGestorMina)
        {
            return this.extrairMinerio();
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

        return minerio;
    }

}

