


public class Equipamento
{
    public int Id { get; set; }
    public string Codigo { get; set; } = null!;
    public TipoEquipamento Tipo { get ; set; }
    public string Modelo { get; set; } = null!;
    public decimal Horimetro { get ; set; }
    public StatusOperacional StatusOperacional { get; set; }
    public string? LocalizacaoAtual { get; set; } 
}