﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exerciciosAPI.Context;

#nullable disable

namespace exerciciosAPI.Migrations
{
    [DbContext(typeof(FichaContext))]
    partial class FichaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exerciciosAPI.Models.DetalheModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeedBack")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FichaId")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("DetalheModels");
                });

            modelBuilder.Entity("exerciciosAPI.Models.FichaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("FichaModels");
                });

            modelBuilder.Entity("exerciciosAPI.Models.TelefoneModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("DDD")
                        .HasColumnType("int");

                    b.Property<int>("FichaId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("TelefoneModels");
                });

            modelBuilder.Entity("exerciciosAPI.Models.DetalheModel", b =>
                {
                    b.HasOne("exerciciosAPI.Models.FichaModel", "Ficha")
                        .WithMany("Detalhes")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("exerciciosAPI.Models.TelefoneModel", b =>
                {
                    b.HasOne("exerciciosAPI.Models.FichaModel", "Ficha")
                        .WithMany("Telefones")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("exerciciosAPI.Models.FichaModel", b =>
                {
                    b.Navigation("Detalhes");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
