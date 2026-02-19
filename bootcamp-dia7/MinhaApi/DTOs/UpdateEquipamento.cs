

public class UpdateEquipamento
{
    [Required]
    public TipoEquipamento Tipo { get; set; }
    [Required]
    public string Modelo { get; set; } = null!;
    [Range(0, double.MaxValue)]
    public decimal Horimetro { get; set; }
    [Required]
    public StatusOperacional StatusOperacional { get; set; }
    public DateOnly DataAquisicao { get; set; }
    public string? LocalizacaoAtual { get; set; }

}