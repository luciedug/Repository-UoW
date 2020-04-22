﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiFinal;

namespace WebApiFinal.Migrations
{
    [DbContext(typeof(DBnews))]
    [Migration("20200422150048_updatesForPatterns")]
    partial class updatesForPatterns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("WebApiFinal.Models.New", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Test")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("NewsInfo");

                    b.HasData(
                        new
                        {
                            ID = 54,
                            CreatedAt = new DateTime(2020, 4, 22, 17, 0, 48, 116, DateTimeKind.Local).AddTicks(3910),
                            Description = "blabla",
                            Test = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
