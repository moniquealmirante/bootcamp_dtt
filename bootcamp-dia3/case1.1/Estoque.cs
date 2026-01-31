

class Estoque
{
    int id;
    int producaoId;
    decimal quantidade;
    string local;


    //condições

    public int montarEstoque(int id, int producaoId, decimal quantidade, string local)
    {
    bool isIdValido = (id < 0);
    bool isProdValida = (producaoId < 0);
    bool isQuantidadeValida = (quantidade > 1);

    bool isRegraNegocioFinalOk = (isIdValido && isProdValida);

        if (isRegraNegocioFinalOk)
            {
            return 0;
            }else
            {
            return 1;
            }
    }

}



