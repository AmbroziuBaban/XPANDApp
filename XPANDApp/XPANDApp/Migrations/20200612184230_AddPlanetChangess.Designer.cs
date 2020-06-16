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
    [Migration("20200612184230_AddPlanetChangess")]
    partial class AddPlanetChangess
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

            modelBuilder.Entity("Entities.Models.DescriptionRobot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DescriptionRobotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RobotId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("RobotId");

                    b.ToTable("DescriptionRobot");
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("RobotName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Robot");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30e6bb78-6863-47ff-bf3f-62ee6e43c5c6"),
                            Name = "T0"
                        },
                        new
                        {
                            Id = new Guid("3dde5406-fcab-4b53-8a80-14c3f8cda7d5"),
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

            modelBuilder.Entity("Entities.Models.DescriptionRobot", b =>
                {
                    b.HasOne("Entities.Models.Description", "Description")
                        .WithMany("DescriptionRobots")
                        .HasForeignKey("DescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Robot", "Robot")
                        .WithMany()
                        .HasForeignKey("RobotId")
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
#pragma warning restore 612, 618
        }
    }
}
