﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace XPANDApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200526201348_AddRobots")]
    partial class AddRobots
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Captain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CaptainId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("CaptainName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Captain");
                });

            modelBuilder.Entity("Entities.Models.Description", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CaptainId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnName("DescriptionText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaptainId");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("Entities.Models.Planet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PlanetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DescriptionId")
                        .HasColumnName("DescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .HasColumnName("PlanetImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("PlanetName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte>("Status")
                        .HasColumnName("PlanetStatus")
                        .HasColumnType("tinyint");

                    b.HasKey("ID");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Planet");
                });

            modelBuilder.Entity("Entities.Models.Robot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RobotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("RobotName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Robot");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc56ddf7-06a2-4d2f-9890-f2f7db1f2df7"),
                            Name = "T0"
                        },
                        new
                        {
                            Id = new Guid("5992b72c-cfe9-44c0-aee2-0e4ce652d5c0"),
                            Name = "T1"
                        });
                });

            modelBuilder.Entity("Entities.Models.Description", b =>
                {
                    b.HasOne("Entities.Models.Captain", "Captain")
                        .WithMany()
                        .HasForeignKey("CaptainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Planet", b =>
                {
                    b.HasOne("Entities.Models.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Robot", b =>
                {
                    b.HasOne("Entities.Models.Description", null)
                        .WithMany("Robots")
                        .HasForeignKey("DescriptionId");
                });
#pragma warning restore 612, 618
        }
    }
}
