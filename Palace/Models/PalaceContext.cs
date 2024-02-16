using Microsoft.EntityFrameworkCore;

namespace Palace.Models;
  public class PalaceContext : DbContext
  {
    public DbSet<Bouquet> Bouquets { get; set; }
    public DbSet<Flower> Flowers { get; set; }
    public DbSet<BouquetFlower>  BouquetFlowers { get; set; }
    public PalaceContext(DbContextOptions options) : base(options) { }
  }