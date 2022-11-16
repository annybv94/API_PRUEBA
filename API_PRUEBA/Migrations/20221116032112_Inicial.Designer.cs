﻿// <auto-generated />
using API_PRUEBA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_PRUEBA.Migrations
{
    [DbContext(typeof(PRUEBAContext))]
    [Migration("20221116032112_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_PRUEBA.Models.Cargos", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(18, 0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnName("activo")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("codigo")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("IdUsuarioCreacion")
                        .HasColumnName("idUsuarioCreacion")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("API_PRUEBA.Models.Departamentos", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(18, 0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnName("activo")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("codigo")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("IdUsuarioCreacion")
                        .HasColumnName("idUsuarioCreacion")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("API_PRUEBA.Models.Users", b =>
                {
                    b.Property<string>("Usuario")
                        .HasColumnName("usuario")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<decimal>("IdCargo")
                        .HasColumnName("idCargo")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal>("IdDepartamento")
                        .HasColumnName("idDepartamento")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnName("primerApellido")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnName("primerNombre")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasColumnName("segundoApellido")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("SegundoNombre")
                        .IsRequired()
                        .HasColumnName("segundoNombre")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.HasKey("Usuario")
                        .HasName("pk_Usuario");

                    b.HasIndex("IdCargo");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API_PRUEBA.Models.Users", b =>
                {
                    b.HasOne("API_PRUEBA.Models.Cargos", "IdCargoNavigation")
                        .WithMany("Users")
                        .HasForeignKey("IdCargo")
                        .HasConstraintName("FK__Users__idCargo__286302EC")
                        .IsRequired();

                    b.HasOne("API_PRUEBA.Models.Departamentos", "IdDepartamentoNavigation")
                        .WithMany("Users")
                        .HasForeignKey("IdDepartamento")
                        .HasConstraintName("FK__Users__idDeparta__276EDEB3")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}