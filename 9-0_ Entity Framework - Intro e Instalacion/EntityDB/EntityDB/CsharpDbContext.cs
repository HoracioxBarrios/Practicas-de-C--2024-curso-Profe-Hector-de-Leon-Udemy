using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityDB;

public partial class CsharpDbContext : DbContext
{
    public CsharpDbContext()
    {
    }

    public CsharpDbContext(DbContextOptions<CsharpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Beer> Beers { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //    //=> optionsBuilder.UseSqlServer("Server=Hora\\SERVER_PRUEBA;Database=CsharpDB; User=sa; Password=123456;TrustServerCertificate=Yes;");



    //    /*
    //    Es importante tener en cuenta el comentario que acompaña al código, el cual advierte sobre 
    //    la sensibilidad de la información en la cadena de conexión y sugiere moverla fuera del código 
    //    fuente para mejorar la seguridad. En lugar de incluir la cadena de conexión directamente en 
    //    el código, se sugiere leerla desde la configuración, lo que es una práctica recomendada en 
    //    el desarrollo de aplicaciones.
    //    */
    //}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beer>(entity =>
        {
            entity.ToTable("Beer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Brand).WithMany(p => p.Beers)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beer_Brand");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("Brand");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
