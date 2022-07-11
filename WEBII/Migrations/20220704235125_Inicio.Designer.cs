﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBII.Data;

#nullable disable

namespace WEBII.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220704235125_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WEBII.Data.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WEBII.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("disciplina_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("disciplina_categoria");

                    b.Property<int>("Creditos")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_creditos");

                    b.Property<double>("Dificuldade")
                        .HasColumnType("float")
                        .HasColumnName("disciplina_dificuldade");

                    b.Property<string>("Ementa")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("disciplina_ementa");

                    b.Property<int>("HoraAula")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_horaAula");

                    b.Property<int>("HoraRelogio")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_horaRelogio");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("disciplina_nome");

                    b.Property<int>("Periodo")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_periodo");

                    b.Property<int>("qtdPratica")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_qtdPratica");

                    b.Property<int>("qtdTeorica")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_qtdTeorica");

                    b.HasKey("Id");

                    b.ToTable("disciplinas");
                });

            modelBuilder.Entity("WEBII.PreRequisito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("requisitos_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Creditos")
                        .HasColumnType("int")
                        .HasColumnName("requisitos_creditos");

                    b.Property<int>("Disciplina_Id")
                        .HasColumnType("int")
                        .HasColumnName("disciplina_id");

                    b.Property<string>("Disciplina_Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("disciplina_nome");

                    b.Property<int>("Periodo")
                        .HasColumnType("int")
                        .HasColumnName("requisitos_periodo");

                    b.Property<string>("Requisitos")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("requisitos_disciplina");

                    b.HasKey("Id");

                    b.ToTable("prerequisitos");
                });
#pragma warning restore 612, 618
        }
    }
}
