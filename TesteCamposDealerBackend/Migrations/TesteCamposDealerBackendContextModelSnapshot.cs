﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteCamposDealerBackend.Data;

#nullable disable

namespace TesteCamposDealerBackend.Migrations
{
    [DbContext(typeof(TesteCamposDealerBackendContext))]
    partial class TesteCamposDealerBackendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TesteCamposDealerBackend.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("Text")
                        .HasColumnName("cidade");

                    b.Property<string>("nmCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nmCliente");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes", (string)null);

                    b.HasData(
                        new
                        {
                            idCliente = 1,
                            Cidade = "Cidade1",
                            nmCliente = "Cli1"
                        },
                        new
                        {
                            idCliente = 2,
                            Cidade = "Cidade2",
                            nmCliente = "Cli2"
                        },
                        new
                        {
                            idCliente = 3,
                            Cidade = "Cidade3",
                            nmCliente = "Cli3"
                        },
                        new
                        {
                            idCliente = 4,
                            Cidade = "Cidade4",
                            nmCliente = "Cli4"
                        });
                });

            modelBuilder.Entity("TesteCamposDealerBackend.Models.Produto", b =>
                {
                    b.Property<int>("idProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProduto"));

                    b.Property<string>("dscProduto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("dscProduto");

                    b.Property<float>("vlrUnitario")
                        .HasColumnType("real")
                        .HasColumnName("vlrUnitario");

                    b.HasKey("idProduto");

                    b.ToTable("Produtos", (string)null);

                    b.HasData(
                        new
                        {
                            idProduto = 1,
                            dscProduto = "Produto 1",
                            vlrUnitario = 5f
                        },
                        new
                        {
                            idProduto = 2,
                            dscProduto = "Produto 2",
                            vlrUnitario = 10f
                        },
                        new
                        {
                            idProduto = 3,
                            dscProduto = "Produto 3",
                            vlrUnitario = 15f
                        },
                        new
                        {
                            idProduto = 4,
                            dscProduto = "Produto 4",
                            vlrUnitario = 20f
                        });
                });

            modelBuilder.Entity("TesteCamposDealerBackend.Models.Venda", b =>
                {
                    b.Property<int>("idVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idVenda"));

                    b.Property<DateTime>("dthVenda")
                        .HasColumnType("datetime2")
                        .HasColumnName("dthVenda");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idProduto")
                        .HasColumnType("int");

                    b.Property<int>("qtdVenda")
                        .HasColumnType("int")
                        .HasColumnName("qtdVenda");

                    b.Property<float>("vlrTotalVenda")
                        .HasColumnType("real")
                        .HasColumnName("vlrTotalVenda");

                    b.Property<float>("vlrUnitarioVenda")
                        .HasColumnType("real")
                        .HasColumnName("vlrUnitarioVenda");

                    b.HasKey("idVenda");

                    b.HasIndex("idCliente");

                    b.HasIndex("idProduto");

                    b.ToTable("Vendas", (string)null);

                    b.HasData(
                        new
                        {
                            idVenda = 1,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 1,
                            idProduto = 1,
                            qtdVenda = 5,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 5f
                        },
                        new
                        {
                            idVenda = 2,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 1,
                            idProduto = 2,
                            qtdVenda = 1,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 10f
                        },
                        new
                        {
                            idVenda = 3,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 1,
                            idProduto = 3,
                            qtdVenda = 1,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 15f
                        },
                        new
                        {
                            idVenda = 4,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 2,
                            idProduto = 1,
                            qtdVenda = 5,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 5f
                        },
                        new
                        {
                            idVenda = 5,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 2,
                            idProduto = 2,
                            qtdVenda = 1,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 10f
                        },
                        new
                        {
                            idVenda = 6,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 3,
                            idProduto = 1,
                            qtdVenda = 10,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 6f
                        },
                        new
                        {
                            idVenda = 7,
                            dthVenda = new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc),
                            idCliente = 3,
                            idProduto = 3,
                            qtdVenda = 2,
                            vlrTotalVenda = 0f,
                            vlrUnitarioVenda = 15f
                        });
                });

            modelBuilder.Entity("TesteCamposDealerBackend.Models.Venda", b =>
                {
                    b.HasOne("TesteCamposDealerBackend.Models.Cliente", "Cliente")
                        .WithMany("vendas")
                        .HasForeignKey("idCliente");

                    b.HasOne("TesteCamposDealerBackend.Models.Produto", "Produto")
                        .WithMany("vendas")
                        .HasForeignKey("idProduto");

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TesteCamposDealerBackend.Models.Cliente", b =>
                {
                    b.Navigation("vendas");
                });

            modelBuilder.Entity("TesteCamposDealerBackend.Models.Produto", b =>
                {
                    b.Navigation("vendas");
                });
#pragma warning restore 612, 618
        }
    }
}