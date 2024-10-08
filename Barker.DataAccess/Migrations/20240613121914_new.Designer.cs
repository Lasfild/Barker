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
    [Migration("20240613121914_new")]
    partial class @new
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
                            Img = "/img/category_img/barker_cat_anniv.jpg",
                            Name = "anniversary"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ручна робота",
                            Img = "/img/category_img/barker_cat_handc.jpg",
                            Name = "handcrafted"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Потовщена підошва",
                            Img = "/img/category_img/barker_cat_country.jpg",
                            Name = "country"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Сучасний дизайн",
                            Img = "/img/category_img/barker_cat_creative.jpg",
                            Name = "creative"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Гнучкі та легкі",
                            Img = "/img/category_img/barker_cat_flex.jpg",
                            Name = "barkerflex"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Класика поза часом",
                            Img = "/img/category_img/barker_cat_prof.jpg",
                            Name = "professional"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Винятковий комфорт",
                            Img = "/img/category_img/mocc-category_2.jpg",
                            Name = "moccasin"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Стильні та якісні аксесуари",
                            Img = "/img/category_img/accesory_cat.jpg",
                            Name = "accessory"
                        });
                });

            modelBuilder.Entity("Barker.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullness")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Shoe")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoleMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopMaterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Color = "ROSEWOOD",
                            Country = "Англія",
                            Description = "Колекція Handcrafted - це вершина майстерності англійських майстрів фабрики Barker. Історичний текст, вигравіюваний на шкіряній підошві - це дуже вишукано! Відрізний носок з перфорацією та довгий вінгтіп посилює враження.",
                            Fullness = "G",
                            Img = "[\"/img/product_Img/AntiqueRosewood/Lerwick-431527_AntiqueRosewood_1080x.png\",\"/img/product_img/AntiqueRosewood/Lerwick_431527_AntiqueRosewoodCalf_side_1024x6002x.png\",\"/img/product_img/AntiqueRosewood/Lerwick_431527_AntiqueRosewood_top_1024x6002x.png\",\"/img/product_img/AntiqueRosewood/Rochester_380417_7mm_Leather_464Last_1024x6002x.png\"]",
                            IsAvailable = false,
                            IsOnSale = false,
                            Name = "Lerwick Antique Rosewood",
                            Price = 21400m,
                            Shoe = 464,
                            Size = "[6,8.5,9]",
                            Sole = "шкіра",
                            SoleMethod = "рантовий",
                            Style = "оксфорд",
                            TopMaterial = "Натуральна шкіра",
                            VendorCode = 431527
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Color = "ROSEWOOD",
                            Country = "Англія",
                            Description = "Бездоганні оксфорди із одного цільного шматка шкіри, ручна робота, Goodyear welted, дизайн та виробництво - Англія. Ювілейна колекція. В наявності і в чорному кольорі.",
                            Fullness = "FX",
                            Img = "[\"/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf.png\",\"/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf_side.png\",\"/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf_top.png\",\"/img/product_Img/AlderneyRosewood/alderney_3220_handcrafted_7mm_leather_396_last.png\"]",
                            IsAvailable = true,
                            IsOnSale = true,
                            Name = "Alderney-Rosewood",
                            Price = 21400m,
                            Shoe = 396,
                            Size = "[9,10,12]",
                            Sole = "шкіра",
                            SoleMethod = "рантовий",
                            Style = "оксфорд",
                            TopMaterial = "Натуральна шкіра",
                            VendorCode = 322026
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Color = "BLACK",
                            Country = "Англія",
                            Description = "Класичні оксфорди з перфорацією на носку. Комбінація гладкої та зернистої телячої шкіри. Будуть стильним доповненням вашого формального костюма.",
                            Fullness = "G",
                            Img = "[\"/img/product_Img/FloreBlack/flore_blackcalfgrain_angle_1.png\",\"/img/product_img/FloreBlack/flore_blackcalfgrain_side.png\",\"/img/product_img/FloreBlack/flore_blackcalf_top.png\",\"/img/product_img/FloreBlack/warrington_392737_last464_script-sole_3_2.png\"]",
                            IsAvailable = true,
                            IsOnSale = false,
                            Name = "Flore Black",
                            Price = 17000m,
                            Shoe = 464,
                            Size = "[9,10,11]",
                            Sole = "Шкіра",
                            SoleMethod = "Рантовий",
                            Style = "Оксфорд",
                            TopMaterial = "Натуральна шкіра",
                            VendorCode = 411917
                        });
                });

            modelBuilder.Entity("Barker.Models.ProductModel", b =>
                {
                    b.HasOne("Barker.Models.CategoryModel", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Barker.Models.CategoryModel", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
