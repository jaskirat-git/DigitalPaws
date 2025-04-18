﻿// <auto-generated />
using System;
using DigitalPaws.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigitalPaws.Migrations
{
    [DbContext(typeof(DigitalPawsContext))]
    [Migration("20250328205755_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DigitalPaws.Models.AdoptionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdoptionModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Breed = "Golden Retriever",
                            Contact = "5234567890",
                            ImageUrl = "/images/dog3.jpg",
                            IsAvailable = true,
                            Name = "Jack",
                            Owner = "John Doe",
                            Price = "$500"
                        },
                        new
                        {
                            Id = 2,
                            Breed = "Labrador",
                            Contact = "4234567891",
                            ImageUrl = "/images/Lab.jpg",
                            IsAvailable = true,
                            Name = "Jhonny",
                            Owner = "Jane Doe",
                            Price = "$600"
                        },
                        new
                        {
                            Id = 3,
                            Breed = "Husky",
                            Contact = "7234567893",
                            ImageUrl = "/images/dog4.jpg",
                            IsAvailable = true,
                            Name = "Smarty",
                            Owner = "Rony",
                            Price = "$700"
                        },
                        new
                        {
                            Id = 4,
                            Breed = "German Shepherd",
                            Contact = "8234567894",
                            ImageUrl = "/images/German.jpg",
                            IsAvailable = true,
                            Name = "Jerry",
                            Owner = "Andrew",
                            Price = "$800"
                        },
                        new
                        {
                            Id = 5,
                            Breed = "French Bulldog",
                            Contact = "2234567594",
                            ImageUrl = "/images/bully.jpeg",
                            IsAvailable = true,
                            Name = "Smurf",
                            Owner = "Samson",
                            Price = "$900"
                        },
                        new
                        {
                            Id = 6,
                            Breed = "Rottweiler",
                            Contact = "6234563890",
                            ImageUrl = "/images/Roty.jpg",
                            IsAvailable = true,
                            Name = "fiend",
                            Owner = "Chris",
                            Price = "$1000"
                        },
                        new
                        {
                            Id = 7,
                            Breed = "Pomeranian",
                            Contact = "9234567820",
                            ImageUrl = "images/Pom.jpg",
                            IsAvailable = false,
                            Name = "Spencer",
                            Owner = "David",
                            Price = "$700"
                        },
                        new
                        {
                            Id = 8,
                            Breed = "Doberman Pincher",
                            Contact = "2234565666",
                            ImageUrl = "/images/Doby.jpg",
                            IsAvailable = false,
                            Name = "Nox",
                            Owner = "Derek",
                            Price = "$800"
                        },
                        new
                        {
                            Id = 9,
                            Breed = "Boxer",
                            Contact = "3234567446",
                            ImageUrl = "/images/boxer.jpg",
                            IsAvailable = false,
                            Name = "Bear",
                            Owner = "Dylan",
                            Price = "$900"
                        },
                        new
                        {
                            Id = 10,
                            Breed = "Shiba Inu",
                            Contact = "6126457690",
                            ImageUrl = "/images/Shiba.jpg",
                            IsAvailable = false,
                            Name = "Timmy",
                            Owner = "Dexter",
                            Price = "$1000"
                        },
                        new
                        {
                            Id = 11,
                            Breed = "British Short Haired",
                            Contact = "8916457690",
                            ImageUrl = "/images/britis.jpeg",
                            IsAvailable = true,
                            Name = "Tom",
                            Owner = "Kelly",
                            Price = "$500"
                        },
                        new
                        {
                            Id = 12,
                            Breed = "Bombay",
                            Contact = "4381237690",
                            ImageUrl = "/images/Bombay.jpg",
                            IsAvailable = false,
                            Name = "Charmy",
                            Owner = "Alize",
                            Price = "$650"
                        },
                        new
                        {
                            Id = 13,
                            Breed = "American Curl",
                            Contact = "7651237694",
                            ImageUrl = "/images/AmericanCurl.jpg",
                            IsAvailable = true,
                            Name = "Chase",
                            Owner = "Jeremy",
                            Price = "$550"
                        },
                        new
                        {
                            Id = 14,
                            Breed = "Somali",
                            Contact = "4321247634",
                            ImageUrl = "/images/somali.jpg",
                            IsAvailable = true,
                            Name = "Candy",
                            Owner = "Casey",
                            Price = "$450"
                        },
                        new
                        {
                            Id = 15,
                            Breed = "Albino Budgerigar",
                            Contact = "8321247635",
                            ImageUrl = "/images/bud.jpg",
                            IsAvailable = true,
                            Name = "Cane",
                            Owner = "Kate",
                            Price = "$450"
                        },
                        new
                        {
                            Id = 16,
                            Breed = "Ring Neck Parakeet",
                            Contact = "9321287635",
                            ImageUrl = "/images/ring.jpg",
                            IsAvailable = true,
                            Name = "Honey",
                            Owner = "Shelly",
                            Price = "$450"
                        },
                        new
                        {
                            Id = 17,
                            Breed = "Scarlet Macaw",
                            Contact = "5321287635",
                            ImageUrl = "/images/macaw.jpg",
                            IsAvailable = false,
                            Name = "Andrei",
                            Owner = "Seth",
                            Price = "$450"
                        });
                });

            modelBuilder.Entity("DigitalPaws.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayPictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("QRCodeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("DigitalPaws.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DigitalPaws.Models.Pet", b =>
                {
                    b.HasOne("DigitalPaws.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
