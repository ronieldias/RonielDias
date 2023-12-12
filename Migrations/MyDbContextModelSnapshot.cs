﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RonielDias.Models;

#nullable disable

namespace RonielDias.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RonielDias.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("RonielDias.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NotaVendaId")
                        .HasColumnType("int");

                    b.Property<double>("Percentual")
                        .HasColumnType("double");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaVendaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("RonielDias.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("RonielDias.Models.NotaVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PagamentoId");

                    b.HasIndex("TransportadoraId");

                    b.HasIndex("VendedorId");

                    b.ToTable("NotasVendas");
                });

            modelBuilder.Entity("RonielDias.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Pagou")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("RonielDias.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("RonielDias.Models.TipoPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaVendaId");

                    b.ToTable("TiposPagamentos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoPagamento");
                });

            modelBuilder.Entity("RonielDias.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transportadoras");
                });

            modelBuilder.Entity("RonielDias.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("RonielDias.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("RonielDias.Models.TipoPagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("RonielDias.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("RonielDias.Models.TipoPagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("RonielDias.Models.Item", b =>
                {
                    b.HasOne("RonielDias.Models.NotaVenda", null)
                        .WithMany("Items")
                        .HasForeignKey("NotaVendaId");

                    b.HasOne("RonielDias.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("RonielDias.Models.NotaVenda", b =>
                {
                    b.HasOne("RonielDias.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RonielDias.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RonielDias.Models.Transportadora", "Transportadora")
                        .WithMany()
                        .HasForeignKey("TransportadoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RonielDias.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Pagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("RonielDias.Models.Produto", b =>
                {
                    b.HasOne("RonielDias.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("RonielDias.Models.TipoPagamento", b =>
                {
                    b.HasOne("RonielDias.Models.NotaVenda", null)
                        .WithMany("TipoPagamentos")
                        .HasForeignKey("NotaVendaId");
                });

            modelBuilder.Entity("RonielDias.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("RonielDias.Models.NotaVenda", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("TipoPagamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
