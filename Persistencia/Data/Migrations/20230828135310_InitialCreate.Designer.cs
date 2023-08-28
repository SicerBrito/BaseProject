﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Data;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(SicerContext))]
    [Migration("20230828135310_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAlumno")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("NombreAlumno");

                    b.HasKey("Id");

                    b.ToTable("Alumno", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdProfesor")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("NombreProfesor");

                    b.HasKey("Id");

                    b.ToTable("Profesor", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Salon", b =>
                {
                    b.Property<int>("IdProfesor")
                        .HasColumnType("int");

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<int>("Nro")
                        .HasColumnType("int");

                    b.HasKey("IdProfesor", "IdAlumno");

                    b.HasIndex("IdAlumno");

                    b.ToTable("Salon");
                });

            modelBuilder.Entity("Dominio.Entities.Salon", b =>
                {
                    b.HasOne("Dominio.Entities.Alumno", "Alumnos")
                        .WithMany("Salones")
                        .HasForeignKey("IdAlumno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Profesor", "Profesores")
                        .WithMany("Salones")
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumnos");

                    b.Navigation("Profesores");
                });

            modelBuilder.Entity("Dominio.Entities.Alumno", b =>
                {
                    b.Navigation("Salones");
                });

            modelBuilder.Entity("Dominio.Entities.Profesor", b =>
                {
                    b.Navigation("Salones");
                });
#pragma warning restore 612, 618
        }
    }
}