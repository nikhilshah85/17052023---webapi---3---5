using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shoppingAPI.Models.EF;

public partial class ShoppingDbapiContext : DbContext
{
    public ShoppingDbapiContext()
    {
    }

    public ShoppingDbapiContext(DbContextOptions<ShoppingDbapiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustomersList> CustomersLists { get; set; }

    public virtual DbSet<ProductsList> ProductsLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\ProjectModels;database=shoppingDBAPI;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomersList>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__customer__D830D47731BA52C7");

            entity.ToTable("customersList");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cId");
            entity.Property(e => e.CName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cType");
            entity.Property(e => e.CWalletBalance).HasColumnName("cWalletBalance");
        });

        modelBuilder.Entity<ProductsList>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__products__DD36D5626A186A28");

            entity.ToTable("productsList");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PDiscount).HasColumnName("pDiscount");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
