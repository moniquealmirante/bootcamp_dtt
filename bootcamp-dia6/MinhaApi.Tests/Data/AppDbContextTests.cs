using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;
using MinhaApi.Models;
using Xunit;

namespace MinhaApi.Tests.Data
{
    public class AppDbContextTests
    {
        private AppDbContext CriarContexto()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TesteDb")
                .Options;

            return new AppDbContext(options);
        }

        [Fact]
        public void Deve_Mapear_Tabela_LotesMinerio_Corretamente()
        {
            using var context = CriarContexto();

            var entity = context.Model.FindEntityType(typeof(LoteMinerio));

            Assert.NotNull(entity);
            Assert.Equal("lotes_minerio", entity!.GetTableName());
            Assert.Equal("public", entity.GetSchema());
        }

        [Fact]
        public void Deve_Definir_Chave_Primaria_Id()
        {
            using var context = CriarContexto();

            var entity = context.Model.FindEntityType(typeof(LoteMinerio));
            var key = entity!.FindPrimaryKey();

            Assert.Single(key!.Properties);
            Assert.Equal("Id", key.Properties[0].Name);
        }

        [Fact]
        public void Deve_Definir_CodigoLote_Como_Obrigatorio_E_Unico()
        {
            using var context = CriarContexto();

            var entity = context.Model.FindEntityType(typeof(LoteMinerio));
            var property = entity!.FindProperty(nameof(LoteMinerio.CodigoLote));

            Assert.False(property!.IsNullable);
            Assert.Equal(50, property.GetMaxLength());

            var index = entity.GetIndexes()
                .Single(i => i.Properties.Any(p => p.Name == nameof(LoteMinerio.CodigoLote)));

            Assert.True(index.IsUnique);
        }

        [Fact]
        public void Deve_Definir_Campos_String_Obrigatorios_Com_Tamanho_Correto()
        {
            using var context = CriarContexto();

            var entity = context.Model.FindEntityType(typeof(LoteMinerio))!;

            Assert.False(entity.FindProperty(nameof(LoteMinerio.MinaOrigem))!.IsNullable);
            Assert.Equal(120, entity.FindProperty(nameof(LoteMinerio.MinaOrigem))!.GetMaxLength());

            Assert.False(entity.FindProperty(nameof(LoteMinerio.LocalizacaoAtual))!.IsNullable);
            Assert.Equal(200, entity.FindProperty(nameof(LoteMinerio.LocalizacaoAtual))!.GetMaxLength());
        }

       
        [Fact]
        public void Deve_Converter_StatusLote_Para_Int()
        {
            using var context = CriarContexto();

            var entity = context.Model.FindEntityType(typeof(LoteMinerio))!;
            var property = entity.FindProperty(nameof(LoteMinerio.Status))!;

            Assert.Equal(typeof(int), property.GetProviderClrType());
        }
    }
}