﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using labSchool.Context;

#nullable disable

namespace labSchool.Migrations
{
    [DbContext(typeof(LabSchoolContext))]
    [Migration("20230413121657_AddDados")]
    partial class AddDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("labSchool.Models.Aluno", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("CPF")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data_Nascimento")
                        .HasColumnOrder(4);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome")
                        .HasColumnOrder(2);

                    b.Property<float>("NotaProcessoSeletivo")
                        .HasColumnType("REAL")
                        .HasColumnName("Nota")
                        .HasColumnOrder(7);

                    b.Property<string>("SituacaoMatricula")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Situação_Matrícula")
                        .HasColumnOrder(6);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone")
                        .HasColumnOrder(3);

                    b.Property<int>("TotalAtendimentosPedagogicos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("Atendimentos")
                        .HasColumnOrder(8);

                    b.HasKey("Codigo");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("labSchool.Models.Pedagogo", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("CPF")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data_Nascimento")
                        .HasColumnOrder(4);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome")
                        .HasColumnOrder(2);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone")
                        .HasColumnOrder(3);

                    b.Property<int>("TotalAtendimentosPedagogicos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("Atendimentos")
                        .HasColumnOrder(6);

                    b.HasKey("Codigo");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.ToTable("Pedagogo", (string)null);
                });

            modelBuilder.Entity("labSchool.Models.Professor", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("CPF")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data_Nascimento")
                        .HasColumnOrder(4);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Estado")
                        .HasColumnOrder(8);

                    b.Property<string>("Experiencia")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Experiência")
                        .HasColumnOrder(7);

                    b.Property<string>("FormacaoAcademica")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Formação_Acadêmica")
                        .HasColumnOrder(6);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Nome")
                        .HasColumnOrder(2);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone")
                        .HasColumnOrder(3);

                    b.HasKey("Codigo");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.ToTable("Professor", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
