﻿// <auto-generated />
using MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220914130240_Many-to-Many")]
    partial class ManytoMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<int>("LanguagesLangId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesLangId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("LanguagePerson");

                    b.HasData(
                        new
                        {
                            LanguagesLangId = 1,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesLangId = 1,
                            PeopleId = 2
                        },
                        new
                        {
                            LanguagesLangId = 1,
                            PeopleId = 3
                        });
                });

            modelBuilder.Entity("MVC.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Roma"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Kinsasha"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 4,
                            Name = "Madrid"
                        });
                });

            modelBuilder.Entity("MVC.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Angola"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Spain"
                        });
                });

            modelBuilder.Entity("MVC.Models.Language", b =>
                {
                    b.Property<int>("LangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LangId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LangId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LangId = 1,
                            Name = "Arabic"
                        },
                        new
                        {
                            LangId = 2,
                            Name = "Spanish"
                        },
                        new
                        {
                            LangId = 3,
                            Name = "English"
                        },
                        new
                        {
                            LangId = 4,
                            Name = "Somali"
                        });
                });

            modelBuilder.Entity("MVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Peter Schumacher",
                            Phone = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Name = "Faire Fanny",
                            Phone = "234567890"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Name = "Nicky Lauda",
                            Phone = "345678912"
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("MVC.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesLangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.Models.City", b =>
                {
                    b.HasOne("MVC.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MVC.Models.Person", b =>
                {
                    b.HasOne("MVC.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MVC.Models.City", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
