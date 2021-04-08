﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using aula2.context;

namespace aula2.Migrations
{
    [DbContext(typeof(LocalDBContext))]
    [Migration("20210408015730_adicinando categoria ")]
    partial class adicinandocategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("aula2.entities.Categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.HasKey("id");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("aula2.entities.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.Property<string>("nome");

                    b.Property<double>("valor");

                    b.HasKey("id");

                    b.ToTable("produto");
                });
#pragma warning restore 612, 618
        }
    }
}
