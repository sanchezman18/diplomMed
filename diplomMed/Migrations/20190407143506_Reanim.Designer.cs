﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using diplomMed.Models;

namespace diplomMed.Migrations
{
    [DbContext(typeof(diplomMedContext))]
    [Migration("20190407143506_Reanim")]
    partial class Reanim
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("diplomMed.Models.Defs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Auto");

                    b.Property<string>("Ekg");

                    b.Property<int>("EquipId");

                    b.Property<string>("Manual");

                    b.Property<string>("Press");

                    b.Property<string>("Printer");

                    b.Property<string>("PulsOxx");

                    b.Property<string>("Size");

                    b.Property<string>("Synchr");

                    b.Property<string>("Voice");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("Defs");
                });

            modelBuilder.Entity("diplomMed.Models.Ekg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConnectPc");

                    b.Property<int>("EquipId");

                    b.Property<string>("MemorySize");

                    b.Property<string>("SignalProccesing");

                    b.Property<string>("Size");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("Ekgs");
                });

            modelBuilder.Entity("diplomMed.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Categ1");

                    b.Property<bool>("Categ2");

                    b.Property<bool>("Categ3");

                    b.Property<string>("Country");

                    b.Property<string>("Developer");

                    b.Property<string>("EquipType");

                    b.Property<string>("Model");

                    b.Property<byte[]>("Photo");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Equips");
                });

            modelBuilder.Entity("diplomMed.Models.Ivl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatteryType");

                    b.Property<int>("EquipId");

                    b.Property<string>("Time");

                    b.Property<string>("TimeCharging");

                    b.Property<string>("WorkModes");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("Ivls");
                });

            modelBuilder.Entity("diplomMed.Models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<string>("Diagonal");

                    b.Property<string>("Ekg");

                    b.Property<int>("EquipId");

                    b.Property<string>("Kapn");

                    b.Property<string>("Pulsoxxx");

                    b.Property<string>("Resol");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("diplomMed.Models.PulsOxx", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Batteries");

                    b.Property<string>("Battery");

                    b.Property<string>("Display");

                    b.Property<int>("EquipId");

                    b.Property<string>("Memory");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("PulsOxx");
                });

            modelBuilder.Entity("diplomMed.Models.Reanim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("EquipId");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("Reanims");
                });

            modelBuilder.Entity("diplomMed.Models.Stretcher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EquipId");

                    b.Property<string>("FoldedCondition");

                    b.Property<string>("WorkingCondition");

                    b.HasKey("Id");

                    b.HasIndex("EquipId")
                        .IsUnique();

                    b.ToTable("Stretchers");
                });

            modelBuilder.Entity("diplomMed.Models.Defs", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("Defs")
                        .HasForeignKey("diplomMed.Models.Defs", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("diplomMed.Models.Ekg", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("Ekgs")
                        .HasForeignKey("diplomMed.Models.Ekg", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("diplomMed.Models.Ivl", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("Ivls")
                        .HasForeignKey("diplomMed.Models.Ivl", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("diplomMed.Models.Monitor", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("Monitors")
                        .HasForeignKey("diplomMed.Models.Monitor", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("diplomMed.Models.PulsOxx", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("PulsOxxs")
                        .HasForeignKey("diplomMed.Models.PulsOxx", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("diplomMed.Models.Reanim", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("Reanims")
                        .HasForeignKey("diplomMed.Models.Reanim", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("diplomMed.Models.Stretcher", b =>
                {
                    b.HasOne("diplomMed.Models.Equipment", "Equip")
                        .WithOne("Stretchers")
                        .HasForeignKey("diplomMed.Models.Stretcher", "EquipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
