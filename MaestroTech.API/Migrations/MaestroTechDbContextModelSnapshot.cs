﻿// <auto-generated />
using System;
using MaestroTech.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaestroTech.API.Migrations
{
    [DbContext(typeof(MaestroTechDbContext))]
    partial class MaestroTechDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaestroTech.Domain.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Culto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiaDaSemana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IgrejaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IgrejaId");

                    b.ToTable("Cultos");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Igreja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Igrejas");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cantores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaDePreferencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IgrejaId")
                        .HasColumnType("int");

                    b.Property<string>("LinkSpotify")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkYouTube")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IgrejaId");

                    b.ToTable("Musicas");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("IgrejaId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IgrejaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Culto", b =>
                {
                    b.HasOne("MaestroTech.Domain.Entities.Igreja", "Igreja")
                        .WithMany("DiasDeCulto")
                        .HasForeignKey("IgrejaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Musica", b =>
                {
                    b.HasOne("MaestroTech.Domain.Entities.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("MaestroTech.Domain.Entities.Igreja", "Igreja")
                        .WithMany("Usuarios")
                        .HasForeignKey("IgrejaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");
                });

            modelBuilder.Entity("MaestroTech.Domain.Entities.Igreja", b =>
                {
                    b.Navigation("DiasDeCulto");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
