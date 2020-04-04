﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI2.Models;

namespace WebAPI2.Migrations.Hour
{
    [DbContext(typeof(HourContext))]
    partial class HourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI2.Models.HourDetail", b =>
                {
                    b.Property<int>("HourId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Hour")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TattooArtist")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("HourId");

                    b.ToTable("HourDetails");
                });
#pragma warning restore 612, 618
        }
    }
}