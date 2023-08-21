﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("exerciciosAPI.Models.DetalheModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 8, 21, 15, 33, 46, 135, DateTimeKind.Local).AddTicks(6770));

                    b.Property<string>("FeedBack")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FichaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("DetalheModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FeedBack = "Maravilhoso",
                            FichaId = 1,
                            Nota = 5
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FeedBack = "Ótimo!",
                            FichaId = 2,
                            Nota = 4
                        });
                });

            modelBuilder.Entity("exerciciosAPI.Models.FichaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 8, 21, 15, 33, 46, 135, DateTimeKind.Local).AddTicks(6980));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "carolkboabaid@gmail.com",
                            Nome = "Maria Boabaid"
                        },
                        new
                        {
                            Id = 2,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1995, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alexandrenolla@gmail.com",
                            Nome = "Alexandre Nolla"
                        },
                        new
                        {
                            Id = 3,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "henriquenolla@gmail.com",
                            Nome = "Henrique Nolla"
                        },
                        new
                        {
                            Id = 4,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fernandasilva@gmail.com",
                            Nome = "Fernanda Silva"
                        },
                        new
                        {
                            Id = 5,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1990, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gabrielsousa@gmail.com",
                            Nome = "Gabriel Sousa"
                        },
                        new
                        {
                            Id = 6,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1997, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ottoknudsen@gmail.com",
                            Nome = "Otto Knudsen"
                        },
                        new
                        {
                            Id = 7,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1995, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sofiatunner@gmail.com",
                            Nome = "Sofia Tunner"
                        },
                        new
                        {
                            Id = 8,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1993, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "danielwisser@gmail.com",
                            Nome = "Daniel Wisser"
                        },
                        new
                        {
                            Id = 9,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luizagoncalves@gmail.com",
                            Nome = "Luiza Gonçalves"
                        },
                        new
                        {
                            Id = 10,
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1998, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mariaeugeniasilvester@gmail.com",
                            Nome = "Maria Eugenia Silvester"
                        });
                });

            modelBuilder.Entity("exerciciosAPI.Models.TelefoneModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FichaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("TelefoneModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DDD = "048",
                            FichaId = 1,
                            Numero = "999337729"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DDD = "048",
                            FichaId = 2,
                            Numero = "999448899"
                        });
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
