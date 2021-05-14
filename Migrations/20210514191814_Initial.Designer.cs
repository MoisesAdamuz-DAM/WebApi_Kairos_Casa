﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPi_Kairos.Contexts;

namespace WebAPi_Kairos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210514191814_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPi_Kairos.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("historialPersona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("necesidadPersona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombrePersona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paisOrigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacionPersona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}