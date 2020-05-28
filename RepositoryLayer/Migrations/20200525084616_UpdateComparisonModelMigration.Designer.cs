﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(QuantityDBContext))]
    [Migration("20200525084616_UpdateComparisonModelMigration")]
    partial class UpdateComparisonModelMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommonLayer.Model.ComparisonModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Result")
                        .IsRequired();

                    b.Property<decimal>("Value_One")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Value_One_Unit")
                        .IsRequired();

                    b.Property<decimal>("Value_Two")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Value_Two_Unit")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Comparisons");
                });

            modelBuilder.Entity("CommonLayer.Model.QuantityModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationType")
                        .IsRequired();

                    b.Property<decimal>("Result")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Quantities");
                });
#pragma warning restore 612, 618
        }
    }
}
