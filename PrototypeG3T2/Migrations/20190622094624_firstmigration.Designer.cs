﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrototypeG3T2.Data;

namespace PrototypeG3T2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190622094624_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrototypeG3T2.Models.Klant", b =>
                {
                    b.Property<int>("KlantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BedrijfsNaam");

                    b.Property<string>("EmailAdres");

                    b.HasKey("KlantId");

                    b.ToTable("Klanten");
                });

            modelBuilder.Entity("PrototypeG3T2.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemNaam");

                    b.Property<int>("KlantId");

                    b.HasKey("OrderId");

                    b.HasIndex("KlantId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PrototypeG3T2.Models.SensorData", b =>
                {
                    b.Property<int>("SensorDataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<bool>("Qwaarde");

                    b.Property<string>("SensorNaam");

                    b.Property<string>("Twaarde");

                    b.Property<double>("Vwaarde");

                    b.HasKey("SensorDataId");

                    b.HasIndex("OrderId");

                    b.ToTable("SensorDatas");
                });

            modelBuilder.Entity("PrototypeG3T2.Models.Order", b =>
                {
                    b.HasOne("PrototypeG3T2.Models.Klant")
                        .WithMany("OrderList")
                        .HasForeignKey("KlantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrototypeG3T2.Models.SensorData", b =>
                {
                    b.HasOne("PrototypeG3T2.Models.Order")
                        .WithMany("SensorDataList")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}