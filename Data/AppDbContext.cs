using Microsoft.EntityFrameworkCore;
using OnePiece.Models;

namespace OnePiece.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<FRUTA_DO_DIABO> Frutas { get; set; }
    public DbSet<PERSONAGEM> Personagens { get; set; }
    public DbSet<TRIPULACAO> Tripulacoes { get; set; }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

} 

