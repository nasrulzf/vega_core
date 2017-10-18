using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base(options)
        {            
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelFeature>().HasKey(k => new { k.FeatureId, k.ModelId });
            modelBuilder.Entity<ModelFeature>()
                        .HasOne(pt => pt.Model)
                        .WithMany(p => p.ModelFeatures)
                        .HasForeignKey(pt => pt.ModelId);

            modelBuilder.Entity<ModelFeature>()
                        .HasOne(ft => ft.Feature)
                        .WithMany(f => f.ModelFeatures)
                        .HasForeignKey(ft => ft.FeatureId);
        }
    }
}