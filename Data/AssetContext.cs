using AssetManagenetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManagenetAPI.Data
{
    public class AssetContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public AssetContext(DbContextOptions<AssetContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>()
                .HasOne(a => a.Type)
                .WithMany(t => t.Assets)
                .HasForeignKey(a => a.TypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }



    }
}