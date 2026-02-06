using MinhaApi.Models;

namespace MinhaApi.Dtos
{
    public record LoteMinerioResponseDto(
        int Id,
        string CodigoLote,
        string MinaOrigem,
        string LocalizacaoAtual,
        decimal TeorFe,
        decimal Umidade,
        decimal? SiO2,
        decimal? P,
        decimal Toneladas,
        DateTime DataProducao,      
        StatusLote Status
        
        
    );
}