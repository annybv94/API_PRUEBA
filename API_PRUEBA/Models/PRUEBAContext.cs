using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_PRUEBA.Models
{
    public partial class PRUEBAContext : DbContext
    {
        public PRUEBAContext()
        {
        }

        public PRUEBAContext(DbContextOptions<PRUEBAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=11.10.2.6;Database=PRUEBA;user id =UAdmin;password=**UseAdmin01;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargos>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarioCreacion)
                    .HasColumnName("idUsuarioCreacion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarioCreacion)
                    .HasColumnName("idUsuarioCreacion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Usuario)
                    .HasName("pk_Usuario");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdCargo)
                    .HasColumnName("idCargo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnName("idDepartamento")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasColumnName("primerApellido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasColumnName("primerNombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasColumnName("segundoApellido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .IsRequired()
                    .HasColumnName("segundoNombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__idCargo__286302EC");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__idDeparta__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
