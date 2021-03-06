﻿using AutoDetailsFirmaDAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoDetailsFirmaDAL.EF
{
    public class AutoDetailContext : IdentityDbContext<User, Role, int>
    {
         DbSet<Detail> Details { get; set; }
         DbSet<GroupOfDetail> GroupOfDetails { get; set; }
         DbSet<Provide> Provides { get; set; }
         DbSet<Provider> Providers { get; set; }
         DbSet<Shop> Shops { get; set; }

        public AutoDetailContext(DbContextOptions<AutoDetailContext> options) : base(options)
        {
            Database.EnsureCreated();
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

            //GroupOfDetails
            modelBuilder.Entity<GroupOfDetail>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<GroupOfDetail>()
                .HasMany(c => c.Details)
                .WithOne(e => e.GroupOfDetail)
                .HasForeignKey(p => p.GroupOfDetailId)
                .OnDelete(DeleteBehavior.ClientCascade);



            //Provides
            modelBuilder.Entity<Provide>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Provide>()
                .HasMany(m => m.Shops)
                .WithOne(o => o.Provide)
                .HasForeignKey(f => f.ProvideId)
                .OnDelete(DeleteBehavior.ClientCascade);



            //Providervs
            modelBuilder.Entity<Provider>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Provider>()
                .HasMany(l => l.Provides)
                .WithOne(l => l.Provider)
                .HasForeignKey(l => l.IdOFProvider)
                .OnDelete(DeleteBehavior.ClientCascade);


            //Shops
            modelBuilder.Entity<Shop>()
                .HasKey(p => p.Id);
      

        }
    }
}
