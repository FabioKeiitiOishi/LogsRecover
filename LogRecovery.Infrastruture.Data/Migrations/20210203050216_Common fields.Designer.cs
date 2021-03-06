﻿// <auto-generated />
using System;
using LogRecovery.Infrastruture.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LogRecovery.Infrastruture.Data.Migrations
{
    [DbContext(typeof(LogRecoveryContext))]
    [Migration("20210203050216_Common fields")]
    partial class Commonfields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("LogRecovery.Domain.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<DateTime>("RecordedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("LogsRecoveries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Ip = "192.168.0.1",
                            RecordedTime = new DateTime(2021, 2, 3, 2, 2, 15, 500, DateTimeKind.Local).AddTicks(2921),
                            UserAgent = "GET HTTP 1.0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
