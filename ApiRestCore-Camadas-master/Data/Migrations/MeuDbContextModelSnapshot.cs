// <auto-generated />
using System;
using ApiRestCore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiRestCore.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    partial class MeuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiRestCore.Business.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("FornecedorId");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ApiRestCore.Business.Models.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Documento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TipoFornecedor");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("ApiRestCore.Business.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("FornecedorId");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ApiRestCore.Business.Models.Endereco", b =>
                {
                    b.HasOne("ApiRestCore.Business.Models.Fornecedor", "Fornecedor")
                        .WithOne("Endereco")
                        .HasForeignKey("ApiRestCore.Business.Models.Endereco", "FornecedorId");
                });

            modelBuilder.Entity("ApiRestCore.Business.Models.Produto", b =>
                {
                    b.HasOne("ApiRestCore.Business.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");
                });
#pragma warning restore 612, 618
        }
    }
}
