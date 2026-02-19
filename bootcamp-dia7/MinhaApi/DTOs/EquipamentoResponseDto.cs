public class EquipamentoResponseDto
{
    public int Id { get; set; }
    public string Codigo { get; set; } = null!;
    public string Tipo { get; set; } = null!;
    public string Modelo { get; set; } = null!;
    public decimal Horimetro { get; set; }
    public string StatusOperacional { get; set; } = null!;
    public DateOnly DataAquisicao { get; set; }
    public string? LocalizacaoAtual { get; set; }
}