﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Products.Infrastructure;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240530220834_fix-seed-data")]
    partial class fixseeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Products.Domain.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("BannerUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://placehold.co/500x100.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://placehold.co/85.png");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994));

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("ThumbnailUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://placehold.co/150.png");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mollit exercitation sit laborum id eiusmod eu ad. Qui magna adipisicing amet in magna voluptate id proident qui excepteur minim qui pariatur. Id labore laboris ullamco mollit do deserunt cillum nostrud aliquip consectetur exercitation. Labore aliqua in tempor et qui ullamco commodo ullamco non irure. Excepteur ut sunt in sint id voluptate laborum in ut anim veniam amet laboris tempor. Ex ex magna sunt culpa consectetur.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 7,
                            Permalink = "Head-Moody",
                            Priority = 1,
                            Title = "Morrison Koch"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Culpa esse nulla ipsum dolor in proident irure elit. Sit sunt deserunt fugiat reprehenderit. Enim id eu tempor deserunt laboris deserunt magna. Excepteur aute velit ullamco proident dolore et qui. Sit ut nulla ipsum veniam commodo quis ipsum. Ad aliquip cupidatat pariatur Lorem reprehenderit proident nisi tempor amet aute reprehenderit ipsum excepteur. Eu nulla nostrud velit reprehenderit duis ad proident tempor occaecat quis esse id deserunt.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 10,
                            Permalink = "Amie-Ramos",
                            Priority = 2,
                            Title = "Francisca Shields"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In aute dolor adipisicing deserunt magna nisi exercitation ut velit reprehenderit est Lorem dolor. Ipsum ea id et ullamco exercitation non quis id Lorem elit culpa mollit laboris culpa. Incididunt minim ut est qui excepteur. Do voluptate officia nisi consectetur sit ullamco est sit commodo nulla laborum ex eu veniam. Proident ad est est ullamco consectetur cillum.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Mccullough-Gentry",
                            Priority = 1,
                            Title = "Erna Terrell"
                        },
                        new
                        {
                            Id = 4,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Qui laboris amet dolore cillum deserunt aliquip do aliqua in. Qui ut elit sit laborum amet ipsum. Deserunt proident voluptate occaecat irure sunt consequat amet cupidatat ullamco laborum consequat labore nisi. Nostrud eu eu consequat aliqua Lorem sint do amet qui dolore ut. Eiusmod occaecat excepteur sit et irure sunt officia anim dolor aute veniam quis incididunt. In cillum consectetur deserunt cillum commodo excepteur irure.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Kelli-Guzman",
                            Priority = 1,
                            Title = "Briana Maldonado"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Labore elit ipsum ut enim deserunt. Enim labore cillum laborum laboris in consequat cillum veniam est. Commodo adipisicing enim commodo dolor esse ullamco dolor esse voluptate pariatur esse commodo non ex. Nostrud nisi laboris elit ex tempor pariatur Lorem qui est eu ex.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Jeri-Buckner",
                            Priority = 2,
                            Title = "Copeland Holcomb"
                        },
                        new
                        {
                            Id = 6,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Magna officia quis consectetur aliqua enim dolor consectetur magna cillum. Enim est magna nostrud duis tempor sunt id Lorem. Eiusmod quis dolore occaecat et exercitation. Est magna fugiat dolore non non occaecat. Ex id laboris excepteur eu est consectetur deserunt minim aliqua veniam labore.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Francis-Curtis",
                            Priority = 1,
                            Title = "Elnora Kane"
                        },
                        new
                        {
                            Id = 7,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Anim deserunt eu occaecat sint nisi veniam qui fugiat aute. Commodo nisi nisi aliqua ullamco consequat. Excepteur dolore adipisicing mollit eu laborum cillum nisi. Esse voluptate quis amet dolore nisi voluptate nisi Lorem cillum magna officia. Nostrud irure nulla esse voluptate labore elit excepteur reprehenderit.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Tasha-Craft",
                            Priority = 1,
                            Title = "Smith Wagner"
                        },
                        new
                        {
                            Id = 8,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tempor excepteur qui laborum nulla consectetur. Nulla adipisicing ad incididunt voluptate. Excepteur deserunt dolor non ut aliquip. Et dolor reprehenderit tempor enim do. Culpa adipisicing non consequat cupidatat veniam proident esse et cupidatat amet ea.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 9,
                            Permalink = "Janelle-Lane",
                            Priority = 2,
                            Title = "Olive James"
                        },
                        new
                        {
                            Id = 9,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Velit magna pariatur laborum est ea commodo in ut velit sunt cupidatat incididunt. Mollit et minim sint non labore in excepteur tempor sit. Laboris Lorem incididunt commodo laborum velit proident nulla veniam sunt. Mollit dolor veniam aliqua proident fugiat cillum tempor dolor. Dolore veniam incididunt nisi consectetur deserunt in labore Lorem deserunt.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 3,
                            Permalink = "Elisa-Coleman",
                            Priority = 2,
                            Title = "Adriana Galloway"
                        },
                        new
                        {
                            Id = 10,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Irure consectetur et excepteur pariatur minim culpa. Enim quis officia reprehenderit veniam. Aliqua veniam laborum esse officia consectetur laboris aliqua occaecat fugiat mollit. Aute do pariatur irure do irure fugiat officia sunt amet dolor. Ad consequat quis qui sunt cupidatat laborum excepteur ullamco veniam qui culpa esse commodo sunt.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 8,
                            Permalink = "Justine-Duffy",
                            Priority = 1,
                            Title = "Leslie Jacobs"
                        });
                });

            modelBuilder.Entity("Products.Domain.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://placehold.co/150.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634));

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Active = true,
                            CategoryId = 6,
                            Code = "Vicky",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laboris velit aliquip exercitation eu pariatur magna qui. Aliqua reprehenderit ad reprehenderit Lorem sit do dolor dolor non. Labore fugiat id voluptate nostrud labore eiusmod proident minim. Proident pariatur proident et commodo et anim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Cara-Burt",
                            Price = 0m,
                            Title = "Latonya Fuentes"
                        },
                        new
                        {
                            Id = 13,
                            Active = true,
                            CategoryId = 7,
                            Code = "Daisy",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Magna voluptate aute ut consectetur consequat non est occaecat do non cillum non qui. Labore excepteur ex cupidatat voluptate. Proident elit fugiat ipsum laboris. Dolore pariatur magna aute excepteur ullamco. Laborum elit aliqua id exercitation in incididunt exercitation in nisi. Amet et do non do fugiat labore laborum ullamco pariatur incididunt. Voluptate mollit est id dolore ea id non adipisicing magna minim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Linda-Barrera",
                            Price = 0m,
                            Title = "Wallace Vang"
                        },
                        new
                        {
                            Id = 12,
                            Active = false,
                            CategoryId = 1,
                            Code = "Suzanne",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Non amet irure cupidatat incididunt consectetur nulla officia. Id ea non et ad dolore in consectetur duis dolore consectetur aute. Occaecat duis excepteur magna reprehenderit commodo.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Lee-Brooks",
                            Price = 0m,
                            Title = "Shelby Bray"
                        },
                        new
                        {
                            Id = 14,
                            Active = true,
                            CategoryId = 7,
                            Code = "Roy",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Eu ex irure in non ullamco ea mollit laborum esse aliquip ad pariatur consectetur ex. Aute consectetur anim qui in excepteur amet dolor ea qui. Velit consectetur cillum elit non ut pariatur esse cillum incididunt voluptate dolore ut. Quis commodo exercitation ullamco mollit occaecat.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Stella-Carrillo",
                            Price = 0m,
                            Title = "Kirk Torres"
                        },
                        new
                        {
                            Id = 15,
                            Active = false,
                            CategoryId = 2,
                            Code = "Erickson",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In cillum enim qui et anim excepteur labore esse magna magna aliqua. Aliquip do commodo veniam anim eu consectetur ex ex aliqua dolor. Adipisicing amet eiusmod sint sint labore pariatur. Fugiat elit consequat magna laboris minim qui. Veniam veniam nulla laboris laboris dolor ullamco dolor.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Yesenia-Solis",
                            Price = 0m,
                            Title = "Cote Owens"
                        },
                        new
                        {
                            Id = 16,
                            Active = false,
                            CategoryId = 1,
                            Code = "Traci",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Qui consectetur cillum ullamco adipisicing sint do amet sint commodo consectetur. Pariatur enim ex consequat exercitation reprehenderit proident nostrud commodo nostrud voluptate. Nulla nostrud culpa nulla dolor enim mollit duis ullamco. Esse dolore id ut ex culpa do aute sint. Exercitation ut in eiusmod eu. Enim enim cupidatat deserunt deserunt esse id est. Aliqua sint voluptate in sit ipsum irure.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Rosalind-Porter",
                            Price = 0m,
                            Title = "Massey Campbell"
                        },
                        new
                        {
                            Id = 17,
                            Active = true,
                            CategoryId = 3,
                            Code = "Catherine",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ea duis eu exercitation labore ullamco occaecat elit et et. Sunt est pariatur eu elit consequat aute velit. Laborum adipisicing nisi est voluptate veniam commodo. Consequat consectetur sint do adipisicing esse enim aliqua. Elit irure ut ipsum esse culpa ipsum laboris velit deserunt nisi ipsum aute reprehenderit labore. Aliquip aute do sit anim aute aliquip esse. Non aliquip enim sunt deserunt minim amet laborum consequat laborum laboris mollit commodo eiusmod anim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Marisa-Shepard",
                            Price = 0m,
                            Title = "Betty Thornton"
                        },
                        new
                        {
                            Id = 18,
                            Active = false,
                            CategoryId = 3,
                            Code = "Sherman",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Consectetur culpa ullamco elit eiusmod quis pariatur duis nostrud laboris occaecat aliqua mollit. Labore incididunt consequat dolor reprehenderit quis quis est. Enim sint laboris velit qui. Aliquip in qui amet sint magna cillum sunt mollit. Incididunt magna id in occaecat proident qui aliquip. Eiusmod incididunt cillum ea ullamco ex cillum ipsum ad sit aute. Consectetur amet sunt consectetur enim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Elena-Nielsen",
                            Price = 0m,
                            Title = "Wells Glenn"
                        },
                        new
                        {
                            Id = 19,
                            Active = true,
                            CategoryId = 9,
                            Code = "Walton",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laboris et deserunt deserunt consequat. Pariatur occaecat consectetur in ea mollit ad mollit esse esse aliquip. Quis sint sunt est excepteur magna eu id est amet aliqua deserunt in. Minim laborum aute velit mollit laborum consectetur laborum nostrud sit elit. Eiusmod consequat Lorem minim do occaecat eu aliquip dolore in pariatur consequat commodo cupidatat magna. Enim excepteur culpa non sit eiusmod. Id amet officia aliqua esse culpa eu eu mollit consequat proident est eiusmod proident reprehenderit.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Meredith-Head",
                            Price = 0m,
                            Title = "Fay Arnold"
                        },
                        new
                        {
                            Id = 20,
                            Active = false,
                            CategoryId = 4,
                            Code = "Davidson",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Eiusmod sint id consectetur incididunt ex eiusmod occaecat officia dolore commodo quis. Veniam aliquip ut minim elit irure cupidatat aute magna elit in. Velit exercitation duis minim duis Lorem commodo do. Duis eu dolor do et minim nulla ad id adipisicing pariatur culpa.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Isabel-Cooley",
                            Price = 0m,
                            Title = "Joy Barnett"
                        });
                });

            modelBuilder.Entity("Products.Domain.Categories.Category", b =>
                {
                    b.HasOne("Products.Domain.Categories.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Products.Domain.Products.Product", b =>
                {
                    b.HasOne("Products.Domain.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Products.Domain.Categories.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
