using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shoppingAPI_Azure.Models.EF;

public partial class ShoppingDbContext : DbContext
{
    public ShoppingDbContext()
    {
    }

    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MProductList> MProductLists { get; set; }

    public virtual DbSet<ProductsList> ProductsLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:shoppingapiinstance.database.windows.net,1433;Initial Catalog=shoppingDB;Persist Security Info=False;User ID=trainer;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MProductList>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("Pk_pID");

            entity.ToTable("mProductList");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCompany)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pCompany");
            entity.Property(e => e.PProduct)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pProduct");
            entity.Property(e => e.PStock)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pStock");
        });

        modelBuilder.Entity<ProductsList>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__products__DD37D91AED0ABD15");

            entity.ToTable("productsList");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.Pcategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pcategory");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Pprice).HasColumnName("pprice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
