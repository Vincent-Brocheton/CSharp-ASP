﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace projetApiAsp.Migrations
{
    [DbContext(typeof(RepoContext))]
    [Migration("20210604121142_JeuDeDonneesSimple")]
    partial class JeuDeDonneesSimple
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Employe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmployeId");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("EntrepriseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Poste")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EntrepriseId");

                    b.ToTable("Employes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("43f1944b-171c-40f7-87b1-c337a9b5e2b7"),
                            Age = 29,
                            EntrepriseId = new Guid("77244da1-8235-4420-97e5-621dc1af1277"),
                            Nom = "Patrice Gahide",
                            Poste = "Formateur"
                        },
                        new
                        {
                            Id = new Guid("9f0686e4-6340-4f81-8a79-fdd4010ad428"),
                            Age = 28,
                            EntrepriseId = new Guid("20b02fd7-6b6e-494c-8769-b1c351b27e1d"),
                            Nom = "Vincent Brocheton",
                            Poste = "Formateur"
                        });
                });

            modelBuilder.Entity("Entities.Entreprise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EntrepriseId");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entreprises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77244da1-8235-4420-97e5-621dc1af1277"),
                            Adresse = "Dampierre - Valarep",
                            Nom = "Valarep",
                            Pays = "France"
                        },
                        new
                        {
                            Id = new Guid("20b02fd7-6b6e-494c-8769-b1c351b27e1d"),
                            Adresse = "Dampierre - Valarep",
                            Nom = "Dampierre",
                            Pays = "France"
                        });
                });

            modelBuilder.Entity("Entities.Employe", b =>
                {
                    b.HasOne("Entities.Entreprise", "entreprise")
                        .WithMany("Employes")
                        .HasForeignKey("EntrepriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("entreprise");
                });

            modelBuilder.Entity("Entities.Entreprise", b =>
                {
                    b.Navigation("Employes");
                });
#pragma warning restore 612, 618
        }
    }
}