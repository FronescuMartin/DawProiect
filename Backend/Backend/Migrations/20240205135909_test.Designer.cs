﻿// <auto-generated />
using System;
using Backend.ContextModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(BackendContext))]
    [Migration("20240205135909_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Entities.Competitie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Competitie");
                });

            modelBuilder.Entity("Backend.Entities.Persoana", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("data_nasterii")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_tara")
                        .HasColumnType("int");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("taraid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("taraid");

                    b.ToTable("Persoana");
                });

            modelBuilder.Entity("Backend.Entities.Rezultat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<double>("average")
                        .HasColumnType("float");

                    b.Property<int?>("competitieid")
                        .HasColumnType("int");

                    b.Property<int>("id_competitie")
                        .HasColumnType("int");

                    b.Property<int>("id_persoana")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("persoanaid")
                        .HasColumnType("int");

                    b.Property<int>("pozitie")
                        .HasColumnType("int");

                    b.Property<string>("proba")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("single")
                        .HasColumnType("float");

                    b.Property<double>("timp1")
                        .HasColumnType("float");

                    b.Property<double>("timp2")
                        .HasColumnType("float");

                    b.Property<double>("timp3")
                        .HasColumnType("float");

                    b.Property<double>("timp4")
                        .HasColumnType("float");

                    b.Property<double>("timp5")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("competitieid");

                    b.HasIndex("persoanaid");

                    b.ToTable("Rezultat");
                });

            modelBuilder.Entity("Backend.Entities.Tara", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("continent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("iso2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tara");
                });

            modelBuilder.Entity("Backend.Entities.Persoana", b =>
                {
                    b.HasOne("Backend.Entities.Tara", "tara")
                        .WithMany("Persoane")
                        .HasForeignKey("taraid");

                    b.Navigation("tara");
                });

            modelBuilder.Entity("Backend.Entities.Rezultat", b =>
                {
                    b.HasOne("Backend.Entities.Competitie", "competitie")
                        .WithMany("rezultate")
                        .HasForeignKey("competitieid");

                    b.HasOne("Backend.Entities.Persoana", "persoana")
                        .WithMany("rezultate")
                        .HasForeignKey("persoanaid");

                    b.Navigation("competitie");

                    b.Navigation("persoana");
                });

            modelBuilder.Entity("Backend.Entities.Competitie", b =>
                {
                    b.Navigation("rezultate");
                });

            modelBuilder.Entity("Backend.Entities.Persoana", b =>
                {
                    b.Navigation("rezultate");
                });

            modelBuilder.Entity("Backend.Entities.Tara", b =>
                {
                    b.Navigation("Persoane");
                });
#pragma warning restore 612, 618
        }
    }
}
