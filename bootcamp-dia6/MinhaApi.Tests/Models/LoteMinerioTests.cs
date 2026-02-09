using System;
using MinhaApi.Models;
using Xunit;

namespace MinhaApi.Tests.Models
{
    public class LoteMinerioTests
    {
        [Fact]
        public void Deve_Criar_LoteMinerio_Com_Valores_Corretos()
        {
            // Arrange
            var dataProducao = new DateTime(2026, 1, 15);

            // Act
            var lote = new LoteMinerio
            {
                Id = 1,
                CodigoLote = "MNA-2026-000123",
                MinaOrigem = "Carajás N4E",
                TeorFe = 65.5m,
                Umidade = 8.2m,
                SiO2 = 3.1m,
                P = 0.04m,
                Toneladas = 12000m,
                DataProducao = dataProducao,
                Status = StatusLote.EmEstoque,
                LocalizacaoAtual = "Pátio Carajás"
            };

            // Assert
            Assert.Equal(1, lote.Id);
            Assert.Equal("MNA-2026-000123", lote.CodigoLote);
            Assert.Equal("Carajás N4E", lote.MinaOrigem);
            Assert.Equal(65.5m, lote.TeorFe);
            Assert.Equal(8.2m, lote.Umidade);
            Assert.Equal(3.1m, lote.SiO2);
            Assert.Equal(0.04m, lote.P);
            Assert.Equal(12000m, lote.Toneladas);
            Assert.Equal(dataProducao, lote.DataProducao);
            Assert.Equal(StatusLote.EmEstoque, lote.Status);
            Assert.Equal("Pátio Carajás", lote.LocalizacaoAtual);
        }

        [Fact]
        public void Deve_Permitir_Valores_Opcionais_Nulos()
        {
            // Act
            var lote = new LoteMinerio
            {
                TeorFe = 62m,
                Umidade = 10m,
                Toneladas = 5000m,
                DataProducao = DateTime.UtcNow,
                Status = StatusLote.EmTransporte
            };

            // Assert
            Assert.Null(lote.SiO2);
            Assert.Null(lote.P);
        }

        [Fact]
        public void StatusLote_Deve_Ter_Valores_Corretos()
        {
            // Assert
            Assert.Equal(0, (int)StatusLote.EmEstoque);
            Assert.Equal(1, (int)StatusLote.EmTransporte);
            Assert.Equal(2, (int)StatusLote.Embarcado);
        }
    }
}