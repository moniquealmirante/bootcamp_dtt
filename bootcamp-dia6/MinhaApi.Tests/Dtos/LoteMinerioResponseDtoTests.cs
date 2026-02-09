using System;
using MinhaApi.Dtos;
using MinhaApi.Models;
using Xunit;

namespace MinhaApi.Tests.Dtos
{
    public class LoteMinerioResponseDtoTests
    {
        [Fact]
        public void Deve_Criar_Record_Com_Valores_Corretos()
        {
            // Arrange
            var data = new DateTime(2026, 3, 10);

            // Act
            var dto = new LoteMinerioResponseDto(
                Id: 10,
                CodigoLote: "MNA-2026-001234",
                MinaOrigem: "Carajás N4",
                LocalizacaoAtual: "Porto Tubarão",
                TeorFe: 66.2m,
                Umidade: 7.8m,
                SiO2: 2.5m,
                P: 0.02m,
                Toneladas: 18000m,
                DataProducao: data,
                Status: StatusLote.Embarcado
            );

            // Assert
            Assert.Equal(10, dto.Id);
            Assert.Equal("MNA-2026-001234", dto.CodigoLote);
            Assert.Equal("Carajás N4", dto.MinaOrigem);
            Assert.Equal("Porto Tubarão", dto.LocalizacaoAtual);
            Assert.Equal(66.2m, dto.TeorFe);
            Assert.Equal(7.8m, dto.Umidade);
            Assert.Equal(2.5m, dto.SiO2);
            Assert.Equal(0.02m, dto.P);
            Assert.Equal(18000m, dto.Toneladas);
            Assert.Equal(data, dto.DataProducao);
            Assert.Equal(StatusLote.Embarcado, dto.Status);
        }

        [Fact]
        public void Records_Com_Mesmos_Valores_Devem_Ser_Iguais()
        {
            // Arrange
            var data = new DateTime(2026, 3, 10);

            var dto1 = new LoteMinerioResponseDto(
                1, "L001", "Mina A", "Patio",
                60m, 8m, null, null, 1000m,
                data, StatusLote.EmEstoque
            );

            var dto2 = new LoteMinerioResponseDto(
                1, "L001", "Mina A", "Patio",
                60m, 8m, null, null, 1000m,
                data, StatusLote.EmEstoque
            );

            // Act & Assert
            Assert.Equal(dto1, dto2);
        }

        [Fact]
        public void With_Deve_Criar_Nova_Instancia_Com_Valor_Alterado()
        {
            // Arrange
            var data = DateTime.UtcNow;

            var original = new LoteMinerioResponseDto(
                1, "L001", "Mina A", "Mina",
                61m, 9m, null, null, 500m,
                data, StatusLote.EmEstoque
            );

            // Act
            var modificado = original with { Status = StatusLote.EmTransporte };

            // Assert
            Assert.NotSame(original, modificado);
            Assert.Equal(StatusLote.EmEstoque, original.Status);
            Assert.Equal(StatusLote.EmTransporte, modificado.Status);
        }

        [Fact]
        public void Deve_Permitir_Valores_Nulos_Nos_Campos_Opcionais()
        {
            // Act
            var dto = new LoteMinerioResponseDto(
                1, "L002", "Mina B", "Pátio",
                63m, 8m, null, null, 2000m,
                DateTime.UtcNow, StatusLote.EmEstoque
            );

            // Assert
            Assert.Null(dto.SiO2);
            Assert.Null(dto.P);
        }
    }
}