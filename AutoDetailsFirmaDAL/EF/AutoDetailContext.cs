using AutoDetailsFirmaDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AutoDetailsFirmaDAL.EF
{
    public class AutoDetailContext : DbContext
    {
         DbSet<Detail> Details { get; set; }
         DbSet<GroupOfDetail> GroupOfDetails { get; set; }
         DbSet<Provide> Provides { get; set; }
         DbSet<Provider> Providers { get; set; }
         DbSet<Shop> Shops { get; set; }

        public AutoDetailContext(DbContextOptions<AutoDetailContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Details

            modelBuilder.Entity<Detail>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Detail>()
                .HasMany(c => c.Provides)
                .WithOne(e => e.Detail)
                .HasForeignKey(e => e.IdOfDetail)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Detail>()
                .Property(p => p.ArticleOfDetail)
                .HasMaxLength(7);
            modelBuilder.Entity<Detail>()
                .Property(p => p.NameOfDetail)
                .HasMaxLength(20);


            //GroupOfDetails

            modelBuilder.Entity<GroupOfDetail>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<GroupOfDetail>()
                .Property(p => p.ArticleOfGroupOfDetail)
                .HasMaxLength(7);

            modelBuilder.Entity<GroupOfDetail>()
                .HasMany(c => c.Details)
                .WithOne(e => e.GroupOfDetail)
                .HasForeignKey(p => p.GroupOfDetailId)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<GroupOfDetail>()
                .Property(p => p.NotesOfGroupOfDetail)
                .HasMaxLength(25);



            //Provides
            modelBuilder.Entity<Provide>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Provide>()
                .HasMany(m => m.Shops)
                .WithOne(o => o.Provide)
                .HasForeignKey(f => f.ProvideId)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Provide>()
                .Property(p => p.ArticleOfProvide)
                .HasMaxLength(7);


            //Providervs
            modelBuilder.Entity<Provider>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Provider>()
                .HasMany(l => l.Provides)
                .WithOne(l => l.Provider)
                .HasForeignKey(l => l.IdOFProvider)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Provider>()
                .Property(p => p.ProviderName)
                .HasMaxLength(25);
            modelBuilder.Entity<Provider>()
                 .Property(p => p.ProviderAdress)
                 .HasMaxLength(50);

            //Shops
            modelBuilder.Entity<Shop>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Shop>()
                .Property(p => p.ArticleOfShop)
                .HasMaxLength(7);
            modelBuilder.Entity<Shop>()
                .Property(p => p.NameOfShop)
                .HasMaxLength(25);

        }
    }
}
