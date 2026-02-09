using System;
using MinhaApi.Dtos;
using Xunit;

namespace MinhaApi.Tests.Dtos
{
    public class CreateLoteMinerioDtoTests
    {
        [Fact]
        public void Deve_Criar_Dto_Com_Valores_Padrao()
        {
            // Act
            var dto = new CreateLoteMinerioDto();

            // Assert
            Assert.Equal(string.Empty, dto.CodigoLote);
            Assert.Equal(string.Empty, dto.MinaOrigem);
            Assert.Equal(string.Empty, dto.LocalizacaoAtual);

            Assert.Null(dto.DataProducao);

            Assert.Equal(0, dto.TeorFe);
            Assert.Equal(0, dto.Umidade);
            Assert.Equal(0, dto.Toneladas);
            Assert.Equal(0, dto.Status);
        }

        [Fact]
        public void Deve_Permitir_Campos_Opcionais_Nulos()
        {
            // Act
            var dto = new CreateLoteMinerioDto
            {
                SiO2 = null,
                P = null,
                DataProducao = null
            };

            // Assert
            Assert.Null(dto.SiO2);
            Assert.Null(dto.P);
            Assert.Null(dto.DataProducao);
        }

        [Fact]
        public void Deve_Atribuir_Valores_Corretamente()
        {
            // Arrange
            var data = new DateTime(2026, 2, 1);

            // Act
            var dto = new CreateLoteMinerioDto
            {
                CodigoLote = "MNA-2026-000999",
                MinaOrigem = "Carajás N5",
                TeorFe = 64.7m,
                Umidade = 9.1m,
                SiO2 = 2.8m,
                P = 0.03m,
                Toneladas = 15000m,
                DataProducao = data,
                Status = 2,
                LocalizacaoAtual = "Porto Tubarão"
            };

            // Assert
            Assert.Equal("MNA-2026-000999", dto.CodigoLote);
            Assert.Equal("Carajás N5", dto.MinaOrigem);
            Assert.Equal(64.7m, dto.TeorFe);
            Assert.Equal(9.1m, dto.Umidade);
            Assert.Equal(2.8m, dto.SiO2);
            Assert.Equal(0.03m, dto.P);
            Assert.Equal(15000m, dto.Toneladas);
            Assert.Equal(data, dto.DataProducao);
            Assert.Equal(2, dto.Status);
            Assert.Equal("Porto Tubarão", dto.LocalizacaoAtual);
        }
    }
}