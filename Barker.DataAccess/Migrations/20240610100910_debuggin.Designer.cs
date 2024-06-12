﻿// <auto-generated />
using Barker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Barker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240610100910_debuggin")]
    partial class debuggin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Barker.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Вершина якості",
                            Img = "/img/barker_anniv_header16_1.jpg",
                            Name = "Anniversary"
                        },
                        new
                        {
                            Id = 2,
                            Description = "2",
                            Img = "/img/barker_anniv_header16_1.jpg",
                            Name = "Handcrafted"
                        },
                        new
                        {
                            Id = 3,
                            Description = "3",
                            Img = "/img/barker_anniv_header16_1.jpg",
                            Name = "Country"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}