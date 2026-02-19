public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Equipamento> Equipamentos => Set<Equipamento>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipamento>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasIndex(e => e.Codigo)
                  .IsUnique();

            entity.Property(e => e.Codigo)
                  .IsRequired();

            entity.Property(e => e.Modelo)
                  .IsRequired();

            entity.Property(e => e.Tipo)
                  .HasConversion<string>();

            entity.Property(e => e.StatusOperacional)
                  .HasConversion<string>();

            entity.Property(e => e.Horimetro)
                  .HasPrecision(18,2);
        });
    }
}